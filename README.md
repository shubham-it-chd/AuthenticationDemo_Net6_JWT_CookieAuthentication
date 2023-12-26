Authentication Demo Asp net cofre 8 API with JWT Form Cookie Authentication with Asp net core 8 MVC app

# ASP.NET Core MVC Application with JWT Authentication and Identity

This is a sample ASP.NET Core MVC application demonstrating JWT authentication, ASP.NET Core Identity, and data seeding.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

{
  "ConnectionStrings": {
    "DefaultConnection": "your_database_connection_string"
  },
  "Jwt": {
    "Key": "your_secret_key",
    "Issuer": "your_issuer",
    "Audience": "your_audience"
  }
}

Run the following commands to apply database migrations:
bash
Copy code
dotnet ef migrations add InitialCreate
dotnet ef database update

Run the application:
bash
Copy code
dotnet run


Features
JWT Authentication: The application uses JWT authentication for securing API endpoints.
ASP.NET Core Identity: Identity is used for user management and authentication.
Data Seeding: The application seeds a sample admin user and roles during startup.

Usage
Visit the application at https://localhost:5001.
Use the provided login page to authenticate.
The application includes a sample MVC view that consumes the API and displays the product list
