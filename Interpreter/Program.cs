﻿using Interpreter;

List<AbstractExpression> objExpressions = new List<AbstractExpression>();
Context context = new(DateTime.Now);
Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
context.Expression = Console.ReadLine();
string[] strArray = context.Expression.Split(' ');
foreach (var item in strArray) {
    if (item == "DD") {
        objExpressions.Add(new DayExpression());
    }
    else if (item == "MM") {
        objExpressions.Add(new MonthExpression());
    }
    else if (item == "YYYY") {
        objExpressions.Add(new YearExpression());
    }
}
objExpressions.Add(new SeparatorExpression());
foreach (var obj in objExpressions) {
    obj.Evaluate(context);
}
Console.WriteLine(context.Expression);
