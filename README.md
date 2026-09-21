# School Management Transparency

A desktop school management and financial transparency application built with **C#**, **Windows Forms**, **.NET Framework 4.8**, and **MySQL**.

The application provides role-based workflows for administrators, student-body officers, and students. It combines student and enrollment management with income, expense, fund, and transaction tracking in a single desktop application.

## Features

- Role-based authentication for:
  - Administrators
  - Student-body officers (SBO)
  - Students
- Student account registration and course enrollment
- Student profile and account management
- Course and enrollment management
- Teacher management
- Student violation and violation-type management
- Financial transparency tools, including:
  - Income transactions
  - Expense transactions
  - Fund categories
  - Fund balances and financial reports
  - Transaction types
- Student views for:
  - Dashboard/home information
  - Financial history
  - Outstanding debts
- Reusable WinForms user controls and role-specific dashboards
- MySQL-backed data access organized through controllers, services, DAOs, and models

## Technology Stack

- **Language:** C#
- **UI:** Windows Forms
- **Framework:** .NET Framework 4.8
- **Database:** MySQL
- **IDE:** Visual Studio 2019 or later recommended
- **UI libraries:** Guna.UI2.WinForms and CuoreUI.Winforms
- **Data and utilities:** MySql.Data, Newtonsoft.Json, Google.Protobuf, BouncyCastle.Cryptography, and related NuGet dependencies

## Project Structure

```text
.
├── Program.cs                         # Application entry point
├── App.config                         # .NET runtime and binding configuration
├── packages.config                    # NuGet package references
├── School_Management_Transparency.csproj
└── SchoolManagementTransparencyApp/
    ├── Controller/                    # Application and feature controllers
    ├── Dao/                           # Database access objects
    ├── Model/                         # Domain models
    ├── Service/                       # Business and application services
    ├── Util/                          # Database connection, validation, and session utilities
    ├── REUSABLE_UC/                   # Shared user controls
    ├── STUDENT_UC/                    # Student-specific user controls
    └── Winforms/                      # Login and role-specific forms
```

## Requirements

- Windows 10 or later
- Visual Studio with .NET desktop development tools
- .NET Framework 4.8 Developer Pack
- MySQL Server 8.0 or compatible version
- A configured `school_db` database and its required tables

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/JunRomuloJarina/School_Management_Transparency.git
cd School_Management_Transparency
```

### 2. Configure MySQL

Create a MySQL database named `school_db`, then import or create the schema required by the DAO and model classes.

Before running the application, configure the database connection in `SchoolManagementTransparencyApp/Util/DatabaseConnection.cs` or, preferably, move the connection string to a secure configuration mechanism:

```text
Server=localhost;Port=3306;Database=school_db;User ID=<your-user>;Password=<your-password>;
```

Do not commit real database passwords or production credentials to source control.

### 3. Restore dependencies

Open the solution in Visual Studio and restore the packages listed in `packages.config`. If needed, use **Tools → NuGet Package Manager → Restore NuGet Packages**.

### 4. Build and run

1. Open `School_Management_Transparency.slnx` or `School_Management_Transparency.csproj` in Visual Studio.
2. Select `Debug` and `Any CPU`.
3. Build the solution.
4. Start the application with **F5** or **Ctrl+F5**.

The application starts at the login form.

## Application Flow

1. Users sign in through the login form.
2. The application retrieves the user role and initializes the current user session.
3. Users are routed to the appropriate dashboard:
   - `AdminForm` for administrators
   - `SboForm` for student-body officers
   - `StudentForm` for students
4. Newly registered students can be linked to a selected course during registration.

## Architecture

The project follows a layered desktop application structure:

- **Winforms:** Presentation forms and user controls
- **Controllers:** Coordinate UI actions and application workflows
- **Services:** Encapsulate business operations
- **DAOs:** Execute database queries and persistence operations
- **Models:** Represent students, courses, enrollments, users, violations, and financial records
- **Utilities:** Provide database connectivity, input validation, and session state

## Security Notes

- Store database credentials outside source code and use a least-privileged MySQL account.
- Never commit passwords, API keys, or other secrets.
- Use parameterized queries for all database operations.
- Review and rotate any credentials that may previously have been committed to the repository.
- Consider hashing passwords with a modern password-hashing algorithm rather than storing or comparing plain-text passwords.

## Troubleshooting

### The application cannot connect to MySQL

Check that:

- MySQL Server is running.
- The host, port, database name, username, and password are correct.
- The `school_db` schema and required tables exist.
- The current user has permission to access the database.

### NuGet assemblies are missing

Restore the packages from `packages.config`, then clean and rebuild the solution. If the issue persists, delete the `bin` and `obj` folders and rebuild.

### The application opens but login fails

Verify that the database contains valid user records and that the configured role values match the roles expected by the application: `ADMIN`, `SBO`, or `STUDENT`.

## Contributing

1. Fork the repository.
2. Create a feature branch:

   ```bash
   git checkout -b feature/your-feature
   ```

3. Make and test your changes.
4. Commit your work with a descriptive message.
5. Open a pull request.

## License

No license has been specified for this repository. Unless a license is added, the repository's contents should be treated as **all rights reserved**.

## Author

[JunRomuloJarina](https://github.com/JunRomuloJarina)
