# Admin-Dashboard

A web application built with Next.js (frontend) and .NET API (backend).

## Tech Stack

### Frontend

- **Framework:** Next.js
- **Language:** TypeScript
- **State Management:** React Context API (Not Yet Implemented)
- **Styling:** Tailwind CSS
- **API Calls:** Fetch

### Backend

- **Framework:** .NET API (ASP.NET Core)
- **Language:** C#
- **Database:** SQL Server
- **ORM:** Entity Framework Core
- **Authentication:** JWT (Not Yet Implemented)

## Setup Instructions

### Prerequisites

Ensure you have the following installed:

- Node.js (latest LTS version)
- .NET SDK (version used in the project)
- Database SQL Server

### Running the Frontend

1. Navigate to the Front-End directory:
   ```sh
   cd Front-End
   ```
2. Install dependencies:
   ```sh
   npm install
   ```
3. Start the development server:
   ```sh
   npm run dev
   ```
4. Open `http://localhost:3000` in your browser.

### Running the Backend

1. Navigate to the backend directory:
   ```sh
   cd DashboardAPI
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Run database migrations (if applicable):
   ```sh
   dotnet ef database update
   ```
4. Start the API server:
   ```sh
   dotnet run
   ```
5. The API will be available at `http://localhost:5000` (or the configured port).

## API Endpoints

| Method | Endpoint             | Description       |
| ------ | ---------------------| ----------------- |
| GET    | `/api/Students`      | Gets all students |
| POST   | `/api/Students`      | Post a student    |
| PUT    | `/api/Students/{id}` | Update a student  |
| DELETE | `/api/Students/{id}` | Delete a student  |

## Environment Variables

Create a `.env.local` file in the frontend directory with:

```
NEXT_PUBLIC_API_URL=http://localhost:5000
```

Create an `.env` file in the backend directory with:

```
CONNECTION_STRING=your-database-connection-string
```

## Future Improvements

- authentication methods
- Advanced error handling
- Unit and integration testing


