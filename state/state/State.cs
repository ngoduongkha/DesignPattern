using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal interface State
    {
        public void open();
        public void close();
        public void delete();
        public string getState();
    }
}
