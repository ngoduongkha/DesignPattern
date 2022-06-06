using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal interface IChatMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
