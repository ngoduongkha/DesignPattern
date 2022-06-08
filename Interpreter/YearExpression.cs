namespace Interpreter {
    internal class YearExpression : AbstractExpression {
        public void Evaluate(Context context) {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
