using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    internal class EnemyRobotAdapter : IEnemyAttacker {
        private readonly EnemyRobot robot;

        public EnemyRobotAdapter(EnemyRobot robot) {
            this.robot = robot;
        }

        public void AssignDriver(string driverName) {
            robot.ReactToHuman(driverName);
        }

        public void DriveForward() {
            robot.WalkForward();
        }

        public void ShootBullet() {
            robot.SlashWithSword();
        }
    }
}
