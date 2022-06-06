package com.company;

public class EnemyRobotAdapter implements  EnemyAttacker{
    EnemyRobot robot;

    public EnemyRobotAdapter(EnemyRobot newRobot) {
        this.robot = newRobot;
    }

    @Override
    public void shootBullet() {
        robot.slashWithSword();
    }

    @Override
    public void driveForward() {
        robot.walkForward();
    }

    @Override
    public void assignDriver(String driverName) {
        robot.reactToHuman(driverName);
    }
}
