using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketBLL.SuperMarketCashier;
using SuperMarketModel;
using SuperMarketCommon;
using SuperMarketIBLL.SuperMarketCashier;
using System.Drawing.Printing;

namespace SuperMarketCashler
{
    public partial class FrmMain : Form
    {
        ISuperMarketSaleManager saleManager = new SuperMarketSaleManager();
        ISuperMarketProductManager productManager = new SuperMarketProductManager();
        //装购物车中的商品列表
        List<Produts> productList = new List<Produts>();
        BindingSource bs = new BindingSource();//起一个缓冲作用 封装窗体的数据源 用来调节数据源与容器之间的数据变换关系
        //1.营业员登录成功，进入系统成功
        public FrmMain()
        {
            InitializeComponent();
            timer1.Start();
            this.FormClosing += FrmMain_FormClosing;
            this.FormBorderStyle = FormBorderStyle.None;//边框样式
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            toollblName.Text = $"收银员 【{Program.Sales.SPName}】";
            dgvProductList.AutoGenerateColumns = false;//不可自动创建列
            //生成流水账号
            txtSerialNum.Text = CreateSerialNum();
            //系统围绕商品编号进行增删改 
            //获取商品编号
            //a.采用扫描枪进行扫描
            //b.手动输入进行扫描
            txtProductId.KeyDown += TxtProductId_KeyDown;
            txtProductId.GotFocus += TxtProductId_GotFocus;
            txtProductId.LostFocus += TxtProductId_LostFocus;
            txtDiscount.GotFocus += TxtProductId_GotFocus;
            txtQuantity.GotFocus += TxtProductId_GotFocus;
            txtUnitPrice.GotFocus += TxtProductId_GotFocus;
            txtDiscount.LostFocus += TxtProductId_LostFocus;
            txtQuantity.LostFocus += TxtProductId_LostFocus;
            txtUnitPrice.LostFocus += TxtProductId_LostFocus;
        }


        #region 文本框设计
        private void TxtProductId_LostFocus(object sender, EventArgs e)
        {
            SuperText text = sender as SuperText;
            text.BackColor = Color.White;
        }
        private void TxtProductId_GotFocus(object sender, EventArgs e)
        {
            SuperText text = sender as SuperText;
            text.BackColor = Color.Cyan;
            text.SelectAll();
        }
        #endregion

        #region 支付完成重置界面
        void RestForm()
        {
            txtSerialNum.Text = CreateSerialNum();
            dgvProductList.DataSource = null;
            productList.Clear();
            txtPay.Text = "0.00";
            txtProductId.Focus();
        }
        #endregion

