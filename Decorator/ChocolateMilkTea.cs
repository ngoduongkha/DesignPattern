namespace Decorator {
    internal class ChocolateMilkTea : MilkTea {
        private readonly double price = 1.5;

        public override string DoMilkTea() {
            return "Trà sữa Socola";
        }
        public override double Cost() {
            return price;
        }
    }
}
