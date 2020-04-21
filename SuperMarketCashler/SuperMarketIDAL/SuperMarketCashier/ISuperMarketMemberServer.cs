using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIDAL.SuperMarketCashier
{
    public interface ISuperMarketMemberServer
    {
        /// <summary>
        /// 通过ID查询会员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SMMembers GetMembersById(string id);
    }
}
