using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator {
    internal class MatchaMilkTea : MilkTea {
        private readonly double price = 1;

        public override string DoMilkTea() {
            return "Trà sữa Matcha";
        }

        public override double Cost() {
            return price;
        }
    }
}
