using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIDAL.SuperMarketManager
{
    public interface ISuperMarketAdminServer
    {
        /// <summary>
        /// 管理员实体类返回
        /// </summary>
        /// <param name="admins"></param>
        /// <returns></returns>
        SysAdmins AdminLogin(SysAdmins admins);
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="admins"></param>
        /// <returns></returns>
        int AdminUpdatePwd(SysAdmins admins);

        /// <summary>
        /// 返回管理员表
        /// </summary>
        /// <returns></returns>
        List<SysAdmins> GetAdmins();

        /// <summary>
        /// 管理员信息状态
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        int SetSysStatus(SysAdmins admin);
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="admi"></param>
        /// <returns></returns>
        SysAdmins InsertAdmin(SysAdmins admi);
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        int UpdateAdmin(SysAdmins admin);

        /// <summary>
        /// 返回营业员表
        /// </summary>
        /// <returns></returns>
        List<SalesPerson> GetSales();
        /// <summary>
        /// 添加营业员
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        SalesPerson InsertSales(SalesPerson person);
        /// <summary>
        /// 修改营业员
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        int UpdateSales(SalesPerson person);
    }
}
