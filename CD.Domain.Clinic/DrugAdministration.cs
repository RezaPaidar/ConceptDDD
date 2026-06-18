using CD.Domain.Clinic.ValueObjects;
using CD.Domain.SharedKernel;

namespace CD.Domain.Clinic
{
    public class DrugAdministration : Entity
    {
        public DrugId DrugId { get; init; }
        public Dose Dose { get; init; }
        public DrugAdministration(DrugId drugId, Dose dose)
        {
            Id = Guid.NewGuid();
            DrugId = drugId;
            Dose = dose;
        }
    }
}
