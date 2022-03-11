using System;

namespace Adapter.Product {
    internal class EnemyRobot {
        Random random = new Random();

        public void SlashWithSword() {
            int attackDamage = random.Next(10) + 1;
            Console.WriteLine("Enemy Robot slashes " + attackDamage + " damages with sword");
        }

        public void WalkForward() {
            int movement = random.Next(5) + 1;
            Console.WriteLine("Enemy Robot walks forward " + movement + " spaces");
        }

        public void ReactToHuman(String driverName) {
            Console.WriteLine(driverName + " is controlling the robot");
        }
    }
}
