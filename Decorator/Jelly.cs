using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator {
    internal class Jelly : ToppingDecorator {
        private readonly double price = 0.1;

        public Jelly(MilkTea milkTea) : base(milkTea) {
        }

        public override double Cost() {
            return price + milkTea.Cost();
        }

        public override string DoMilkTea() {
            return milkTea.DoMilkTea() + AddJelly();
        }

        private string AddJelly() {
            return ", Thạch rau câu";
        }
    }
}
