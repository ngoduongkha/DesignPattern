using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal abstract class Stock
    {
        private string name;
        private double price;
        public Stock(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        private List<IInvestor> investors = new List<IInvestor>();

        public double Price { 
            get => price; 
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }

        public string Name { get => name; set => name = value; }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }
        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }
        public void Notify()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(this);
            }
            Console.WriteLine("");
        }
    }
}
