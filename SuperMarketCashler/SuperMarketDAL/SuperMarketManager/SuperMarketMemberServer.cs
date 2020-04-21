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
    public class SuperMarketMemberServer : ISuperMarketMemberServer
    {
        /// <summary>
        /// 添加会员
        /// </summary>
        /// <param name="members"></param>
        /// <returns></returns>
        public SMMembers AddMember(SMMembers members)
        {
            string procName = "AddMember";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@memberName",members.MemberName),
                new SqlParameter("@phoneNumber",members.PhoneNumber),
                new SqlParameter("@memberAddress",members.MemberAddress)
            };
            object res = SQLHelper.ExecuteScalar(procName, sp);
            if (res!=null)
            {
                members.MemberId = Convert.ToInt32(res);
            }
            else
            {
                members = null;
            }
            return members;
        }
        /// <summary>
        /// 通过ID查询会员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SMMembers GetMMemberByIdOrPhone(string id)
        {
            SuperMarketCashier.SuperMarketMemberServer server = new SuperMarketCashier.SuperMarketMemberServer();
            return server.GetMembersById(id);
        }
    }
}
