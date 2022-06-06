using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    internal class Originator
    {
         string state;
        public void set(string state)
        {
            this.state = state;
        }
        public Memento CreateMemento()
        {
            return new Memento(state);
        }
        public void SetMemento(Memento memento)
        {
            state = memento.getState();
        }
        public void detail()
        {
            Console.WriteLine(state);
        }
    }
}
