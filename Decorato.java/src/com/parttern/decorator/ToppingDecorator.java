package com.parttern.decorator;

public abstract class ToppingDecorator extends MilkTea{
    protected MilkTea milkTea;

    public ToppingDecorator(MilkTea innerMilkTea){
        this.milkTea = innerMilkTea;
    }
    @Override
    public abstract String doMilkTea();


}
