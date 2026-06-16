using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.ValueObjects
{
    public record Weight
    {
        public decimal Value { get; set; }

        public Weight(decimal value)
        {
            if (value < 0)
                throw new ArgumentException($"{value} as a vlaue is not valid");
            Value = value;
        }
    }
}
