using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    internal interface IComponent
    {
        int totalPrice();
        void displayPrice();
    }
}
