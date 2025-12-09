/*************************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320 Course Project - Week 4
*
* Main application class.
*/

using System;

namespace LegalCaseManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager();

            // Create DB & tables if they don't exist
            db.InitializeDatabase();

            // Start menus
            MenuManager menuManager = new MenuManager(db);
            menuManager.ShowMainMenu();

            Console.WriteLine("Goodbye!");
        }
    }
}
