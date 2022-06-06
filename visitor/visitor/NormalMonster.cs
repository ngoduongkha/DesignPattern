using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    internal class NormalMonster : Monster
    {
        public void hitBy(Warrior warrior)
        {
            Console.WriteLine("Warrior hit NormalMonster 50hp");
        }

        public void hitBy(Wizard wizard)
        {
            Console.WriteLine("Wizard hit NormalMonster 10hp");
        }
    }
}
