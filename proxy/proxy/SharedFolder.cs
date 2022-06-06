using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class SharedFolder : ISharedFolder
    {
        public void share()
        {
            Console.WriteLine("Folder da duoc share");
        }
    }
}
