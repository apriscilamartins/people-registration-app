# People Registration API

This is the backend API for the People Registration application, built using .NET. It provides a RESTful interface for managing person records.

## Project Structure

- **PeopleRegistrationApi.sln**: Solution file that organizes the project and its dependencies.
- **Controllers/PeopleController.cs**: Contains methods for handling HTTP requests related to person records (Create, Update, Delete, Get).
- **Models/Person.cs**: Defines the properties of a person record, including validation rules.
- **Services/PersonService.cs**: Contains business logic for managing person records.
- **Program.cs**: Entry point of the application, configuring and running the web host.
- **Startup.cs**: Configures services and the app's request pipeline.

## Setup Instructions

1. **Clone the repository**:
   ```
   git clone <repository-url>
   cd people-registration-app/backend
   ```

2. **Restore dependencies**:
   ```
   dotnet restore
   ```

3. **Run the application**:
   ```
   dotnet run
   ```

The API will be available at `http://localhost:5000`.

## Usage

### Endpoints

- **POST /api/people**: Create a new person record.
- **PUT /api/people/{id}**: Update an existing person record.
- **DELETE /api/people/{id}**: Delete a person record.
- **GET /api/people**: Retrieve all person records.
- **GET /api/people/{id}**: Retrieve a specific person record by ID.

### Data Model

The `Person` model includes the following properties:

- **Name**: Required
- **Gender**: Optional
- **Email**: Optional, validated
- **DateOfBirth**: Required, validated
- **Nationality**: Optional
- **CPF**: Required, validated for format and uniqueness
- **CreatedAt**: Timestamp of record creation
- **UpdatedAt**: Timestamp of last update

## Contributing

Contributions are welcome! Please submit a pull request or open an issue for any suggestions or improvements.