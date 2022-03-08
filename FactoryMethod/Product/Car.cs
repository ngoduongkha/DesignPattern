namespace FactoryMethod.Product {
    class Car : ITransport {
        public string Deliver() {
            return string.Format("Deliver by {0}.", ToString());
        }

        public override string ToString() {
            return "Car";
        }
    }
}
