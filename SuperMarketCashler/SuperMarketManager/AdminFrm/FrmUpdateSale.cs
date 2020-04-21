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


namespace SuperMarketManager.AdminFrm
{
    
    public partial class FrmUpdateSale : Form
    {
        ISuperMarkeAdminManager adminManager = new SuperMarketAdminManager();
        public SalesPerson Sales { get; set; }
        public FrmUpdateSale(SalesPerson person)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Sales = person;
            txtAdmName.Text = person.SPName;
            txtAdmPwd.Text = person.LoginPwd;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtAdmName.CheckNullOrEmpty() * txtAdmPwd.CheckData(@"^\w{6,}$", "密码必须为6位字母、数字、下划线组合") != 0)
            {
                Sales.SPName = txtAdmName.Text.Trim();
                Sales.LoginPwd = txtAdmPwd.Text.Trim();
                if (adminManager.UpdateSales(Sales) != null)
                {
                    MessageBox.Show("修改成功！", "提示");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认取消？","提示",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
