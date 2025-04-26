# ComputerShop Backend – ASP.NET Core

## Opis projektu
Backend aplikacji ComputerShop, stworzony w technologii ASP.NET Core 6.  
Obsługuje operacje na użytkownikach, produktach, zamówieniach i rezerwacjach.

## Technologie
- ASP.NET Core 6
- Entity Framework Core
- SQLite
- REST API
- Dependency Injection
- Asynchroniczne operacje

## Struktura projektu
- `Models/` – modele danych (Product, User, Order, Reservation)
- `Controllers/` – kontrolery API
- `Services/` – interfejsy i implementacje logiki biznesowej
- `Data/ApplicationDbContext.cs` – kontekst bazy danych
- `appsettings.json` – konfiguracja połączenia z bazą SQLite

## Jak uruchomić backend

### 1. Przygotowanie środowiska
- Wymagane: Visual Studio 2022 lub Visual Studio Code + .NET 6 SDK
- Upewnij się, że masz zainstalowany EF Core Tools (`dotnet tool install --global dotnet-ef`)

### 2. Krok po kroku:

```bash
# Wejdź do folderu projektu backend
cd backend

# Przywróć zależności
dotnet restore

# (Opcjonalnie) Wygeneruj bazę danych SQLite:
dotnet ef migrations add InitialCreate
dotnet ef database update

# Uruchom aplikację
dotnet run
