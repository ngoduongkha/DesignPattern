using FactoryMethod.Product;
using System;

namespace FactoryMethod.Creator {
    class RoadLogistics : Logistics {
        public override ITransport FactoryMethod() {
            int choice;

            Console.WriteLine();
            Console.WriteLine("1. Truck \t 2. Car");
            Console.WriteLine("======== \t ======");
            Console.WriteLine("What type of logistics do you want?");
            Console.Write("Input your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    return new Truck();
                case 2:
                    return new Car();
                default:
                    Console.WriteLine("Your choice is not valid!\n");
                    return null;
            }
        }

        public override string ToString() { return "Road Logistics"; }
    }

}
