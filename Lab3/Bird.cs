using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsApp
{
    public abstract class Bird
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public abstract double CalculateFoodRequirement();

        public string DisplayInfo => $"{Name}: Food per day = {CalculateFoodRequirement()}";
    }
}
