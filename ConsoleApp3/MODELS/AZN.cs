using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.MODELS
{
    class AZN
    {
        public double Amount { get; set; }
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit USD(AZN azn)
        {
            return new USD(azn.Amount / 1.7);
        }

        public static implicit operator AZN(ConsoleApp3.USD v)
        {
            throw new NotImplementedException();
        }
    }
}
