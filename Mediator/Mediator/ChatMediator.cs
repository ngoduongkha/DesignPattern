using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ChatMediator : IChatMediator
    {
        private List<User> usersList = new List<User>();
      
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
