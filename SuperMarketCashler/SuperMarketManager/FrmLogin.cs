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
using SuperMarketCommon;

namespace SuperMarketManager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//运行窗体位置
        }
        //系统日志
        LogHelpers log = new LogHelpers();
        ISuperMarkeAdminManager adminManager = new SuperMarketAdminManager();
        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginId.CheckData(@"^\d+$","账号格式有误！")*txtLoginPwd.CheckNullOrEmpty()!=0)
            {
                SysAdmins sys = new SysAdmins()
                {
                    LoginId = Convert.ToInt32(txtLoginId.Text.Trim()),
                    LoginPwd = txtLoginPwd.Text.Trim()
                };

                try
                {
                    sys = adminManager.AdminLogin(sys);
                    log.WriteInfo($"账号【{sys.LoginId}】尝试登录");
                    if (sys!=null)
                    {
                        //判断账号状态
                        if (sys.AdminStatus==1)
                        {
                            log.WriteInfo($"【{sys.LoginId}】登录成功！");
                            Program.CurrentAdmin = sys;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            log.WriteInfo($"【{sys.LoginId}】账号已被禁用");
                            MessageBox.Show("当前账号已被禁用！","提示！");
                        };
                    }
                    else
                    {
                        log.WriteInfo($"【{sys.LoginId}】账号或者密码错误登录失败");
                    }
                }
                catch (Exception ex)
                {
                    log.WriteError($"【{sys.LoginId}】登录异常",ex);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
