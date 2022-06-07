using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    internal class JellyBean {
        private readonly string _flavor;

        public JellyBean(string flavor) {
            _flavor = flavor;
        }

        public string Flavor {
            get { return _flavor; }
        }
    }
}
