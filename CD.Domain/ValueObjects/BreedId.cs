namespace CD.Domain.ValueObjects
{
    public record BreedId
    {
        private readonly IBreedService _breedService;

        public Guid Value { get; set; }
        public BreedId(Guid value, IBreedService breedService)
        {
            this._breedService = breedService;

            ValidateBreed(value);
            Value = value;
        }

        private void ValidateBreed(Guid value)
        {
            if (_breedService.GetBreed(value) == null)
            {
                throw new ArgumentException($"{value} is not valid.");
            }
        }
    }
}
