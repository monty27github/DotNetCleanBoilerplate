# 🚀 .NET 9 Clean Architecture Boilerplate

A production-ready ASP.NET Core Web API boilerplate built with **.NET 9** using **Clean Architecture principles**.

This solution is designed to help developers start building features immediately without wasting time setting up project structure, dependency injection, Swagger, database configuration, and repository/service patterns.

---

# 🏗 Architecture Overview

The solution follows Clean Architecture with strict separation of concerns.

## Project Structure

Solution
│
├── API              → Presentation Layer (Controllers, Swagger, Middleware)
├── Application      → Business Logic (Services, DTOs, Interfaces)
├── Domain           → Core Entities & Business Rules
├── Infrastructure   → Database, Repositories, External Services


---

# 🥇 Golden Rule (Most Important)

Dependency must always flow inward.

Allowed reference direction:

API → Application → Domain  
API → Infrastructure  
Infrastructure → Domain  

Not allowed:

- Domain referencing Infrastructure
- Domain referencing Application
- Application referencing API

## Project Reference Rules

| Project        | Can Reference                |
|---------------|------------------------------|
| API           | Application, Infrastructure  |
| Application   | Domain                       |
| Infrastructure| Domain                       |
| Domain        | None                         |

This ensures business logic remains independent, testable, and maintainable.

---

# 🔥 Features Included

## ✅ .NET 9 Web API
Built using latest minimal hosting model.

## ✅ Swagger UI Integration
Interactive API documentation using Swashbuckle.

Available at:
https://localhost:{port}/swagger

## ✅ Database Ready Setup
- Pre-configured DbContext
- Connection string via appsettings.json
- Repository pattern implemented
- Dependency Injection configured

Example connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=YourDb;Trusted_Connection=True;"
}
