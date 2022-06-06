using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public class Circle:IShape
    {
        private string color;
        public Circle(string color)
        {
            this.color = color;
            Console.WriteLine("Circle is created: " + color);
        }

        public void Draw(UnshareConcrete unshare)
        {
            Console.WriteLine(this.color + " Circle" + " (" + unshare.getX().ToString() + "," + unshare.getY().ToString() + ")");
        }
    }
}
