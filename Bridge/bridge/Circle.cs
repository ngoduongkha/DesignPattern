using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }
        public override void drawAndColor()
        {
            Console.WriteLine("Hinh tron co "+ color.setColor());
        }
    }
}
