using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator {
    internal abstract class MilkTea {
        public virtual string DoMilkTea() {
            return "Không biết làm trà sữa nào";
        }

        public abstract double Cost();
    }
}
