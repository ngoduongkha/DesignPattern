﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public interface IShape
    {
        void Draw(UnshareConcrete unshare);
    }
}
