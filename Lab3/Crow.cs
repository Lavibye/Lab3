using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Crow : Bird
    {
        public double Height => 0.8 * L;

        public override double Fly()
        {
            return Height;
        }
    }
}
