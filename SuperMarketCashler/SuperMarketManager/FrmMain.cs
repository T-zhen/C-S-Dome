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
using SuperMarketBLL.SuperMarketCashier;
using SuperMarketIBLL.SuperMarketCashier;
using SuperMarketCommon;

namespace SuperMarketManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.FormClosing += FrmMain_FormClosing;
            this.FormClosed += FrmMain_FormClosed;
            toollblUser.Text = $"【{Program.CurrentAdmin.AdminName}】";//绑定数据
            this.IsMdiContainer = true;
        }
        LogHelpers logHelpers = new LogHelpers();


        Form currentMDIChild = null;




        #region  修改密码
        //修改密码
        private void toolMenuUpdatePwd_Click(object sender, EventArgs e)
        {
            FrmUpdatePwd updatePwd = new FrmUpdatePwd();
            DialogResult resulty = updatePwd.ShowDialog();
            //密码修改成功则重新登录
            if (resulty==DialogResult.OK)
            {
                logHelpers.WriteInfo($"[{Program.CurrentAdmin.LoginId}]修改密码成功");
                this.Close();
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath, "restart");
        }
        #endregion
        void ShowMDIChild(Form mdiForm)
        {
            if (currentMDIChild!=null)
            {
                currentMDIChild.Close();
            }
            currentMDIChild = mdiForm;
            mdiForm.MdiParent = this;
            mdiForm.Parent = panel1;//窗体展示
            mdiForm.Left = panel1.Width/2-mdiForm.Width/2;
            mdiForm.Top = panel1.Height/2-mdiForm.Height/2;
            mdiForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            mdiForm.Show();
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuUserManager_Click(object sender, EventArgs e)
        {
            AdminFrm.FrmAdmin frmAdmin = new AdminFrm.FrmAdmin();
            ShowMDIChild(frmAdmin);
        }
        #region 主程序退出
        private void toolMenuExitSys_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ISuperMarketSaleManager saleManager = new SuperMarketSaleManager();
            logHelpers.WriteInfo($"[{Program.CurrentAdmin.LoginId}]退出程序！");
            saleManager.WriteSalesExitLog(Program.CurrentAdmin.LoginLogId);
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            toollblTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void btnIntoProduct_Click(object sender, EventArgs e)
        {
            FrmIntoProduct intoProduct = new FrmIntoProduct();
            if (currentProduct != null)
            {
                intoProduct.txtProductId.Text = currentProduct.ProductId;
                intoProduct.txtProductName.Text = currentProduct.ProductName;
            }
            ShowMDIChild(intoProduct);
            currentProduct = null;
        }
        //添加商品
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct addProduct = new FrmAddProduct();
            addProduct.FormClosed += AddProduct_FormClosed;
            ShowMDIChild(addProduct);
        }

        //商品入库   实例化一个商品信息
        Produts currentProduct = null;
        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAddProduct frmadd = sender as FrmAddProduct;
            if (frmadd.DialogResult==DialogResult.OK)
            {
                currentProduct = frmadd.Tag as Produts;
                frmadd.DialogResult = DialogResult.Cancel;
                btnIntoProduct_Click(frmadd, null);
                
            }
        }

        #region  添加会员
        //添加会员
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmAddMember frmAddMember = new FrmAddMember();
            ShowMDIChild(frmAddMember);
        }
        #endregion


        #region  登录日志
        private void btnCheckLog_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
