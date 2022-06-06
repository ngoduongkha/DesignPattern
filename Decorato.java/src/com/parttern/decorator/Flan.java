package com.parttern.decorator;

public class Flan extends ToppingDecorator{
    private double price = 0.5;
    public Flan(MilkTea innerMilkTea) {
        super(innerMilkTea);
    }

    @Override
    public double cost() {
        return this.price + milkTea.cost();
    }

    @Override
    public String doMilkTea() {
        String type = milkTea.doMilkTea();
        return type + addFlan();
    }

    private String addFlan() {
        return " ,Bánh Flan";
    }
}
