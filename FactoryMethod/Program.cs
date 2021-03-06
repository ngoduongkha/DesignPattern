using FactoryMethod.Creator;
using System;

namespace FactoryMethod {
    class Client {
        public void Main() {
            Logistics logistics;
            int choice;

            Console.WriteLine("1. Road Logistics \t 2. Sea Logistics \t 3. Rail Logistics \t 4. Air Logistics");
            Console.WriteLine("================= \t ================ \t ================= \t ================");
            Console.WriteLine("What type of logistics do you want?");
            Console.Write("Input your choice: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    logistics = new RoadLogistics();
                    break;
                case 2:
                    logistics = new SeaLogistics();
                    break;
                case 3:
                    logistics = new RailLogistics();
                    break;
                case 4:
                    logistics = new AirLogistics();
                    break;
                default:
                    Console.WriteLine("Your choice is not valid!");
                    return;
            }

            Console.WriteLine($"App: Launched with the { logistics }");
            ClientCode(logistics);
        }

        void ClientCode(Logistics logistics) {
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n");
            Console.WriteLine(logistics.PlanDelivery());
        }
    }

    class Program {
        static void Main() {
            new Client().Main();
        }
    }
}
