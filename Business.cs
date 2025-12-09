/*******************************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320 Course Project - Week 4
*
* Represents a business involved in lawsuits.
* Maps to Businesses table in SQLite database.
*/

namespace LegalCaseManagement
{
    public class Business
    {
        public int BusinessID { get; set; }
        public string BusinessName { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }

        public Business() { }

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
}
