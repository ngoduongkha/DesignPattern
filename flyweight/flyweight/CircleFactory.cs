using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public class CircleFactory
    {
        private static Dictionary<string, IShape> circles = new Dictionary<string, IShape>();
        public static IShape getCircle(string color)
        {
            IShape shape = null;
            if (circles.TryGetValue(color, out shape))
            {
                return shape;
            }
            else
            {
                shape = new Circle(color);
                circles.Add(color, shape);
            }
            return shape;
        }
    }
}
