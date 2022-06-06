using System;

namespace Adapter.Product {
    internal class Robot {
        private readonly Random random = new();

        public void SlashWithSword() {
            int damage = random.Next(10) + 1;
            Console.WriteLine($"Robot slashes { damage } damage with the sword");
        }

        public void WalkForward() {
            int movement = random.Next(5) + 1;
            Console.WriteLine($"Robot walks forward { movement } unit");
        }

        public void ReactToHuman(string driverName) {
            Console.WriteLine($"{ driverName } is controlling the robot");
        }
    }
}
