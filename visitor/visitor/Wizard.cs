using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    internal class Wizard : Human
    {
        public void hit(Monster monster)
        {
            monster.hitBy(this);
        }
    }
}
