using AbstractFactory.Product;

namespace AbstractFactory.Factory {
    class VictorianFurnitureFactory : IFurnitureFactory {
        public IChair CreateChair() {
            return new VictorianChair();
        }

        public ICoffeeTable CreateCoffeeTable() {
            return new VictorianCoffeeTable();
        }

        public ISofa CreateSofa() {
            return new VictorianSofa();
        }
    }
}
