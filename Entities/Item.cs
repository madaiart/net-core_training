using System;

namespace Catalog.Entities
{
    public record Item // record for inmuteable revors
    {
        public Guid Id { get; init; } // Set a value only in the initialization
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreteDate {get; init;}        
    }
}