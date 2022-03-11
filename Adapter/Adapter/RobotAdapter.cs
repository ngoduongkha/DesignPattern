using Adapter.Product;

namespace Adapter.Adapter {
    internal class RobotAdapter : IAttacker {
        private readonly Robot robot;

        public RobotAdapter(Robot robot) {
            this.robot = robot;
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
