using System;

namespace Adapter.Product {
    internal class Aircraft : IAttacker {
        private readonly Random random = new();

        public void ShootBullet() {
            int damage = random.Next(10) + 1;
            Console.WriteLine($"Aircraft attacks { damage } damage");
        }

        public void DriveForward() {
            int movement = random.Next(15) + 1;
            Console.WriteLine($"Aircraft moves { movement } units");
        }

        public void AssignDriver(string driverName) {
            Console.WriteLine($"{ driverName } is driving the Aircraft");
        }
    }
}
