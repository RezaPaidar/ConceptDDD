using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.Clinic.ValueObjects
{
    public record DrugId
    {
        public Guid Value { get; init; }
        public DrugId(Guid value)
        {
            Value = value;
        }
    }
}