        #region 添加商品到购物车列表
        private void AddNewProductToList()
        {
            //【1.】根据商品编号查询商品
            Produts objProduct = productManager.GetProductWithId(txtProductId.Text.Trim());
            //【2.】未查到对应的商品
            if (objProduct == null)
            {
                //证明该商品是临时商品，或未来得及录入商品
                objProduct = new Produts()
                {
                    ProductName = "暂未提供商品名称",
                    ProductId = txtProductId.Text.Trim(),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim()),
                    Discount = Convert.ToInt32(txtDiscount.Text.Trim())
                };
            }
            //【3.】查询到对应的商品
            else
            {
                txtUnitPrice.Text = objProduct.UnitPrice.ToString();
                txtDiscount.Text = objProduct.Discount.ToString();
            }
            //【4.】根据商品的数量折扣计算小计金额
            objProduct.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());
            objProduct.SubTotal = objProduct.Quantity * objProduct.UnitPrice;
            //【5.】检查这个商品是否计算折扣价
            if (objProduct.Discount != 0)
            {
                objProduct.SubTotal *= (Convert.ToDecimal(objProduct.Discount) / 10);
            }
            //【6.】商品列表序号问题
            objProduct.ProductNo = productList.Count + 1;
            productList.Add(objProduct);
            //【7.】添加商品之后应该立刻让最新添加的商品作为选中项
            bs.MoveLast();
            //【8.】商品添加到购物车清除商品编号内容以便输入下一件商品编号
            txtProductId.Text = "";
        }
        #endregion

        #region 结算
        private void Balance()
        {
            //显示结算窗口，考虑支付被取消或修改
            FrmBalance frm = new FrmBalance(txtPay.Text);
            if (frm.ShowDialog() != DialogResult.OK)
            {
                if (frm.Tag.ToString() == "Esc")//客户放弃购买(忘记带钱等)
                {
                    RestForm();
                }
            }
            else//正式进入结算环节
            {
                SMMembers members = null;
                if (frm.Tag.ToString().Contains("&"))//输入了会员卡号
                {
                    string[] info = frm.Tag.ToString().Split('&');
                    txtAmount.Text = info[0];
                    members = new SMMembers()
                    {
                        MemberId = Convert.ToInt32(info[1]),
                        Points = (int)(Convert.ToDouble(txtPay.Text) / 10.0)
                    };
                }
                else
                {
                    txtAmount.Text = frm.Tag.ToString();
                }
                //找零
                txtChange.Text = (Convert.ToDecimal(txtAmount.Text) - Convert.ToDecimal(txtPay.Text)).ToString();
                //创建消费对象
                SalesList saleObj = new SalesList()
                {
                    SerialNum = txtSerialNum.Text,
                    TotalMoney = Convert.ToDecimal(txtPay.Text.Trim()),
                    RealReceive = Convert.ToDecimal(txtAmount.Text.Trim()),
                    ReturnMoney = Convert.ToDecimal(txtChange.Text.Trim()),
                    SalesPersonId = Program.Sales.SalesPersonId
                };
                //封装消费明细列表
                foreach (Produts item in productList)
                {
                    saleObj.ListDetail.Add(
                        new SalesListDetail()
                        {
                            SerialNum = txtSerialNum.Text,
                            ProductId = item.ProductId,
                            ProductName = item.ProductName,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice,
                            Discount = item.Discount,
                            SubTotalMoney = item.SubTotal
                        }
                    );
                }
                try
                {
                    //保存销售数据
                    productManager.SaveSalerInfo(saleObj, members);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存销售数据的时候发生异常！{ex.Message}", "异常提示");
                    return;
                }
                //小票打印
                printDocument1.Print();
                PrintPriview();
                //重置主界面
                RestForm();
            }
        }
        #endregion

        #region 商品添加
        private void BindProduct()
        {
            //商品编号正确
            txtProductId.Text = txtProductId.Text.Replace("\r\n", "");
            if (txtProductId.CheckData(@"^[1-9]\d*$", "商品编号为10-15纯数字") != 0)
            {
                //检查这个商品是否已经在购物车中存在了，如果已经有了这个商品则直接添加数量，如果没有才往购物车中添加
                var product = from p in productList
                              where p.ProductId.Equals(txtProductId.Text.Trim())
                              select p;
                //【1】在购物车中未找到该商品则进行重新添加
                if (product.Count() == 0)
                {
                    AddNewProductToList();
                }
                // 【2】商品已经存在，则只需要更新数量和小计金额即可
                else
                {
                    Produts pro = product.FirstOrDefault();
                    pro.Quantity += Convert.ToInt32(txtQuantity.Text.Trim());
                    pro.SubTotal = pro.Quantity * pro.UnitPrice;
                    if (pro.Discount != 0)
                    {
                        pro.SubTotal *= (Convert.ToDecimal(pro.Discount) / 10);
                    }
                }
                //【3】整个商品加入购物车完成，刷新界面显示
                bs.DataSource = productList;
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = bs;

                //【4】更新购物车的应付金额数量
                txtPay.Text = (from p in productList select p.SubTotal).Sum().ToString();

                //【5】清空商品的相关信息
                txtProductId.Text = "";
                txtQuantity.Text = "1";
                txtDiscount.Text = "0";
                txtUnitPrice.Text = "0.00";
                txtAmount.Text = "0.00";
                txtChange.Text = "0.00";
                txtProductId.Focus();
            }
            else
            {
                MessageBox.Show("商品编号为10-15纯数字", "操作");
            }
        }
        #endregion

        #region 系统核心操作模块
        //【二、当系统读取到条形码开始将商品加入购物车】
        //1.如果购物车中没有该商品，在购物车中新建一栏加入
        //2.如果购物车中该商品已经存在了，直接改变购物车中该商品的数量
        private void TxtProductId_KeyDown(object sender, KeyEventArgs e)
        {
            //在键盘按下事件中，必须要判断按下的功能键是什么
            //【1】按下回车进行商品编号的录入，进入商品添加功能
            if (e.KeyCode == Keys.Enter)
            {
                BindProduct();
            }
            //【2】按上移动
            else if (e.KeyCode == Keys.Up)
            {
                if (dgvProductList.RowCount == 0 || dgvProductList.RowCount == 1)
                {
                    return;
                }
                bs.MovePrevious();
            }
            //【3】按下移动
            else if (e.KeyCode == Keys.Down)
            {
                if (dgvProductList.RowCount == 0 || dgvProductList.RowCount == 1)
                {
                    return;
                }
                bs.MoveNext();
            }
            //【4】按下Del键移除
            else if (e.KeyCode == Keys.Delete)
            {
                if (dgvProductList.RowCount == 0)
                {
                    return;
                }
                bs.RemoveCurrent();
                //问题：1.数据表要刷新
                //问题：2.更新序号
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = bs;
            }
            //【5】按下的是F1键开始结算
            else if (e.KeyCode == Keys.F1)
            {
                if (dgvProductList.RowCount == 0)
                {
                    return;
                }
                else
                {
                    Balance();
                }
            }
            //【6】按下的是退出系统按键
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("是否确认关闭系统", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        #endregion

        #region 生成流水账号
        private string CreateSerialNum()
        {
            string serialNum = saleManager.GetSysTime().ToString("yyyyMMddHHmmssms");
            Random random = new Random();
            serialNum += random.Next(10, 100).ToString();
            return serialNum;
        }
        #endregion

        #region 主程序关闭时间记录
        /// <summary>
        /// 主程序关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saleManager.WriteSalesExitLog(Program.Sales.LogId);
        }
        #endregion

        #region 更新系统时间
        /// <summary>
        /// 日期时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            toollblTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
        #endregion

        #region  移除一行更新序号，更新总金额
        private void dgvProductList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            decimal money = (from p in productList select p.SubTotal).Sum();
            txtPay.Text = money == 0 ? "0.00" : money.ToString();
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i].ProductNo = i + 1;
            }
        }
        #endregion

        //小票打印事件
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            USBPrint.Print(e, productList, txtSerialNum.Text.Trim(), toollblName.Text.Trim());
        }


        #region 小票打印预览
        public void PrintPriview()
        {
            try
            {
                var printPriview = new PrintPreviewDialog
                {
                    Document=printDocument1,
                    WindowState=FormWindowState.Maximized
                };
            }
            catch (Exception ex)
            {            
                MessageBox.Show("打印错误，请检查打印设置！");
                throw ex;
            }
        }
        #endregion
    }
}
