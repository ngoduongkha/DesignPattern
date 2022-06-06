namespace Adapter.Product {
    internal interface IAttacker {
        public void ShootBullet();
        public void DriveForward();
        public void AssignDriver(string driverName);
    }
}
