using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;
using SuperMarketIDAL.SuperMarketManager;
using System.Data.SqlClient;

namespace SuperMarketDAL.SuperMarketManager
{
    public class SuperMarketAdminServer : ISuperMarketAdminServer
    {
        public SysAdmins AdminLogin(SysAdmins admins)
        {
            string procName = "SysAdminLogin";//存储过程
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@logId",admins.LoginId),
                new SqlParameter("@logPwd",admins.LoginPwd)
            };
            SqlDataReader reader = SQLHelper.GetDataReader(procName, sp);
            SysAdmins admin = null;
            while (reader.Read())
            {
                admins = new SysAdmins()
                {
                    AdminName = reader["AdminName"].ToString(),
                    LoginId= (int)reader["LoginId"],
                    LoginPwd=reader["LoginPws"].ToString(),
                    RoleId=(int)reader["RoleId"],
                    AdminStatus=Convert.ToInt32(reader["AdminStatus"])
                };
            }
            reader.Close();
            return admin;
        }

        public int AdminUpdatePwd(SysAdmins admins)
        {
            string procName = "UpdateSysPwd";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@logId",admins.LoginId),
                new SqlParameter("@logPwd",admins.LoginPwd)
            };
            return SQLHelper.ExecuteNonQuery(procName,sp);
        }




        public List<SysAdmins> GetAdmins()
        {
            string procName = "GetAllTables";
            SqlParameter[] sp =
            {
                new SqlParameter("@tableName","SysAdmins")
            };
            SqlDataReader reader = SQLHelper.GetDataReader(procName, sp);
            List<SysAdmins> list = new List<SysAdmins>();
            while (reader.Read())
            {
                SysAdmins admins = new SysAdmins();
                admins.AdminName = reader["AdminName"].ToString();
                admins.LoginId = Convert.ToInt32(reader["LoginId"]);
                admins.LoginPwd = reader["LoginPwd"].ToString();
                admins.RoleId = Convert.ToInt32(reader["RoleId"]);
                admins.AdminStatus = Convert.ToInt32(reader["AdminStatus"]);
                admins.StatusName = admins.AdminStatus == 1 ? "启用" : "禁用";
                admins.RoleName = admins.RoleId == 1 ? "超级管理员" : "一般管理员";
                list.Add(admins);
            }
            reader.Close();
            return list;
        }

        public List<SalesPerson> GetSales()
        {
            string procName = "GetAllTables";
            SqlParameter[] sp =
            {
                new SqlParameter("@tableName","SalesPerson")
            };
            SqlDataReader reader = SQLHelper.GetDataReader(procName, sp);
            List<SalesPerson> list = new List<SalesPerson>();
            while (reader.Read())
            {
                SalesPerson admins = new SalesPerson();
                admins.SalesPersonId = Convert.ToInt32(reader["SalesPersonId"]);
                admins.LoginPwd = reader["LoginPwd"].ToString();
                admins.SPName = reader["SPName"].ToString();
                list.Add(admins);
            }
            reader.Close();
            return list;
        }

        public SysAdmins InsertAdmin(SysAdmins admin)
        {
            string procName = "InsertAdmin";
            SqlParameter[] sp =
            {
                new SqlParameter("@adminName",admin.AdminName),
                new SqlParameter("@loginPwd",admin.LoginPwd),
                new SqlParameter("@roleId",admin .RoleId)
            };
            object res = SQLHelper.ExecuteScalar(procName, sp);
            if (res != null)
            {
                admin.LoginId = Convert.ToInt32(res);
            }
            else
            {
                admin = null;
            }
            return admin;
        }

        public SalesPerson InsertSales(SalesPerson person)
        {
            string procName = "InsertSales";
            SqlParameter[] sp ={
                new SqlParameter("@spName",person.SPName),
                new SqlParameter("@loginPwd",person.LoginPwd)
            };
            object res = SQLHelper.ExecuteScalar(procName, sp);
            if (res != null)
            {
                person.SalesPersonId = Convert.ToInt32(res);
            }
            else
            {
                person = null;
            }
            return person;
        }

        public int SetSysStatus(SysAdmins admin)
        {
            string procName = "SetSysAdmStatus";
            SqlParameter[] sp =
            {
                new SqlParameter("@role",admin.AdminStatus),
                new SqlParameter("@id",admin.LoginId)
            };
            return SQLHelper.ExecuteNonQuery(procName, sp);
        }

        public int UpdateAdmin(SysAdmins admin)
        {
            string procName = "UpdateAdmin";
            SqlParameter[] sp =
            {
                new SqlParameter("@adminName",admin.AdminName),
                new SqlParameter("@loginPwd",admin.LoginPwd),
                new SqlParameter("@roleId",admin.RoleId),
                new SqlParameter("@loginId",admin.LoginId)
            };
            return SQLHelper.ExecuteNonQuery(procName, sp);
        }

        public int UpdateSales(SalesPerson person)
        {
            string procName = "UpdateSaleInfor";
            SqlParameter[] sp =
            {
                new SqlParameter("@saleName",person.SPName),
                new SqlParameter("@loginPwd",person.LoginPwd),
                new SqlParameter("@loginId",person.SalesPersonId)
            };
            return SQLHelper.ExecuteNonQuery(procName, sp);
        }



    }
}
