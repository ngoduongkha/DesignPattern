using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    internal class SeparatorExpression : AbstractExpression {
        public void Evaluate(Context context) {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}
