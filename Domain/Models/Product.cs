using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name {get; set; }

        public short QuantityInPackage { get; set; }

        public EUnitOfMeasurement EUnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}