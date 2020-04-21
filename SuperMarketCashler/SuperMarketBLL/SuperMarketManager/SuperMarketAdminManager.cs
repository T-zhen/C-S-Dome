using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketDAL.SuperMarketCashier;
using SuperMarketIDAL.SuperMarketManager;
using SuperMarketIDAL.SuperMarketCashier;
using SuperMarketDAL.SuperMarketManager;
using System.Net;

namespace SuperMarketBLL.SuperMarketManager
{
    public class SuperMarketAdminManager:ISuperMarkeAdminManager
    {
        ISuperMarketAdminServer adminServer = new SuperMarketAdminServer();
        ISuperMarketSaleServer saleServer = new SuperMarketSaleServer();

        public SysAdmins AdminLogin(SysAdmins admins)
        {
            //根据用户账号和密码调用查询用户登录
            SysAdmins sys = adminServer.AdminLogin(admins);
            //判断管理员账号状态
            if (sys!=null&&sys.AdminStatus==1)
            {
                //写入日志
                LoginLogs log = new LoginLogs()
                {
                    LoginId = sys.LoginId,
                    SPName = sys.AdminName,
                    ServerName = Dns.GetHostName()
                };
                //保存当前管理员登录ID
                sys.LoginLogId = saleServer.WriteSalesLog(log);
            }
            else
            {
                sys = null;
            }
            return sys;
        }

        public bool AdminUpdatePwd(SysAdmins admins)
        {
            int res = adminServer.AdminUpdatePwd(admins);
            if (res>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SysAdmins> GetAdmins()
        {
            return adminServer.GetAdmins();
        }

        public List<SalesPerson> GetSales()
        {
            return adminServer.GetSales();
        }

        public SysAdmins InsertAdmin(SysAdmins admin)
        {
            return adminServer.InsertAdmin(admin);
        }

        public SalesPerson InsertSales(SalesPerson person)
        {
            return adminServer.InsertSales(person);
        }

        public bool SetSysStatus(SysAdmins admin)
        {
            if (adminServer.SetSysStatus(admin) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SysAdmins UpdateAdmin(SysAdmins admin)
        {
            if (adminServer.UpdateAdmin(admin) > 0)
            {
                return admin;
            }
            else
            {
                return null;
            }
        }

        public SalesPerson UpdateSales(SalesPerson person)
        {
            if (adminServer.UpdateSales(person) > 0)
            {
                return person;
            }
            else
            {
                return null;
            }
        }
    }
}
