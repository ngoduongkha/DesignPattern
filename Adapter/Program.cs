using Adapter;

IEnemyAttacker tank = new EnemyTank();
IEnemyAttacker aircraft = new EnemyAircraft();

Console.WriteLine("The Enemy Aircraft");
aircraft.AssignDriver("William");
aircraft.DriveForward();
aircraft.ShootBullet();
Console.WriteLine("-------------------------");

Console.WriteLine("The Enemy Tank");
tank.AssignDriver("Frank");
tank.DriveForward();
tank.ShootBullet();
Console.WriteLine("-------------------------");

EnemyRobot robot = new();
Console.WriteLine("The Enemy Robot");
robot.ReactToHuman("Paul");
robot.WalkForward();
robot.SlashWithSword();
Console.WriteLine("-------------------------");

IEnemyAttacker robotAdapter = new EnemyRobotAdapter(robot);
Console.WriteLine("The Enemy Robot with Adapter");
robotAdapter.AssignDriver("Paul");
robotAdapter.DriveForward();
robotAdapter.ShootBullet();