using Builder.Product;
using System;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            var director = new Director();
            var builder = new WoodHouseBuilder();
            director.Builder = builder;

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
