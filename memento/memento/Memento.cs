using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class Memento
    {
        string state;
        public Memento(string state)
        {
            this.state = state;
        }
        public string getState()
        {
            return state;
        }
    }
}
