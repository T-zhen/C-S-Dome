using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketIDAL.SuperMarketManager;
using SuperMarketDAL.SuperMarketManager;

namespace SuperMarketBLL.SuperMarketManager
{
    public class SuperMarketMemberManager : ISuperMarketMemberManager
    {
        ISuperMarketMemberServer memberServer = new SuperMarketMemberServer();
        public SMMembers AddMember(SMMembers members)
        {
            return memberServer.AddMember(members);
        }

        public SMMembers GetMMemberByIdOrPhone(string id)
        {
            return memberServer.GetMMemberByIdOrPhone(id);
        }
    }
}
