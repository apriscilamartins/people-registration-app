# People Registration Application

This project is a full-stack application for registering people, consisting of a .NET backend and a React frontend.

## Project Structure

```
people-registration-app
├── backend
│   ├── PeopleRegistrationApi.sln
│   ├── PeopleRegistrationApi
│   │   ├── Controllers
│   │   │   └── PeopleController.cs
│   │   ├── Models
│   │   │   └── Person.cs
│   │   ├── Services
│   │   │   └── PersonService.cs
│   │   ├── Program.cs
│   │   ├── Startup.cs
│   │   └── PeopleRegistrationApi.csproj
│   └── README.md
├── frontend
│   ├── public
│   │   └── index.html
│   ├── src
│   │   ├── components
│   │   │   └── RegisterForm.tsx
│   │   ├── App.tsx
│   │   ├── index.tsx
│   │   └── types
│   │       └── Person.ts
│   ├── package.json
│   ├── tsconfig.json
│   └── README.md
└── README.md
```

## Backend

The backend is built using .NET and provides a RESTful API for managing person records. It includes:

- **Controllers**: Handles HTTP requests and responses.
- **Models**: Defines the data structure for person records.
- **Services**: Contains business logic for managing person records.

### Setup Instructions

1. Navigate to the `backend` directory.
2. Open the solution file `PeopleRegistrationApi.sln` in your preferred .NET IDE.
3. Restore the dependencies and run the application.

## Frontend

The frontend is built using React and provides a user interface for registering new persons. It includes:

- **Components**: Contains the UI components, including the registration form.
- **Types**: Defines TypeScript interfaces for type safety.

### Setup Instructions

1. Navigate to the `frontend` directory.
2. Install dependencies using `npm install`.
3. Start the application using `npm start`.

## Usage

Once both the backend and frontend are running, you can access the application in your web browser. The frontend will communicate with the backend API to perform CRUD operations on person records.

## Contributing

Feel free to contribute to this project by submitting issues or pull requests.