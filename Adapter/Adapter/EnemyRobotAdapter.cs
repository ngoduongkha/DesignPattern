using Adapter.Product;

namespace Adapter.Adapter {
    internal class EnemyRobotAdapter : IEnemyAttacker {
        EnemyRobot robot;

        public EnemyRobotAdapter(EnemyRobot newRobot) {
            this.robot = newRobot;
        }

        public void ShootBullet() {
            robot.SlashWithSword();
        }

        public void DriveForward() {
            robot.WalkForward();
        }

        public void AssignDriver(string driverName) {
            robot.ReactToHuman(driverName);
        }
    }
}
