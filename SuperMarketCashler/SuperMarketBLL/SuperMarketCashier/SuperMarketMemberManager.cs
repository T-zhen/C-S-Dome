using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketCashier;
using SuperMarketIDAL.SuperMarketCashier;
using SuperMarketDAL.SuperMarketCashier;

namespace SuperMarketBLL.SuperMarketCashier
{
    public class SuperMarketMemberManager : ISuperMarketMemberManager
    {
        ISuperMarketMemberServer server = new SuperMarketMemberServer();
        /// <summary>
        /// 通过会员ID 查询信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SMMembers GetMembersById(string id)
        {
            return server.GetMembersById(id);
        }
    }
}
