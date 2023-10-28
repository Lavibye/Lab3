using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Sparrow : Bird
    {
        public double FoodRequired => L * 1 / 2000;

        public override double Fly()
        {
            return L;
        }

        public virtual double Food()
        {
            return FoodRequired;
        }
    }
}
