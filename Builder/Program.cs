using Builder.Product;
using System;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            Director director = new Director();
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
            builder.BuildWindows();
            Console.WriteLine(builder.Build().ListParts());

            builder = new ModernHouseBuilder();
            director.Builder = builder;

            Console.WriteLine("\nMODERN HOUSE");
            Console.WriteLine("Standard basic house...");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.Build().ListParts());

            Console.WriteLine("Standard full featured house...");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.Build().ListParts());

            Console.WriteLine("Custom house...");
            builder.BuildWindows();
            Console.WriteLine(builder.Build().ListParts());
        }
    }
}
