package com.parttern.decorator;

public class Main {

    public static void main(String[] args) {

        MilkTea chocolate = new ChocolateMilkTea();
        chocolate = new Flan(chocolate);
        chocolate = new Jelly(chocolate);

        System.out.println(chocolate.doMilkTea() + ":\t" + chocolate.cost() + "$");

        MilkTea matcha = new Flan(new Flan (new Jelly(new BlackSugarBubble(new MatchaMilkTea()))));

        System.out.println(matcha.doMilkTea() + ":\t" + matcha.cost() + "$");


    }
}
