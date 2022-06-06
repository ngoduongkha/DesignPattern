package com.parttern.decorator;

public class MatchaMilkTea extends MilkTea{
    private double price = 1;

    @Override
    public String doMilkTea() {
        return "Trà sữa Matcha";
    }

    @Override
    public double cost() {
        return this.price;
    }
}
