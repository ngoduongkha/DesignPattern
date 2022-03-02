using AbstractFactory.Product;

namespace AbstractFactory.Factory {
    interface IFurnitureFactory {
        public IChair CreateChair();
        public ISofa CreateSofa();
        public ICoffeeTable CreateCoffeeTable();
    }
}
