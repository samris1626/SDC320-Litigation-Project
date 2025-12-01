/************************************************************
* Name: Samantha Riser
* Date: 11/30/2025
* Assignment: SDC320 Course Project - Week 3
*
* Manages all menu screens and user interactions in the terminal interface.
* Provides options to navigate to claimant, business, and case management.
* Actual CRUD operations will be added once the database layer is complete.
*
*/

public class MenuManager
{
    // Reference to the database manager so menus can trigger CRUD actions
    private DatabaseManager _database;

    public MenuManager(DatabaseManager db)
    {
        _database = db;
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

    public void ShowClaimantMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Claimant Menu (CRUD coming in Week 4) ===");
        Console.ReadKey();
    }

    
    public void ShowBusinessMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Business Menu (CRUD coming in Week 4) ===");
        Console.ReadKey();
    }
  
    public void ShowCaseMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Case Menu (CRUD coming in Week 4) ===");
        Console.ReadKey();
    }
}
