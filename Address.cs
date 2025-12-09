/************************************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320 Course Project - Week 4
*
* Address class used for database storage.
*/

namespace LegalCaseManagement
{
    public class Address
    {
        public int Id { get; set; }            // Primary Key
        public int PersonId { get; set; }      // Foreign Key (Person)
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address() { }

        public Address(int id, int personId, string street, string city, string state, string zip)
        {
            Id = id;
            PersonId = personId;
            Street = street;
            City = city;
            State = state;
            ZipCode = zip;
        }

        public override string ToString()
        {
            return $"{Id}: {Street}, {City}, {State} {ZipCode} (Person ID: {PersonId})";
        }
    }
}
