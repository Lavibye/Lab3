﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsApp
{
    public class Crow : Bird
    {
        public double Height { get; set; }

        public Crow(string name, double height) : base(name)
        {
            Height = height;
        }

        public override double CalculateFoodRequirement()
        {
            return 0.8 * Height;
        }
    }
}
