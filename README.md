# 🖥️ Shopping List App – Server  
*ASP.NET Core (.NET 8) + Entity Framework Core + SQL Server*

---

## 📌 Overview

This is the **server-side** of the Shopping List application, built using **ASP.NET Core (.NET 8)**.  
It provides a RESTful API for managing categories and saving shopping lists submitted by the client.

The project follows a clean, layered architecture with clear separation of concerns:
- 🔹 **Controllers** – API endpoints  
- 🔹 **Services** – Business logic  
- 🔹 **Repositories** – Data access layer  
- 🔹 **Core** - DTOs and Models– Data structure and mapping  
- 🔹 **DbContext & SeedData** – Database connection and initialization

---

##  Core Features (Assignment Requirements)

This server implements the required features as specified in the assignment:

- RESTful API using **ASP.NET Core (.NET 8)**
- **GET** endpoint for retrieving predefined categories
- **POST** endpoint for receiving and saving shopping lists
- **SQL Server** database with seeded categories
- **Entity Framework Core** for database access and migrations
- **Clean project structure** with Controllers, Services, Repositories, DTOs, and Models
- **Input validation** and appropriate **HTTP responses**

---

## 🚀 Extended Features

The project includes several modern and advanced techniques demonstrating best practices:

- 🧠 **DTO ↔ Model Separation with AutoMapper**  
  All data transformations between domain models and API contracts are handled via AutoMapper profiles, improving maintainability.

- 🛡️ **PostModel Input Layer**  
  Introduced a dedicated PostModel (`ProductPostModel`) for receiving user input, decoupling client input from internal logic.

- 🧩 **Service Abstraction Layer**  
  Business logic is separated into services (`IOrderService`, `ICategoryService`), enabling testing and future scaling.

- 🚦 **Custom Exception Handling**  
  Added `DatabaseException` for improved traceability of data-layer errors during development.

- ⚙️ **Asynchronous Code**  
  All controller methods are fully asynchronous (`async/await`) to ensure scalability and non-blocking I/O.

- 🧹 **Modern, Minimalist C# Style**  
  Uses dependency injection, async patterns, clean controller logic, and modern C# features.

---

## 🗃️ Project Structure
```bash
/server
├── Controllers        # API endpoints
├── Services           # Business logic
├── Repositories       # Data access layer
├── Core               # DTOs and shared models
├── Models             # Domain models
├── Data               # DbContext and SeedData
├── Program.cs         # Entry point
└── appsettings.json   # Configuration
```
---

## 🛠️ Database

- **SQL Server**
- **Entity Framework Core**
- Built-in **migrations**
- **Preloaded categories** on application startup:
  - Cleaning Products  
  - Cheeses  
  - Fruits & Vegetables  
  - Meat & Fish  
  - Baked Goods  

---
## 🧾 Git Workflow

The development of this server project followed a clear and organized Git workflow using feature branches:

- 🛠 Each layer (Controllers, Services, Repositories, etc.) was developed in a **dedicated Git branch**.
- ✅ After implementation and testing, each branch was **merged into the main branch** using proper version control practices.
- 📂 This approach ensures clean separation of features, easier debugging, and a maintainable development process.

## 🚀 Installation & Running

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server (Local or remote)
- Visual Studio or VS Code
- A valid database connection string in `appsettings.json`

# 1. Clone the project from GitHub
git clone https://github.com/Leabenisty/Shopping-List-Server.git

# 2. Navigate to the server directory
cd shopping-list/server

# 3. Restore project dependencies
dotnet restore

# 4. Create the initial migration (if not already created)
dotnet ef migrations add InitialCreate

# 5. Apply the migration to the database
dotnet ef database update

# 6. Run the server
dotnet run
