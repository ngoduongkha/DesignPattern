using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    internal class DracularMonster : Monster
    {
        public void hitBy(Warrior warrior)
        {
            Console.WriteLine("Warrior hit DracularMonster 10hp");

        }
        public void hitBy(Wizard wizard)
        {
            Console.WriteLine("Wizard hit DracularMonster 80hp");
        }
    }
}
