using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.ValueObjects
{
    public record BreedId
    {
        public Guid Value { get; set; }
        public BreedId(Guid value)
        {
            Value = value;
        }
    }
}
