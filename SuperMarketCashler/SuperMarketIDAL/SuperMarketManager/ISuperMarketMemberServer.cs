using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;


namespace SuperMarketIDAL.SuperMarketManager
{
    public interface ISuperMarketMemberServer
    {
        /// <summary>
        /// 返回会员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SMMembers GetMMemberByIdOrPhone(string id);
        /// <summary>
        /// 添加会员
        /// </summary>
        /// <param name="members"></param>
        /// <returns></returns>
        SMMembers AddMember(SMMembers members);
    }
}
