package com.company;

import java.util.Random;

public class EnemyRobot {
    Random random = new Random();

    public void slashWithSword() {
        int attackDamage = random.nextInt(10) + 1;
        System.out.println("Enemy Robot slashes " + attackDamage + " damages with sword");
    }

    public void walkForward(){
        int movement = random.nextInt(5) + 1;
        System.out.println("Enemy Robot walks forward " + movement + " spaces");
    }

    public void reactToHuman(String driverName) {
        System.out.println(driverName + " is controlling the robot");
    }

}
