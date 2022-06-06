package com.parttern.decorator;

public class Jelly extends ToppingDecorator {
    private double price = 0.1;

    public Jelly(MilkTea innerMilkTea) {
        super(innerMilkTea);
    }

    @Override
    public double cost() {
        return this.price + milkTea.cost();
    }

    @Override
    public String doMilkTea() {
        String type = milkTea.doMilkTea();
        return type + addJelly();
    }

    private String addJelly (){
        return " ,Thạch rau câu";
    }
}
