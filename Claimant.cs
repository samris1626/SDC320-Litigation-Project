/************************************************************
* Name: Samantha Riser
* Date: 11/30/2025
* Assignment: SDC320 Course Project - Week 3
* Represents a claimant who is filing a lawsuit. 
* Stores personal contact information and the business associated with the claimant.
* This class is part of the core data model and will map directly to the Claimants table in the database.
*
*/
public class Claimant
{
    // Unique identifier for the claimant (Primary Key in database)
    public int ClaimantID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int BusinessID { get; set; }

    // Default constructor (required for object initialization)
    public Claimant() { }

    // Constructor that allows quick creation of a claimant object
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
