using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class OpenState : State
    {
        Filee f;
        public OpenState(Filee f)
        {
            this.f = f;
        }
        public void close()
        {
            f.changeState(new CloseState(f));
            Console.WriteLine("File is on Closed State now");
        }

        public void delete()
        {
            Console.WriteLine("You can not delete file because file is on " + f.ToString());
        }

        public void open()
        {
            Console.WriteLine("File already opened");
        }
        public string getState()
        {
            return ("Open State");
        }
    }
}
