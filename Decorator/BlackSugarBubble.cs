namespace Decorator {
    internal class BlackSugarBubble : ToppingDecorator {
        private readonly double price = 0.2;

        public BlackSugarBubble(MilkTea milkTea) : base(milkTea) {
        }

        public override string DoMilkTea() {
            return milkTea.DoMilkTea() + AddBlackSugarBubble();
        }

        private string AddBlackSugarBubble() {
            return ", Trân châu đường đen";
        }

        public override double Cost() {
            return price + milkTea.Cost();
        }
    }
}
