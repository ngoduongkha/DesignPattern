﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal class UnixPTS : ThreadScheduler_Implementation
    {
        public string setSystem()
        {
            return ("UnixPTS");
        }
    }
}
