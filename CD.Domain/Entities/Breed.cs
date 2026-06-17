using CD.Domain.Management.ValueObjects;
using CD.Domain.SharedKernel;

namespace CD.Domain.Management.Entities
{
    public class Breed : Entity
    {
        public string Name { get; set; }

        public WeightRange MaleIdealWeight { get; set; }
        public WeightRange FemaleIdealWeight { get; set; }

        /*Instead of these properties*/
        //public decimal FromMaleIdealWeight { get; set; }
        //public decimal ToMaleIdealWeight { get; set; }
        //public decimal FromFemaleIdealWeight { get; set; }
        //public decimal ToFemaleIdealWeight { get; set; }

        public Breed(Guid id,string name, WeightRange maleIdealWeight, WeightRange femaleIdealWeight)
        {
            Id = id;
            Name = name;
            MaleIdealWeight = maleIdealWeight;
            FemaleIdealWeight = femaleIdealWeight;
        }
    }
}
