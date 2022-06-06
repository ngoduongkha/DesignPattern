using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    internal interface Monster
    {
        void hitBy(Warrior warrior);
        void hitBy(Wizard wizard);
    }
}
