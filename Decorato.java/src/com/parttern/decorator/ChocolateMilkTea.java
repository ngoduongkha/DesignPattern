package com.parttern.decorator;

public class ChocolateMilkTea extends  MilkTea{
    private double price = 1.5;

    @Override
    public String doMilkTea() {
        return "Trà sữa Socola";
    }

    @Override
    public double cost() {
        return this.price;
    }
}
