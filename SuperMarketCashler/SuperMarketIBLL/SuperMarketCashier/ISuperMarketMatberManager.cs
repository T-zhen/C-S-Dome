using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIBLL.SuperMarketCashier
{
    public interface ISuperMarketMemberManager
    {
        /// <summary>
        /// 通过会员id查询信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SMMembers GetMembersById(string id);
    }
}
