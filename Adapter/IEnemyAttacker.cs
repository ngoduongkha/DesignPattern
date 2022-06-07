using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    internal interface IEnemyAttacker {
        public void ShootBullet();
        public void DriveForward();
        public void AssignDriver(string driverName);
    }
}
