# Inventory System Windows Form

A Windows Forms application for managing inventory built with .NET 8.0 and Entity Framework Core.

## Description

This is a desktop application that provides a user-friendly interface for managing inventory items. The application is built using Windows Forms and follows a structured architecture with separate layers for data access, business logic, and presentation.

## Features

- User-friendly Windows Forms interface
- Database integration using Entity Framework Core
- SQL Server database support
- MVC architecture pattern
- Inventory management capabilities

## Prerequisites

- .NET 8.0 SDK or later
- SQL Server (Local or Remote)
- Visual Studio 2022 or later (recommended)

## Project Structure

```
Inventory/
├── controller/     # Business logic and controllers
├── veiw/          # Windows Forms UI components
├── Data/          # Data access layer and database context
├── Migrations/    # Entity Framework Core migrations
└── Properties/    # Application properties and resources
```

## Dependencies

- Microsoft.EntityFrameworkCore (9.0.5)
- Microsoft.EntityFrameworkCore.Design (9.0.5)
- Microsoft.EntityFrameworkCore.SqlServer (9.0.5)
- Microsoft.EntityFrameworkCore.Tools (9.0.5)

## Getting Started

1. Clone the repository
2. Open the solution in Visual Studio
3. Update the database connection string in the application configuration
4. Run the Entity Framework migrations:
   ```bash
   # Open Package Manager Console in Visual Studio
   # Then run the following commands:
   Add-Migration InitialCreate
   Update-Database
   ```
   Or using .NET CLI:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
5. Build and run the application

## Building the Project

```bash
dotnet build
```

## Running the Application

```bash
dotnet run
```

## License

This project is licensed under the terms included in the LICENSE.txt file.
