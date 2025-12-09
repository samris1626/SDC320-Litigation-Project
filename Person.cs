/**************************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320 Course Project - Week 4
*
* Person model class used for database storage.
*/

namespace LegalCaseManagement
{
    public class Person
    {
        public int Id { get; set; }          // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Person() { }

        public Person(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Email})";
        }
    }
}
