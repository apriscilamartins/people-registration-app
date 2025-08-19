# Frontend Application for People Registration

This is the frontend application for the People Registration project, built using React and TypeScript. It provides a user interface for registering new individuals and interacting with the backend API.

## Getting Started

To get started with the frontend application, follow these steps:

1. **Clone the Repository**
   ```bash
   git clone <repository-url>
   cd people-registration-app/frontend
   ```

2. **Install Dependencies**
   Make sure you have Node.js installed. Then, run the following command to install the necessary dependencies:
   ```bash
   npm install
   ```

3. **Run the Application**
   Start the development server with:
   ```bash
   npm start
   ```
   The application will be available at `http://localhost:3000`.

## Folder Structure

- `public/`: Contains the static files, including `index.html`.
- `src/`: Contains the source code for the React application.
  - `components/`: Contains React components, including `RegisterForm.tsx`.
  - `types/`: Contains TypeScript type definitions, including `Person.ts`.
  - `App.tsx`: The main application component.
  - `index.tsx`: The entry point for the React application.

## Features

- User-friendly form for registering a new person.
- Validations for required fields and email format.
- Integration with the backend API for creating and managing person records.

## Contributing

Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.