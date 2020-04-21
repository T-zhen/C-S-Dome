using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;


namespace SuperMarketIBLL.SuperMarketManager
{
    public interface ISuperMarkeAdminManager
    {
        SysAdmins AdminLogin(SysAdmins admins);
        bool AdminUpdatePwd(SysAdmins admins);

        List<SysAdmins> GetAdmins();
        bool SetSysStatus(SysAdmins admin);
        SysAdmins InsertAdmin(SysAdmins admin);
        SysAdmins UpdateAdmin(SysAdmins admin);
        List<SalesPerson> GetSales();
        SalesPerson InsertSales(SalesPerson person);
        SalesPerson UpdateSales(SalesPerson person);
    }
}
