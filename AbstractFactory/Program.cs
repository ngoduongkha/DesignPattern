using AbstractFactory.Factory;
using System;

namespace AbstractFactory {
    class Client {
        private IFurnitureFactory _funitureFactory;

        public void ClientCode() {
            int choice;

            Console.WriteLine("1. Art Deco \t 2. Victorian \t 3. Modern");
            Console.WriteLine("=========== \t ============ \t =========");
            Console.WriteLine("What type of furniture do you want?");
            Console.Write("Input your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    _funitureFactory = new ArtDecoFurnitureFactory();
                    break;
                case 2:
                    _funitureFactory = new VictorianFurnitureFactory();
                    break;
                case 3:
                    _funitureFactory = new ModernFurnitureFactory();
                    break;
                default:
                    Console.WriteLine("Your choice is not valid!");
                    return;
            }

            var chairProduct = _funitureFactory.CreateChair();
            var sofaProduct = _funitureFactory.CreateSofa();
            var coffeeTableProduct = _funitureFactory.CreateCoffeeTable();

            Console.WriteLine(chairProduct.HasLegs());
            Console.WriteLine(chairProduct.SitOn());
            Console.WriteLine();
            Console.WriteLine(sofaProduct.HasLegs());
            Console.WriteLine(sofaProduct.SitOn());
            Console.WriteLine();
            Console.WriteLine(coffeeTableProduct.HasLegs());
            Console.WriteLine(coffeeTableProduct.PutOn());
        }
    }
    class Program {
        static void Main(string[] args) {
            Client client = new Client();
            client.ClientCode();
        }
    }
}
