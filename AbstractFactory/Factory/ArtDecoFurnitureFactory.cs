using AbstractFactory.Product;

namespace AbstractFactory.Factory {
    class ArtDecoFurnitureFactory : IFurnitureFactory {
        public IChair CreateChair() {
            return new ArtDecoChair();
        }

        public ICoffeeTable CreateCoffeeTable() {
            return new ArtDecoCoffeeTable();
        }

        public ISofa CreateSofa() {
            return new ArtDecoSofa();
        }
    }
}
