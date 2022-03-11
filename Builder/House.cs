using System.Collections.Generic;

namespace Builder {
    public class House {
        private readonly List<object> _part = new List<object>();

        public void Add(string part) {
            _part.Add(part);
        }

        public string ListParts() {
            string str = string.Empty;

            _part.ForEach(e => str += e + ", ");

            str = str.Remove(str.Length - 2);

            return "House parts: " + str + "\n";
        }
    }
}
