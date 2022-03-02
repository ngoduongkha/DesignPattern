namespace FactoryMethod.Product {
    class Ship : ITransport {
        public string Deliver() {
            return "Deliver by ship.";
        }
    }
}
