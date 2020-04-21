using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketBLL.SuperMarketManager;


namespace SuperMarketManager
{
    public partial class FrmIntoProduct : Form
    {
        ISuperMarketProductManager manager = new SuperMarketProductManager();
        public FrmIntoProduct()
        {
            InitializeComponent();
            txtProductId.Focus();
            txtProductId.LostFocus += TxtProductId_LostFocus;//当失去焦点时
        }

        private void TxtProductId_LostFocus(object sender, EventArgs e)
        {
            if (txtProductId.CheckData(@"^\d+$", "商品编号录入有误") == 1)
            {
                Produts produts = manager.GetProductWithId(txtProductId.Text.Trim());
                if (produts == null)
                {
                    MessageBox.Show("商品编号录入有误,未查询到对应商品！", "提示");
                    txtProductId.SelectAll();
                    txtProductId.Focus();
                    return;
                }
                else
                {
                    txtProductName.Text = produts.ProductName;
                }
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtProductId.CheckNullOrEmpty()*txtProductName.CheckNullOrEmpty()!=0)
            {
                if (txtCount.CheckData(@"^(-?[1-9\d*])$","入库库数量")==1)
                {
                    if (manager.InventoryProduct(txtProductId.Text.Trim(),Convert.ToInt32(txtCount.Text.Trim())))
                    {
                        if (MessageBox.Show("商品入库成功！是否继续","提示",MessageBoxButtons.OKCancel)==DialogResult.OK)
                        {
                            txtCount.Text = "0";
                            txtProductId.Text = txtProductId.Text = "";
                        }
                        else
                        {
                            this.Close();
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("商品入库失败！", "提示");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
