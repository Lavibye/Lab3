using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsApp
{
    public class Stork : Bird
    {
        public double WingSpan { get; set; }

        public Stork(string name, double wingSpan) : base(name)
        {
            WingSpan = wingSpan;
        }

        public override double CalculateFoodRequirement()
        {
            return WingSpan * 1 / 2000;
        }
    }
}
