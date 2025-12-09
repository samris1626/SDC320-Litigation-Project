/************************************************************
* Name: Samantha Riser
* Date: 12/8/2025
* Assignment: SDC320 Course Project - Week 4
*
* Represents a claimant filing a lawsuit.
* Maps to Claimants table in SQLite database.
*/

namespace LegalCaseManagement
{
    public class Claimant
    {
        public int ClaimantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int BusinessID { get; set; }

        public Claimant() { }

        public Claimant(int claimantID, string firstName, string lastName, string phoneNumber, string email, int businessID)
        {
            ClaimantID = claimantID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            BusinessID = businessID;
        }

        public override string ToString()
        {
            return $"Claimant ID: {ClaimantID}\n" +
                   $"Name: {FirstName} {LastName}\n" +
                   $"Phone: {PhoneNumber}\n" +
                   $"Email: {Email}\n" +
                   $"Business ID: {BusinessID}";
        }
    }
}
