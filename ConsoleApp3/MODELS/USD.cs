using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.MODELS
{
    class USD
    {
        public double Amount { get; set; }
        public USD(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.7);
        }
    }
}
