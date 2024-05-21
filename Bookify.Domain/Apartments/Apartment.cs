﻿using Bookify.Domain.Abstractions;
using Bookify.Domain.Shared;

namespace Bookify.Domain.Apartments
{
    public sealed class Apartment : Entity 
    {
        public Apartment(
            Guid id,
            Name name,
            Description description,
            Address adress,
            Money price,
            Money cleaningFee,
            List<Amenity> amenities)
            :base(id)
        {
            Name = name;
            Description = description;
            Address = adress;
            Price = price;
            CleaningFee = cleaningFee;
            Amenities = amenities;
        }

        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public Address Address { get; private set; }
        public decimal PriceAmount { get; private set; }
        public Money Price { get; private set; }

        public Money CleaningFee { get; private set; }
        public DateTime? LastBookedOnUtc { get; internal set; }
        public List<Amenity> Amenities { get; private set; } = new();
    }
}
