using System;
using System.Threading;

namespace Prototype {
    internal class Cell {
        private string color;

        public string Color { get => color; set => color = value; }

        public Cell(string color) {
            Color = color;

            // Make it time consuming task.
            try {
                Thread.Sleep(100);
            }
            catch (ThreadInterruptedException e) {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString() {
            return Color.Substring(0, 1);
        }
    }
}
