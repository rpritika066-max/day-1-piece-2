\# Day 1 — Legacy OrderController Refactor



This exercise refactors a deliberately problematic legacy ASP.NET Core OrderController.



\## Original



The `original/` directory contains:



\- `OrderController.cs` — the preserved legacy implementation

\- `INITIAL\_PROMPT.md` — the prompt used to generate the legacy code



\## Refactor



The `refactored/LegacyShop.Api/` project separates responsibilities into:



\- Controller

\- Service

\- Repository

\- DTOs

\- EF Core data access

\- Exception middleware



The refactor also introduces asynchronous EF Core operations, cancellation-token propagation, typed responses, and focused exception handling.



\## Tests



The `tests/LegacyShop.Api.Tests/` project contains:



\- 3 unit tests

\- 1 integration test using `WebApplicationFactory`



Run locally with:



```powershell

dotnet test .\\tests\\LegacyShop.Api.Tests\\LegacyShop.Api.Tests.csproj

