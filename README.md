# ReactBackEndApi (.NET 8 Web API)

This is the backend API for the full-stack React + .NET 8 demo application.  
It uses **Clean-ish architecture**, **CQRS with MediatR**, **EF Core**, and **SQLite**.  
The purpose of this project is to demonstrate scalable, testable backend architecture and API design.

---

## ✅ Features
- .NET 8 Web API
- CQRS + MediatR (commands/queries separated)
- Entity Framework Core + SQLite
- Database migrations
- Seeded enterprise-style sample data
- RESTful endpoints
- Structured domain and application layers
- CORS enabled for the React frontend

---

## ✅ Prerequisites
Before running the API, install:

| Tool | Version | Download |
|------|---------|----------|
| .NET SDK | 8.x | https://dotnet.microsoft.com/download |
| Visual Studio 2022 | Latest | https://visualstudio.microsoft.com/ |
| SQLite Toolbox (optional) | — | VS → Extensions → Manage Extensions → Search “SQLite/SQL Compact Toolbox” |
| Git | — | https://git-scm.com/ |

One-time setup for HTTPS (required by ASP.NET):
```bash
dotnet dev-certs https --trust
