namespace Adapter.Product {
    internal interface IEnemyAttacker {
        public void ShootBullet();
        public void DriveForward();
        public void AssignDriver(string driverName);
    }
}
