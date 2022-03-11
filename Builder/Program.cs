using Builder.Director;
using Builder.Builder;
using System;

namespace Builder {
    class Program {
        static void Main() {
            HouseDirector director = new();
            HouseBuilder builder;

            builder = new AncientHouseBuilder();
            director.Builder = builder;

            Console.WriteLine("ANCIENT HOUSE");
            Console.WriteLine("Standard basic house...");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.Build().ListParts());

            Console.WriteLine("Standard full featured house...");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.Build().ListParts());

            Console.WriteLine("Custom house...");
            builder.BuildWindows()
                .BuildDoors()
                .BuildWalls();
            Console.WriteLine(builder.Build().ListParts());

            builder = new ModernHouseBuilder();
            director.Builder = builder;

            Console.WriteLine("================================");
            Console.WriteLine("MODERN HOUSE");
            Console.WriteLine("Standard basic house...");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.Build().ListParts());

            Console.WriteLine("Standard full featured house...");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.Build().ListParts());

            Console.WriteLine("Custom house...");
            builder.BuildWindows()
                .BuildDoors()
                .BuildWalls();
            Console.WriteLine(builder.Build().ListParts());
        }
    }
}
