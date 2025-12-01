/************************************************************
* Name: Samantha Riser
* Date: 11/30/2025
* Assignment: SDC320 Course Project - Week 3
*
* Responsible for all database-related work.
* This includes creating tables, connecting to SQLite, and
* performing CRUD operations for Claimants, Businesses, and CaseRecords.
*
*/

public class DatabaseManager
{
    public DatabaseManager() { }

    public override string ToString()
    {
        return "Database Manager: Handles all database operations.";
    }

    public void InitializeDatabase()
    {
        // Future implementation (Week 4)
    }

    public void AddClaimant(Claimant claimant)
    {
        // Will connect to SQLite and insert row
    }

    public Claimant GetClaimant(int claimantID)
    {
        return null; 
    }
  
    public void UpdateClaimant(Claimant claimant)
    {
    }

    public void DeleteClaimant(int claimantID)
    {
    }
}
