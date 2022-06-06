package com.company;
public class Main {

    public static void main(String[] args) {


        EnemyAttacker tank = new EnemyTank();
        EnemyAttacker aircraft = new EnemyAircraft();


        System.out.println("The Enemy Aircraft");

        aircraft.assignDriver("William");
        aircraft.driveForward();
        aircraft.shootBullet();
        System.out.println("-------------------------");


        System.out.println("The Enemy Tank");

        tank.assignDriver("Frank");
        tank.driveForward();
        tank.shootBullet();
        System.out.println("-------------------------");

        EnemyRobot robot = new EnemyRobot();
        System.out.println("The Enemy Robot");

        robot.reactToHuman("Paul");
        robot.walkForward();
        robot.slashWithSword();
        System.out.println("-------------------------");

        EnemyAttacker robotAdapter = new EnemyRobotAdapter(robot);
        System.out.println("The Enemy Robot with Adapter");

        robotAdapter.assignDriver("Paul");
        robotAdapter.driveForward();
        robotAdapter.shootBullet();

    }
}
