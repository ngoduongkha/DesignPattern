using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class Filee
    {
        State m_state;
        public void changeState(State m_state)
        {
            this.m_state = m_state;
        }
        public Filee() {
            m_state = new CloseState(this);
        }
        public void Open()
        {
            m_state.open();
        }
        public void Delete()
        {
            m_state.delete();
        }
        public void Close()
        {
            m_state.close();
        }
        public string getState()
        {
            return(m_state.getState());
        }
    }
}
