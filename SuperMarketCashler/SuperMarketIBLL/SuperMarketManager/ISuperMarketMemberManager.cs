using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIBLL.SuperMarketManager
{
    public interface ISuperMarketMemberManager
    {
        SMMembers GetMMemberByIdOrPhone(string id);
        SMMembers AddMember(SMMembers members);
    }
}
