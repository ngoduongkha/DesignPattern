package com.company;
import java.util.Random;

public class EnemyTank implements EnemyAttacker{
    Random random = new Random();

    @Override
    public void shootBullet() {
        int attackDamage = random.nextInt(5) +1 ;
        System.out.println("Enemy Tank does " + attackDamage + " damages");
    }

    @Override
    public void driveForward() {
        int movement = random.nextInt(10) + 1;
        System.out.println("Enemy Tank moves " + movement + " spaces");
    }

    @Override
    public void assignDriver(String driverName) {
        System.out.println(driverName + " is driving the Tank");
    }
}
