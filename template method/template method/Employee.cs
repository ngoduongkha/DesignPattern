﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    internal class Employee : Person
    {
        protected override void Work()
        {
            Console.WriteLine("Employee work");
        }
    }
}
