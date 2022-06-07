using Decorator;

MilkTea chocolate = new ChocolateMilkTea();
chocolate = new Flan(chocolate);
chocolate = new Jelly(chocolate);

Console.WriteLine(chocolate.DoMilkTea() + ":\t" + chocolate.Cost() + "$");

MilkTea matcha = new Flan(new Flan(new Jelly(new BlackSugarBubble(new MatchaMilkTea()))));

Console.WriteLine(matcha.DoMilkTea() + ":\t" + matcha.Cost() + "$");
