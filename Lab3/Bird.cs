using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Bird
    {
        public string Name { get; set; }
        public double L { get; set; }

        public abstract double Fly();
    }
}
