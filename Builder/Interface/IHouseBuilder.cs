namespace Builder.Interface {
    public interface IHouseBuilder {
        IHouseBuilder BuildWalls();
        IHouseBuilder BuildDoors();
        IHouseBuilder BuildWindows();
        IHouseBuilder BuildRoof();
        House Build();
    }
}
