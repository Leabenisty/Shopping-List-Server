🖥️ Server – Shopping List Application
📌 Overview
The server side is built with ASP.NET Core (.NET 8) and provides an API for managing predefined categories and saving shopping lists. The system is based on Entity Framework Core using a SQL Server database and follows a clean, modular architecture with clear separation of concerns.

🧩 Key Features
✅ Category Retrieval API – fetches predefined categories from the database.
✅ Shopping List Saving API – receives shopping data from the client and stores it.
✅ Uses Entity Framework Core with full migration support.
✅ Clean project structure including:

Controllers – API endpoints

Services – business logic

Repositories – database access

DTOs and Models – data mapping

DbContext and SeedData – for initializing categories

✅ Input validation on the server side.
✅ Error handling with clear responses to the client.

📂 Project Structure
/server
 ├── Controllers
 ├── Models
 ├── DTOs
 ├── Services
 ├── Repositories
 ├── Data (DbContext + SeedData)
 ├── Program.cs
 └── appsettings.json
🛠️ Database
SQL Server

Entity Framework Core

Built-in migrations

📌 Preloaded categories on server startup:

Cleaning Products

Cheeses

Fruits & Vegetables

Meat & Fish

Baked Goods

🚀 Installation & Running
✅ Prerequisites
.NET 8 SDK

SQL Server

Visual Studio / VS Code

Database connection string

🧪 Steps to Run
bash
Copy
Edit
# Step 1 – Navigate to the server directory
cd server

# Step 2 – Restore dependencies
dotnet restore

# Step 3 – Apply database migrations
dotnet ef database update

# Step 4 – Run the server
dotnet run
🔗 Git Instructions
git clone https://github.com/yourusername/shopping-list.git
cd shopping-list/server
