using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public abstract class Shape
    {
        protected IColor color;
        public Shape(IColor color)
        {
            this.color = color;
        }
        public abstract void drawAndColor(); 
    }
}
