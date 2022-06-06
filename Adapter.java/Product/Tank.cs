using System;

namespace Adapter.Product {
    internal class Tank : IAttacker {
        private readonly Random random = new();

        public void ShootBullet() {
            int damage = random.Next(5) + 1;
            Console.WriteLine($"Tank attacks { damage } damages");
        }

        public void DriveForward() {
            int movement = random.Next(10) + 1;
            Console.WriteLine($"Tank moves { movement } units");
        }

        public void AssignDriver(string driverName) {
            Console.WriteLine($"{ driverName } is driving the Tank");
        }
    }
}
