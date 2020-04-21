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
using SuperMarketBLL;
using SuperMarketIBLL;
using System.Net;

namespace SuperMarketCashler
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Log4net日志记录
        /// </summary>
        Utility.LogHelper logHelper = new Utility.LogHelper();
        /// <summary>
        /// BLL层实例化
        /// </summary>
        SuperMarketIBLL.SuperMarketCashier.ISuperMarketSaleManager manager = new SuperMarketBLL.SuperMarketCashier.SuperMarketSaleManager();
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoScaleMode = AutoScaleMode.None;
            
        }
        //登录
        private void btnLog_Click(object sender, EventArgs e)
        {
            //登录文本验证如果等于零则有未填项
            if (txtLogid.CheckData(@"^[1-9]\d*$","账号格式为纯数字！")*txtLogpwd.CheckNullOrEmpty()==1)
            {
                //登录账号和密码封装
                SalesPerson person = new SalesPerson()
                {
                    SalesPersonId = int.Parse(txtLogid.Text),
                    LoginPwd = txtLogpwd.Text.Trim()
                };
                //实例化一个管理员的类来记录登录的信息
                SalesPerson res = manager.SalesLogin(person);
                //如果不为空则登录成功
                if (res!=null)
                {
                    //同时记录在全局中
                    Program.Sales = res;
                    //写入系统日志之中
                    try
                    {
                        int logId = manager.WriteSalesLog(new LoginLogs()
                        {
                            LoginId = res.SalesPersonId,
                            ServerName = Dns.GetHostName(),
                            SPName = res.SPName

                        });                 
                        Program.Sales.LogId = logId;
                        logHelper.WriteInfo(string.Format("管理员登录ID{0},登录服务器名称{1}，登陆者姓名{2}", res.LogId, Dns.GetHostName(), res.SPName));
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        logHelper.WriteError(ex.Message);
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("信息有误请重新登录！","登录提示！");
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
   
}
