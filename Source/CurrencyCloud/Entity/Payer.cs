﻿using System;
using System.Linq;

namespace CurrencyCloud.Entity
{
    public class Payer : Entity
    {
        [Newtonsoft.Json.JsonConstructor]
        public Payer() { }

        public string Id { get; set; }

        [Param]
        public string LegalEntityType { get; set; }

        [Param]
        public string CompanyName { get; set; }

        [Param]
        public string FirstName { get; set; }

        [Param]
        public string LastName { get; set; }

        [Param]
        public string Address { get; set; }

        [Param]
        public string City { get; set; }

        [Param]
        public string StateOrProvince { get; set; }

        [Param]
        public string Country { get; set; }

        [Param]
        public string IdentificationType { get; set; }

        [Param]
        public string IdentificationValue { get; set; }

        [Param]
        public string Postcode { get; set; }

        [Param]
        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Payer))
            {
                return false;
            }

            var payer = obj as Payer;

            return Id == payer.Id &&
                   LegalEntityType == payer.LegalEntityType &&
                   CompanyName == payer.CompanyName &&
                   FirstName == payer.FirstName &&
                   LastName == payer.LastName &&
                   Address.SequenceEqual(payer.Address) &&
                   City == payer.City &&
                   StateOrProvince == payer.StateOrProvince &&
                   IdentificationType == payer.IdentificationType &&
                   IdentificationValue == payer.IdentificationValue &&
                   Postcode == payer.Postcode &&
                   DateOfBirth == payer.DateOfBirth &&
                   CreatedAt == payer.CreatedAt &&
                   UpdatedAt == payer.UpdatedAt;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
