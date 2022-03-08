using Adapter.Component;
using System;

namespace Adapter {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Input Round Hole radius: ");
            RoundHole roundHole = new RoundHole(double.Parse(Console.ReadLine()));

            Console.Write("Input Round Peg radius: ");
            RoundPeg roundPeg = new RoundPeg(double.Parse(Console.ReadLine()));

            Console.Write("Input Square Peg width: ");
            SquarePeg squarePeg = new SquarePeg(double.Parse(Console.ReadLine()));

            PegAdapter pegAdapter = new PegAdapter(squarePeg);

            Console.WriteLine();
            Console.WriteLine(string.Format("Round Peg is {0} fit with the Round Hole", roundHole.Fits(roundPeg) ? "\b" : "not"));
            Console.WriteLine(string.Format("Square Peg is {0} fit with the Round Hole", roundHole.Fits(pegAdapter) ? "\b" : "not"));
        }
    }
}
