namespace FactoryMethod.Product {
    class Helicopter : ITransport {
        public string Deliver() {
            return string.Format("Deliver by {0}.", ToString());
        }

        public override string ToString() {
            return "Helicopter";
        }
    }
}
