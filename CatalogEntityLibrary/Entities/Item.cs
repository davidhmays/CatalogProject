using System;

namespace CatalogEntityLibrary.Entities
{
    public record Item // Record type is like a class but more immutable.
    {
        public Guid Id {get; init;} // Init is like 'set' but cannot be changed later.
        public string Name {get; init;}
        public decimal Price {get; init;}
        public DateTimeOffset CreatedDate {get; init;}

    }
}