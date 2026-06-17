using CD.Domain.Entities;

namespace CD.Domain
{
    public interface IBreedService
    {
        Breed? GetBreed(Guid id);
    }

    public class MockBreedService : IBreedService
    {
        public readonly List<Breed> breeds =
            [
                new Breed (Guid.NewGuid(), "Sarabi" , new ValueObjects.WeightRange(10m,20m), new ValueObjects.WeightRange(7m,20m)),
                new Breed (Guid.NewGuid(), "Mastif" , new ValueObjects.WeightRange(10m,20m), new ValueObjects.WeightRange(7m,20m)),
            ];

        public Breed? GetBreed(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Breed is not valid.");
            }
            var result = breeds.Find(breed => breed.Id == id);
            return result ?? throw new ArgumentException("Breed was not found");
        }
    }
}
