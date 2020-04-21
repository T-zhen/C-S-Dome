using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketModel;

namespace SuperMarketCashler
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmLogin = new FrmLogin();
            DialogResult result = frmLogin.ShowDialog();
            if (result==DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Environment.Exit(0);
            }
           
        }
        /// <summary>
        /// 全局变量记录登录
        /// </summary>
        public static SalesPerson Sales { get; set; }
    }
}
