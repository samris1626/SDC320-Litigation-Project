# Legal Case Management System

## Overview

The **Legal Case Management System** is a C# console application designed to help users track and manage lawsuit-related information. It provides structured management of claimants, businesses, and legal cases, demonstrating solid object-oriented design and practical database interaction using SQLite.

This project was built with portfolio presentation in mind and emphasizes clean code organization, CRUD operations, and clear separation of concerns.

## Features

* Add, view, update, and delete claimants
* Add, view, update, and delete businesses
* Add, view, update, and delete legal cases
* Console-based menu navigation
* Object-oriented class design
* SQLite database integration

## Data Model

### Claimants

* ClaimantID
* FirstName
* LastName
* PhoneNumber
* Email
* BusinessID (links claimant to a business)

### Businesses

* BusinessID
* BusinessName
* ContactPhone
* Address

### Cases

* CaseID
* CaseName
* CaseDescription
* ClaimantID
* BusinessID

## Relationships

* A claimant belongs to one business
* A business can have many cases
* A claimant can be associated with multiple cases

## Project Structure

* **Claimant.cs** – Claimant data model
* **Business.cs** – Business data model
* **CaseRecord.cs** – Legal case model
* **Address.cs** – Address data model
* **Person.cs** – Base person model
* **DatabaseManager.cs** – SQLite database initialization and CRUD logic
* **MenuManager.cs** – Console menu and user interaction
* **Program.cs** – Application entry point

## How to Run

1. Clone the repository
2. Open the project in Visual Studio or VS Code
3. Restore dependencies if prompted
4. Run using `dotnet run`
5. Use the terminal menus to manage records

## Demo Video

A short demonstration video showcasing the application features and code structure is available here:

👉 **YouTube Demo:** *(link goes here)*

---

## Project Summary

The Legal Case Management System is a console-based C# application that demonstrates core software development principles including object-oriented programming, database persistence, and user-driven workflows. The project allows users to manage interconnected legal data through a structured menu system backed by an SQLite database. It highlights practical CRUD operations, clear separation of responsibilities across classes, and a scalable foundation suitable for future enhancements such as reporting, validation, or a graphical user interface.
