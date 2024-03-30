using Sieve.Attributes;

namespace DotNet7.FilterSortingPagingUsingSieve.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public decimal Price { get; set; }
    }
}