using CD.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.Clinic
{
    public class Drug : Entity
    {
        public string Name { get; init; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public Drug(string name, string description, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
        }
        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0)
                throw new ArgumentException("Price cannot be negative.", nameof(newPrice));
            Price = newPrice;
        }
    }
}
