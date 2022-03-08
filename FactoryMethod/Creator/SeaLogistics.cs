using FactoryMethod.Product;
using System;

namespace FactoryMethod.Creator {
    class SeaLogistics : Logistics {
        public override ITransport CreateTransport() {
            int choice;

            Console.WriteLine();
            Console.WriteLine("1. Ship \t 2. Ferry");
            Console.WriteLine("======= \t ========");
            Console.WriteLine("What type of transportation do you want?");
            Console.Write("Input your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    return new Ship();
                case 2:
                    return new Ferry();
                default:
                    Console.WriteLine("Your choice is not valid!\n");
                    return null;
            }
        }

        public override string ToString() { return "Sea Logistics"; }
    }
}
