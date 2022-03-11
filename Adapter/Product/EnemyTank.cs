using System;

namespace Adapter.Product {
    internal class EnemyTank : IEnemyAttacker {
        Random random = new Random();

        public void ShootBullet() {
            int attackDamage = random.Next(5) + 1;
            Console.WriteLine("Enemy Tank does " + attackDamage + " damages");
        }

        public void DriveForward() {
            int movement = random.Next(10) + 1;
            Console.WriteLine("Enemy Tank moves " + movement + " spaces");
        }

        public void AssignDriver(String driverName) {
            Console.WriteLine(driverName + " is driving the Tank");
        }
    }
}
