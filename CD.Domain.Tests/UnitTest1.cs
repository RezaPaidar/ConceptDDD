using CD.Domain.Entities;
using CD.Domain.ValueObjects;
using System.Xml.Linq;

namespace CD.Domain.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Pet_should_be_equal()
        {
            var id = Guid.NewGuid();
            var service = new MockBreedService();
            var breedId = new BreedId(service.breeds[0].Id, service);

            var pet1 = new Pet(id, "Belfi", 7, "Two-Colors", new Weight(25.2m), SexOfPet.Male, breedId);
            var pet2 = new Pet(id, "Taffi", 2, "Three-Colors", new Weight(3.1m), SexOfPet.Female, breedId);

            Assert.True(pet1.Equals(pet2));
        }

        [Fact]
        public void Pet_should_be_equal_using_operators()
        {
            var id = Guid.NewGuid();
            var service = new MockBreedService();
            var breedId = new BreedId(service.breeds[0].Id, service);
            var pet1 = new Pet(id, "Belfi", 7, "Two-Colors", new Weight(25.2m), SexOfPet.Male, breedId);
            var pet2 = new Pet(id, "Taffi", 2, "Three-Colors", new Weight(3.1m), SexOfPet.Female, breedId);

            Assert.True(pet1 == pet2);
        }

        [Fact]
        public void Pet_should_not_be_equal_using_operators()
        {
            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var service = new MockBreedService();
            var breedId1 = new BreedId(service.breeds[0].Id, service);
            var breedId2 = new BreedId(service.breeds[1].Id, service);

            var pet1 = new Pet(id1, "Belfi", 7, "Two-Colors", new Weight(25.2m), SexOfPet.Male, breedId1);
            var pet2 = new Pet(id2, "Taffi", 2, "Three-Colors", new Weight(3.1m), SexOfPet.Female, breedId2);

            Assert.True(pet1 != pet2);
        }

        [Fact]
        public void Weight_should_be_equal()
        {
            var w1 = new Weight(25.2m);
            var w2 = new Weight(25.2m);

            Assert.True(w1 == w2);
        }

        [Fact]
        public void Weight_Range_should_be_equal()
        {
            var w1 = new WeightRange(2m, 25.2m);
            var w2 = new WeightRange(2m, 25.2m);

            Assert.True(w1 == w2);
        }

        [Fact]
        public void BreedId_should_be_valid()
        {
            var service = new MockBreedService();
            var id = service.breeds[0].Id;
            var breedId = new BreedId(id, service);
            Assert.NotNull(breedId);
        }

        [Fact]
        public void BreedId_should_not_be_valid()
        {
            var service = new MockBreedService();
            var id = Guid.NewGuid();
            Assert.Throws<ArgumentException>(() =>
             {
                 var breedId = new BreedId(id, service);
             });
        }
    }
}
