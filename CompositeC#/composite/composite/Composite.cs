using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    internal class Composite : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            this.Name = name;
        }
        public void addComponent(IComponent component)
        {
            components.Add(component);
        }

        public void removeComponent(IComponent component)
        {
            components.Remove(component);
        }
        public int totalPrice()
        {
            int total = 0;
            foreach (var item in components)
            {
                total+=item.totalPrice();
            }
            return total;
        }

        public void displayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                item.displayPrice();
            }
        }
    }
}
