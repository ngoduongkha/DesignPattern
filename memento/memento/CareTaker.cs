using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    internal class CareTaker
    {
        private List<Memento> stateList= new List<Memento>();
        public void AddMemento(Memento m)
        {
            stateList.Add(m);
        }
        public Memento GetMemento(int index)
        {
            return stateList[index];
        }
    }
}
