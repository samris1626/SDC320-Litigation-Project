/************************************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320 Course Project - Week 4
*
* Represents a legal case connecting a claimant to a business.
* Maps to Cases table in SQLite database.
*/

namespace LegalCaseManagement
{
    public class CaseRecord
    {
        public int CaseID { get; set; }
        public string CaseName { get; set; }
        public string CaseDescription { get; set; }
        public int ClaimantID { get; set; }
        public int BusinessID { get; set; }

        public CaseRecord() { }

        public CaseRecord(int caseID, string name, string description, int claimantID, int businessID)
        {
            CaseID = caseID;
            CaseName = name;
            CaseDescription = description;
            ClaimantID = claimantID;
            BusinessID = businessID;
        }

        public override string ToString()
        {
            return $"Case ID: {CaseID}\n" +
                   $"Case Name: {CaseName}\n" +
                   $"Description: {CaseDescription}\n" +
                   $"Claimant ID: {ClaimantID}\n" +
                   $"Business ID: {BusinessID}";
        }
    }
}
