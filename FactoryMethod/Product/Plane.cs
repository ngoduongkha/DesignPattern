namespace FactoryMethod.Product {
    class Plane : ITransport {
        public string Deliver() {
            return "Deliver by plane.";
        }
    }
}
