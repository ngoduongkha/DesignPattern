using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    internal class EnemyAircraft : IEnemyAttacker {
        private readonly Random random = new();

        public void AssignDriver(string driverName) {
            Console.WriteLine(driverName + " is driving the Aircraft");
        }

        public void DriveForward() {
            int movement = random.Next(15) + 1;
            Console.WriteLine("Enemy Aircraft moves " + movement + " spaces");
        }

        public void ShootBullet() {
            int attackDamage = random.Next(10) + 1;
            Console.WriteLine("Enemy Aircraft does " + attackDamage + " damages");
        }
    }
}
