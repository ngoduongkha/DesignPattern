using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    internal class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
         
        public int totalPrice() {
            return this.Price;
        }

        public void displayPrice()
        {
            Console.WriteLine(Name + ' ' + Price);
        }
    }
}
