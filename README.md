# Lawsuit Case Management System

## SDC320 - Course Project
## Samantha Riser

## Overview
This is a C# terminal-based application designed to help users track and manage lawsuit cases. It organizes information about **claimants**, **businesses**, and the **cases** that connect them. The program demonstrates object-oriented programming, class design, and (in later phases) database interaction using SQLite.

## Features
- Add, view, update, and delete claimants  
- Add, view, update, and delete businesses  
- Add, view, update, and delete case records  
- Terminal menu navigation  
- Structured object-oriented class design  
- SQLite database integration (implemented in Phase 2)

## Data Model
### Claimants
- ClaimantID  
- FirstName  
- LastName  
- PhoneNumber  
- Email  
- BusinessID (links claimant to one business)

### Businesses
- BusinessID  
- BusinessName  
- ContactPhone  
- Address  

### Cases
- CaseID  
- CaseName  
- CaseDescription  
- ClaimantID  
- Bus inessID  

## Relationships
- A claimant belongs to one business  
- A business can have many cases  
- A claimant can have many cases  

## Project Structure
- `Claimant.cs` – Model for claimant data  
- `Business.cs` – Model for business data  
- `CaseRecord.cs` – Model for case information  
- `DatabaseManager.cs` – Handles SQLite operations  
- `MenuManager.cs` – Terminal navigation menus  
- `Program.cs` – Entry point

## Phase 1 Status
- All classes implemented  
- Menus implemented  
- Database logic will be added in Phase 2

## How to Run
1. Clone the repository  
2. Build and run using Visual Studio or `dotnet run`  
3. Use the terminal menu to navigate through options
