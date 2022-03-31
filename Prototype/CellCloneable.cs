using System;
using System.Threading;

namespace Prototype {
    internal class CellCloneable : ICloneable {
        private string color;

        public string Color { get => color; set => color = value; }

        public CellCloneable(string color) {
            Color = color;

            try {
                Thread.Sleep(100);
            }
            catch (ThreadInterruptedException e) {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString() {
            return color.Substring(0, 1);
        }

        public object Clone() {
            object obj = null;

            try {
                Thread.Sleep(100);
                obj = this.MemberwiseClone();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return obj;
        }
    }
}
