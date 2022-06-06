using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Investor : IInvestor
    {
        private string name;
        public Investor(string name)
        {
                this.name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", this.name, stock.Name, stock.Price);
        }
    }
}
