using FactoryMethod.Product;
using System;

namespace FactoryMethod.Creator {
    class AirLogistics : Logistics {
        public override ITransport CreateTransport() {
            int choice;

            Console.WriteLine();
            Console.WriteLine("1. Plane \t 2. Helicopter");
            Console.WriteLine("======== \t =============");
            Console.WriteLine("What type of transportation do you want?");
            Console.Write("Input your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    return new Plane();
                case 2:
                    return new Helicopter();
                default:
                    Console.WriteLine("Your choice is not valid!\n");
                    return null;
            }
        }

        public override string ToString() { return "Air Logistics"; }
    }
}
