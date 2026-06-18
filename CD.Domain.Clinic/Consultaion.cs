using CD.Domain.Clinic.ValueObjects;
using CD.Domain.SharedKernel;

namespace CD.Domain.Clinic
{
    public class Consultaion : AggregateRoot
    {
        private readonly List<DrugAdministration> administretedDrugs = new();
        public DateTime StartedAdd { get; init; }
        public DateTime? EndedAt { get; private set; }
        public Text Diagnosis { get; private set; }
        public Text Treatment { get; private set; }
        public PatientId PatientId { get; set; }
        public Weight CurrentWeight { get; private set; }
        public ConsultationStatus Status { get; private set; }
        public IReadOnlyCollection<DrugAdministration> AdministretedDrugs => administretedDrugs;

        public Consultaion(PatientId patientId)
        {
            Id = Guid.NewGuid();
            this.PatientId = patientId;
            Status = ConsultationStatus.Open;
            this.StartedAdd = DateTime.UtcNow;
        }

        public void AdministerDrug(DrugId drugId, Dose dose)
        {
            ValidationConsultationStatus();
            var newDrugAdministration = new DrugAdministration(drugId, dose);
            this.administretedDrugs.Add(newDrugAdministration);
        }

        public void End()
        {
            ValidationConsultationStatus();
            if (this.Diagnosis == null || this.Treatment == null || this.CurrentWeight == null)
            {
                throw new InvalidOperationException("Cannot close consultation without diagnosis, treatment, and weight.");
            }
            this.EndedAt = DateTime.UtcNow;
        }

        public void SetWeight(Weight weight)
        {
            ValidationConsultationStatus();
            this.CurrentWeight = weight;
        }

        private void ValidationConsultationStatus()
        {
            if (Status == ConsultationStatus.Close)
                throw new InvalidOperationException("Cannot set weight for a closed consultation.");
        }

        public void SetDiagnosis(Text diagnosis)
        {
            ValidationConsultationStatus();
            this.Diagnosis = diagnosis;
        }

        public void SetTreatment(Text treatment)
        {
            ValidationConsultationStatus();
            this.Treatment = treatment;
        }
    }

    public enum ConsultationStatus
    {
        Open,
        Close,
    }
}
