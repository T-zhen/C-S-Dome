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
using SuperMarketBLL.SuperMarketManager;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketCommon;

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmUpdateAdmin : Form
    {
        ISuperMarkeAdminManager adminManager = new SuperMarketAdminManager();
        public SysAdmins CurrentAdmin { get; set; }
        public FrmUpdateAdmin(SysAdmins admins)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = $"修改【{admins.AdminName}】信息";
            lblLogId.Text = admins.LoginId.ToString();
            txtAdmName.Text = admins.AdminName;
            txtAdmPwd.Text = admins.LoginPwd;
            cmbAdminRole.SelectedIndex = admins.RoleId - 1;
            CurrentAdmin = admins;
            txtAdmName.GotFocus += TxtAdmName_GotFocus;
            txtAdmPwd.GotFocus += TxtAdmName_GotFocus;
            txtAdmName.Focus();
        }

       

        private void TxtAdmName_GotFocus(object sender, EventArgs e)
        {
            SuperText text = sender as SuperText;
            text.SelectAll();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtAdmName.CheckNullOrEmpty() * txtAdmPwd.CheckData(@"^\w{6,}$", "密码必须为6位字母、数字、下划线组合") == 0)
            {
                return;
            }
            else
            {
                CurrentAdmin.AdminName = txtAdmName.Text.Trim();
                CurrentAdmin.LoginPwd = txtAdmPwd.Text.Trim();
                CurrentAdmin.RoleId = cmbAdminRole.SelectedIndex + 1;
                CurrentAdmin = adminManager.UpdateAdmin(CurrentAdmin);
                if (CurrentAdmin==null)
                {
                    MessageBox.Show("修改失败！","请稍后重试！！");
                }
                else
                {
                    MessageBox.Show("修改成功！","提示");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
