using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class DeleteSate : State
    {
        Filee f;
        public DeleteSate(Filee f)
        {
            this.f = f;
        }
        public void close()
        {
            Console.WriteLine("No file exists to close");
        }

        public void delete()
        {
            if (f.getState()=="Delete State")
            {
                Console.WriteLine("File already deleted");
            }
            else
            {
                f.changeState(new DeleteSate(f));
                Console.WriteLine("File deleted");
            }
        }

        public void open()
        {
            Console.WriteLine("No file exists to open");
        }
        public string getState()
        {
            return ("Delete State");
        }
    }
}
