using System;

namespace Adapter.Product {
    internal class EnemyAircraft : IEnemyAttacker {
        private readonly Random random = new();

        public void ShootBullet() {
            int attackDamage = random.Next(10) + 1;
            Console.WriteLine("Enemy Aircraft does " + attackDamage + " damages");
        }

        public void DriveForward() {
            int movement = random.Next(15) + 1;
            Console.WriteLine("Enemy Aircraft moves " + movement + " spaces");
        }

        public void AssignDriver(string driverName) {
            Console.WriteLine(driverName + " is driving the Aircraft");
        }
    }
}
