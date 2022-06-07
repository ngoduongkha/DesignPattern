namespace Decorator {
    internal class Flan : ToppingDecorator {
        private readonly double price = 0.5;
        public Flan(MilkTea milkTea) : base(milkTea) {
        }
        public override double Cost() {
            return price + milkTea.Cost();
        }

        public override string DoMilkTea() {
            return milkTea.DoMilkTea() + AddFlan();
        }

        private string AddFlan() {
            return ", Bánh Flan";
        }
    }
}
