using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color)
        {

        }
        public override void drawAndColor()
        {
            Console.WriteLine("Hinh chu nhat co "+ color.setColor());
        }
    }
}
