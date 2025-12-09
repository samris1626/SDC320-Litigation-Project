/************************************************************
* Name: Samantha Riser
* Date: 12/8/2025
* Assignment: SDC320 Course Project - Week 4
*
* Simple terminal menu to manage Claimants, Businesses, and Cases
* using DatabaseManager CRUD methods
*/

using System;

namespace LegalCaseManagement
{
    public class MenuManager
    {
        private DatabaseManager _db;

        public MenuManager(DatabaseManager db)
        {
            _db = db;
        }

        public void ShowMainMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===== MAIN MENU =====");
                Console.WriteLine("1. Manage Claimants");
                Console.WriteLine("2. Manage Businesses");
                Console.WriteLine("3. Manage Cases");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowClaimantMenu();
                        break;
                    case "2":
                        ShowBusinessMenu();
                        break;
                    case "3":
                        ShowCaseMenu();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // CLAIMANT MENU
       private void ShowClaimantMenu()
        {
            Console.Clear();
            Console.WriteLine("=== CLAIMANT MENU ===");
            Console.WriteLine("1. Add Claimant");
            Console.WriteLine("2. View Claimant");
            Console.WriteLine("3. Update Claimant");
            Console.WriteLine("4. Delete Claimant");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddClaimant();
                    break;
                case "2":
                    ViewClaimant();
                    break;
                case "3":
                    UpdateClaimant();
                    break;
                case "4":
                    DeleteClaimant();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key...");
                    Console.ReadKey();
                    break;
            }
        }

        private void AddClaimant()
        {
            Console.Clear();
            Console.WriteLine("Enter First Name:");
            string fn = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string ln = Console.ReadLine();
            Console.WriteLine("Enter Phone:");
            string ph = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string em = Console.ReadLine();
            Console.WriteLine("Enter Business ID:");
            int bid = int.Parse(Console.ReadLine());

            _db.AddClaimant(new Claimant
            {
                FirstName = fn,
                LastName = ln,
                PhoneNumber = ph,
                Email = em,
                BusinessID = bid
            });

            Console.WriteLine("Claimant added! Press any key...");
            Console.ReadKey();
        }

        private void ViewClaimant()
        {
            Console.Clear();
            Console.WriteLine("Enter Claimant ID:");
            int id = int.Parse(Console.ReadLine());
            var c = _db.GetClaimant(id);
            if (c != null)
                Console.WriteLine(c);
            else
                Console.WriteLine("Claimant not found.");
            Console.ReadKey();
        }

        private void UpdateClaimant()
        {
            Console.Clear();
            Console.WriteLine("Enter Claimant ID to update:");
            int id = int.Parse(Console.ReadLine());
            var c = _db.GetClaimant(id);
            if (c == null)
            {
                Console.WriteLine("Claimant not found.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Updating {c.FirstName} {c.LastName}");
            Console.WriteLine("Enter new First Name:");
            c.FirstName = Console.ReadLine();
            Console.WriteLine("Enter new Last Name:");
            c.LastName = Console.ReadLine();
            Console.WriteLine("Enter new Phone:");
            c.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter new Email:");
            c.Email = Console.ReadLine();
            Console.WriteLine("Enter new Business ID:");
            c.BusinessID = int.Parse(Console.ReadLine());

            _db.UpdateClaimant(c);
            Console.WriteLine("Claimant updated! Press any key...");
            Console.ReadKey();
        }

        private void DeleteClaimant()
        {
            Console.Clear();
            Console.WriteLine("Enter Claimant ID to delete:");
            int id = int.Parse(Console.ReadLine());
            _db.DeleteClaimant(id);
            Console.WriteLine("Claimant deleted! Press any key...");
            Console.ReadKey();
        }

        // BUSINESS MENU
        private void ShowBusinessMenu()
        {
            Console.Clear();
            Console.WriteLine("=== BUSINESS MENU ===");
            Console.WriteLine("1. Add Business");
            Console.WriteLine("2. View Business");
            Console.WriteLine("3. Update Business");
            Console.WriteLine("4. Delete Business");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBusiness();
                    break;
                case "2":
                    ViewBusiness();
                    break;
                case "3":
                    UpdateBusiness();
                    break;
                case "4":
                    DeleteBusiness();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key...");
                    Console.ReadKey();
                    break;
            }
        }

