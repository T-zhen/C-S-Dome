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
    public partial class FrmUpdatePwd : Form
    {
        public FrmUpdatePwd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        ISuperMarkeAdminManager manager = new SuperMarketAdminManager();

        //确认修改密码
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.CheckNullOrEmpty()*txtNewPwd.CheckNullOrEmpty()*txtRePwd.CheckNullOrEmpty()!=0)
            {
                if (txtOldPwd.Text.Trim().Equals(Program.CurrentAdmin.LoginPwd))
                {
                    txtOldPwd.SetError(string.Empty);
                    //重复密码与心密码一致则可修改
                    if (txtNewPwd.Text.Trim().Equals(txtRePwd.Text.Trim()))
                    {
                        Program.CurrentAdmin.LoginPwd = txtNewPwd.Text.Trim();
                        if (manager.AdminUpdatePwd(Program.CurrentAdmin))
                        {
                            MessageBox.Show("密码修改成功！请重新登录","提示！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("密码修改失败！请稍后重试","提示！");
                        }
                    }
                    else
                    {
                        txtRePwd.SetError("重复密码与新密码不一致！");
                    }
                }
                else
                {
                    txtOldPwd.SetError("原密码错误！");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
