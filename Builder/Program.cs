using System;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            var director = new Director();
            var builder = new HouseBuilder();
            director.Builder = builder;

            Console.WriteLine("Custom house:");
            builder.BuildWindows().BuildGarage().BuildDoors();
            Console.Write(builder.Build().ListParts());

            Console.WriteLine("Standard basic house:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.Build().ListParts());

            Console.WriteLine("Standard full featured house:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.Build().ListParts());
        }
    }
}