        private void AddBusiness()
        {
            Console.Clear();
            Console.WriteLine("Enter Business Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Phone:");
            string ph = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            string addr = Console.ReadLine();

            _db.AddBusiness(new Business
            {
                BusinessName = name,
                ContactPhone = ph,
                Address = addr
            });

            Console.WriteLine("Business added! Press any key...");
            Console.ReadKey();
        }

        private void ViewBusiness()
        {
            Console.Clear();
            Console.WriteLine("Enter Business ID:");
            int id = int.Parse(Console.ReadLine());
            var b = _db.GetBusiness(id);
            if (b != null)
                Console.WriteLine(b);
            else
                Console.WriteLine("Business not found.");
            Console.ReadKey();
        }

        private void UpdateBusiness()
        {
            Console.Clear();
            Console.WriteLine("Enter Business ID to update:");
            int id = int.Parse(Console.ReadLine());
            var b = _db.GetBusiness(id);
            if (b == null)
            {
                Console.WriteLine("Business not found.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Updating {b.BusinessName}");
            Console.WriteLine("Enter new Name:");
            b.BusinessName = Console.ReadLine();
            Console.WriteLine("Enter new Phone:");
            b.ContactPhone = Console.ReadLine();
            Console.WriteLine("Enter new Address:");
            b.Address = Console.ReadLine();

            _db.UpdateBusiness(b);
            Console.WriteLine("Business updated! Press any key...");
            Console.ReadKey();
        }

        private void DeleteBusiness()
        {
            Console.Clear();
            Console.WriteLine("Enter Business ID to delete:");
            int id = int.Parse(Console.ReadLine());
            _db.DeleteBusiness(id);
            Console.WriteLine("Business deleted! Press any key...");
            Console.ReadKey();
        }

        // CASE MENU
        private void ShowCaseMenu()
        {
            Console.Clear();
            Console.WriteLine("=== CASE MENU ===");
            Console.WriteLine("1. Add Case");
            Console.WriteLine("2. View Case");
            Console.WriteLine("3. Update Case");
            Console.WriteLine("4. Delete Case");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCase();
                    break;
                case "2":
                    ViewCase();
                    break;
                case "3":
                    UpdateCase();
                    break;
                case "4":
                    DeleteCase();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key...");
                    Console.ReadKey();
                    break;
            }
        }

        private void AddCase()
        {
            Console.Clear();
            Console.WriteLine("Enter Case Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Description:");
            string desc = Console.ReadLine();
            Console.WriteLine("Enter Claimant ID:");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Business ID:");
            int bid = int.Parse(Console.ReadLine());

            _db.AddCase(new CaseRecord
            {
                CaseName = name,
                CaseDescription = desc,
                ClaimantID = cid,
                BusinessID = bid
            });

            Console.WriteLine("Case added! Press any key...");
            Console.ReadKey();
        }

        private void ViewCase()
        {
            Console.Clear();
            Console.WriteLine("Enter Case ID:");
            int id = int.Parse(Console.ReadLine());
            var c = _db.GetCase(id);
            if (c != null)
                Console.WriteLine(c);
            else
                Console.WriteLine("Case not found.");
            Console.ReadKey();
        }

        private void UpdateCase()
        {
            Console.Clear();
            Console.WriteLine("Enter Case ID to update:");
            int id = int.Parse(Console.ReadLine());
            var c = _db.GetCase(id);
            if (c == null)
            {
                Console.WriteLine("Case not found.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Updating {c.CaseName}");
            Console.WriteLine("Enter new Case Name:");
            c.CaseName = Console.ReadLine();
            Console.WriteLine("Enter new Description:");
            c.CaseDescription = Console.ReadLine();
            Console.WriteLine("Enter new Claimant ID:");
            c.ClaimantID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Business ID:");
            c.BusinessID = int.Parse(Console.ReadLine());

            _db.UpdateCase(c);
            Console.WriteLine("Case updated! Press any key...");
            Console.ReadKey();
        }

        private void DeleteCase()
        {
            Console.Clear();
            Console.WriteLine("Enter Case ID to delete:");
            int id = int.Parse(Console.ReadLine());
            _db.DeleteCase(id);
            Console.WriteLine("Case deleted! Press any key...");
            Console.ReadKey();
        }
    }
}
