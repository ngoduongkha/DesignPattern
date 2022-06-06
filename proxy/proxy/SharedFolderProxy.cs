using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class SharedFolderProxy : ISharedFolder
    {
        string role;
        ISharedFolder folder;
        public SharedFolderProxy(string role)
        {
            this.role = role;
        }
        public void share()
        {
            if (role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                folder.share();
            }
            else
            {
                Console.WriteLine("You don't have permission to share folder");
            }
        }
    }
}
