using Adapter.Adapter;
using Adapter.Product;
using System;

namespace Adapter {
    internal class Program {
        static void Main() {
            IAttacker tank = new Tank();
            IAttacker aircraft = new Aircraft();

            Console.WriteLine("The  Aircraft");

            aircraft.AssignDriver("William");
            aircraft.DriveForward();
            aircraft.ShootBullet();
            Console.WriteLine("-------------------------");


            Console.WriteLine("The  Tank");

            tank.AssignDriver("Frank");
            tank.DriveForward();
            tank.ShootBullet();
            Console.WriteLine("-------------------------");

            Robot robot = new Robot();
            Console.WriteLine("The  Robot");

            robot.ReactToHuman("Paul");
            robot.WalkForward();
            robot.SlashWithSword();
            Console.WriteLine("-------------------------");

            IAttacker robotAdapter = new RobotAdapter(robot);
            Console.WriteLine("The  Robot with Adapter");

            robotAdapter.AssignDriver("Paul");
            robotAdapter.DriveForward();
            robotAdapter.ShootBullet();
        }
    }
}
