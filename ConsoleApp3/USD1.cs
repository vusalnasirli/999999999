using ConsoleApp3.MODELS;
using System;

namespace ConsoleApp3
{
    internal class USD
    {
        private int v;

        public USD(int v)
        {
            this.v = v;
        }

        public bool Amount { get; internal set; }

        public static implicit operator USD(AZN v)
        {
            throw new NotImplementedException();
        }
    }
}