namespace FactoryMethod.Product {
    class Truck : ITransport {
        public string Deliver() {
            return "Deliver by truck.";
        }
    }
}
