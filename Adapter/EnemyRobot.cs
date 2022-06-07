namespace Adapter {
    internal class EnemyRobot {
        private readonly Random random = new();

        public void SlashWithSword() {
            int attackDamage = random.Next(10) + 1;
            Console.WriteLine("Enemy Robot slashes " + attackDamage + " damages with sword");
        }

        public void WalkForward() {
            int movement = random.Next(5) + 1;
            Console.WriteLine("Enemy Robot walks forward " + movement + " spaces");
        }

        public void ReactToHuman(string driverName) {
            Console.WriteLine(driverName + " is controlling the robot");
        }
    }
}
