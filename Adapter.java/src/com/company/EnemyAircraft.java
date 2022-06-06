package com.company;

import java.util.Random;

public class EnemyAircraft implements EnemyAttacker{
    Random random = new Random();

    @Override
    public void shootBullet() {
        int attackDamage = random.nextInt(10) +1 ;
        System.out.println("Enemy Aircraft does " + attackDamage + " damages");
    }

    @Override
    public void driveForward() {
        int movement = random.nextInt(15) + 1;
        System.out.println("Enemy Aircraft moves " + movement + " spaces");
    }

    @Override
    public void assignDriver(String driverName) {
        System.out.println(driverName + " is driving the Aircraft");
    }
}
