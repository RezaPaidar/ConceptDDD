using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain
{
    public class Breed: Entity
    {
        public string Name { get; set; }

        public WeightRange MaleIdealWeight { get; set; }
        public WeightRange FemaleIdealWeight { get; set; }

        /*Instead of these properties*/
        //public decimal FromMaleIdealWeight { get; set; }
        //public decimal ToMaleIdealWeight { get; set; }
        //public decimal FromFemaleIdealWeight { get; set; }
        //public decimal ToFemaleIdealWeight { get; set; }

        public Breed(string name, WeightRange maleIdealWeight, WeightRange femaleIdealWeight)
        {
            Name = name;
            MaleIdealWeight = maleIdealWeight;
            FemaleIdealWeight = femaleIdealWeight;
        }
    }

    public record WeightRange
    {
        public decimal From { get; init; }
        public decimal To { get; init; }

        public WeightRange(decimal from, decimal to)
        {
            From = from;
            To = to;
        }
    }
}
