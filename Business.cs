/************************************************************
* Name: Samantha Riser
* Date: 11/30/2025
* Assignment: SDC320 Course Project - Week 3
*
* Represents a business involved in one or more lawsuits.
* Stores contact details and address information.
* This corresponds to a row in the Businesses table.
*
*/

public class Business
{

    public int BusinessID { get; set; }
    public string BusinessName { get; set; }
    public string ContactPhone { get; set; }
    public string Address { get; set; }

    public Business()
    {
    }

    public Business(int businessID, string name, string phone, string address)
    {
        BusinessID = businessID;
        BusinessName = name;
        ContactPhone = phone;
        Address = address;
    }

    public override string ToString()
    {
        return $"Business ID: {BusinessID}\n" +
               $"Name: {BusinessName}\n" +
               $"Phone: {ContactPhone}\n" +
               $"Address: {Address}";
    }
}
