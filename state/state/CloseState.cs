using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class CloseState : State
    {
        Filee f;
        public CloseState(Filee f)
        {
            this.f = f;
        }
        public void close()
        {
            Console.WriteLine("File is already closed");
        }

        public void delete()
        {
            Console.WriteLine("File Deleted");
            f.changeState(new DeleteSate(f));
        }

        public void open()
        {
            Console.WriteLine("Open File");
            f.changeState(new OpenState(f));
        }
        public string getState()
        {
            return ("Close State");
        }
    }
}
