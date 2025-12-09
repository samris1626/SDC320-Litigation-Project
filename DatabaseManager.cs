/************************************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320 Course Project - Week 4
*
* Handles all SQLite database work:
* Creates tables
* Simple CRUD for Claimants, Businesses, and Cases
*/

using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace LegalCaseManagement
{
    public class DatabaseManager
    {
        private const string ConnectionString = "Data Source=legal_cases.db;Version=3;";

        // DB Initialization
        public void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createClaimantTable = @"
                    CREATE TABLE IF NOT EXISTS Claimants (
                        ClaimantID INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        PhoneNumber TEXT,
                        Email TEXT,
                        BusinessID INTEGER
                    );";

                string createBusinessTable = @"
                    CREATE TABLE IF NOT EXISTS Businesses (
                        BusinessID INTEGER PRIMARY KEY AUTOINCREMENT,
                        BusinessName TEXT NOT NULL,
                        ContactPhone TEXT,
                        Address TEXT
                    );";

                string createCaseTable = @"
                    CREATE TABLE IF NOT EXISTS Cases (
                        CaseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CaseName TEXT NOT NULL,
                        CaseDescription TEXT,
                        ClaimantID INTEGER,
                        BusinessID INTEGER
                    );";

                new SQLiteCommand(createClaimantTable, connection).ExecuteNonQuery();
                new SQLiteCommand(createBusinessTable, connection).ExecuteNonQuery();
                new SQLiteCommand(createCaseTable, connection).ExecuteNonQuery();
            }
        }

        // CLAIMANT CRUD
        public void AddClaimant(Claimant c)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Claimants 
                               (FirstName, LastName, PhoneNumber, Email, BusinessID) 
                               VALUES (@fn, @ln, @ph, @em, @bid);";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fn", c.FirstName);
                cmd.Parameters.AddWithValue("@ln", c.LastName);
                cmd.Parameters.AddWithValue("@ph", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@em", c.Email);
                cmd.Parameters.AddWithValue("@bid", c.BusinessID);

                cmd.ExecuteNonQuery();
            }
        }

        public Claimant GetClaimant(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Claimants WHERE ClaimantID = @id";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Claimant
                        {
                            ClaimantID = Convert.ToInt32(reader["ClaimantID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            BusinessID = Convert.ToInt32(reader["BusinessID"])
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateClaimant(Claimant c)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE Claimants SET
                               FirstName=@fn, LastName=@ln, PhoneNumber=@ph,
                               Email=@em, BusinessID=@bid
                               WHERE ClaimantID=@id;";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fn", c.FirstName);
                cmd.Parameters.AddWithValue("@ln", c.LastName);
                cmd.Parameters.AddWithValue("@ph", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@em", c.Email);
                cmd.Parameters.AddWithValue("@bid", c.BusinessID);
                cmd.Parameters.AddWithValue("@id", c.ClaimantID);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteClaimant(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Claimants WHERE ClaimantID=@id";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        // BUSINESS CRUD
        public void AddBusiness(Business b)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Businesses 
                               (BusinessName, ContactPhone, Address)
                               VALUES (@n, @p, @a);";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@n", b.BusinessName);
                cmd.Parameters.AddWithValue("@p", b.ContactPhone);
                cmd.Parameters.AddWithValue("@a", b.Address);

                cmd.ExecuteNonQuery();
            }
        }

        public Business GetBusiness(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Businesses WHERE BusinessID=@id";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Business
                        {
                            BusinessID = Convert.ToInt32(reader["BusinessID"]),
                            BusinessName = reader["BusinessName"].ToString(),
                            ContactPhone = reader["ContactPhone"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateBusiness(Business b)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE Businesses SET
                               BusinessName=@n, ContactPhone=@p, Address=@a
                               WHERE BusinessID=@id;";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@n", b.BusinessName);
                cmd.Parameters.AddWithValue("@p", b.ContactPhone);
                cmd.Parameters.AddWithValue("@a", b.Address);
                cmd.Parameters.AddWithValue("@id", b.BusinessID);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBusiness(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Businesses WHERE BusinessID=@id";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        // CASE CRUD
        public void AddCase(CaseRecord c)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Cases
                               (CaseName, CaseDescription, ClaimantID, BusinessID)
                               VALUES (@n, @d, @cid, @bid);";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@n", c.CaseName);
                cmd.Parameters.AddWithValue("@d", c.CaseDescription);
                cmd.Parameters.AddWithValue("@cid", c.ClaimantID);
                cmd.Parameters.AddWithValue("@bid", c.BusinessID);

                cmd.ExecuteNonQuery();
            }
        }

        public CaseRecord GetCase(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Cases WHERE CaseID=@id";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new CaseRecord
                        {
                            CaseID = Convert.ToInt32(reader["CaseID"]),
                            CaseName = reader["CaseName"].ToString(),
                            CaseDescription = reader["CaseDescription"].ToString(),
                            ClaimantID = Convert.ToInt32(reader["ClaimantID"]),
                            BusinessID = Convert.ToInt32(reader["BusinessID"])
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateCase(CaseRecord c)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE Cases SET
                               CaseName=@n, CaseDescription=@d,
                               ClaimantID=@cid, BusinessID=@bid
                               WHERE CaseID=@id;";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@n", c.CaseName);
                cmd.Parameters.AddWithValue("@d", c.CaseDescription);
                cmd.Parameters.AddWithValue("@cid", c.ClaimantID);
                cmd.Parameters.AddWithValue("@bid", c.BusinessID);
                cmd.Parameters.AddWithValue("@id", c.CaseID);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCase(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Cases WHERE CaseID=@id";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
