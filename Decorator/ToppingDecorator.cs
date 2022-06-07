namespace Decorator {
    internal abstract class ToppingDecorator : MilkTea {
        protected MilkTea milkTea;

        public ToppingDecorator(MilkTea milkTea) {
            this.milkTea = milkTea;
        }
    }
}
