package com.parttern.decorator;

public class BlackSugarBubble extends ToppingDecorator {
    private double price = 0.2;

    public BlackSugarBubble(MilkTea innerMilkTea) {
        super(innerMilkTea);
    }

    @Override
    public double cost() {
        return this.price + milkTea.cost();
    }

    @Override
    public String doMilkTea() {
        String type = milkTea.doMilkTea();
        return type + addBlackSugarBubble();
    }

    private String addBlackSugarBubble() {
        return " ,Trân châu đường đen";
    }
}
