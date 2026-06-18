using CD.Domain.Clinic.ValueObjects;
using CD.Domain.SharedKernel;

namespace CD.Domain.Management.Clinic
{
    public class Consultaion : AggregateRoot
    {
        public Text Diagnosis { get; private set; }
        public Text Treatment { get; private set; }
        public PatientId PatientId { get; set; }
        public Weight CurrentWeight { get; private set; }
        public ConsultationStatus Status { get; private set; }


        public void SetWeight(Weight weight)
        {
            CurrentWeight = weight;
        }


    }

    public enum ConsultationStatus
    {
        Open,
        Close,
    }
}
