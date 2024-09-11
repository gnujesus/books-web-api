# Books Web API

A simple Books Web API built with ASP.NET 8 and following the principles of Onion Architecture. This API allows users to perform CRUD (Create, Read, Update, Delete) operations on books and includes an endpoint to get specific pages of a book by its ID and page number.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Project Structure](#project-structure)
- [How to Contribute](#how-to-contribute)
- [Coming Soon](#coming-soon)
- [License](#license)

## Features

- **CRUD Operations**: Create, read, update, and delete books.
- **Pagination by Page Number**: Retrieve specific pages of a book by book ID and page number.
- **Onion Architecture**: Organized codebase that separates concerns and encourages maintainability.

## Technologies Used

- **ASP.NET 8**
- **C#**
- **Onion Architecture**

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/books-web-api.git
   ```

2. **Navigate to the project directory**:
    ```bash
    cd books-web-api
    ```

3. **Install dependencies**:
   ```bash
   dotnet restore
   ```

4. **Build the project**:
   ```bash
   dotnet build
   ```

5. **Run the project**:
   ```bash
   dotnet run
   ```

After running the project, the API will be available at `http://localhost:5000`. You can use tools like **Postman** or **cURL** to interact with the API. Make sure to configure any additional settings as required for your development environment.

## Usage

Once the API is running, use the following endpoints to interact with the Books Web API.

## API Endpoints

| Method | Endpoint                               | Description                                                |
|--------|-----------------------------------------|------------------------------------------------------------|
| GET    | `/api/books`                            | Retrieves all books                                        |
| GET    | `/api/books/{id}`                       | Retrieves a book by its ID                                 |
| POST   | `/api/books`                            | Adds a new book                                            |
| PUT    | `/api/books/{id}`                       | Updates a book by its ID                                   |
| DELETE | `/api/books/{id}`                       | Deletes a book by its ID                                   |
| GET    | `/api/books/{bookId}/{pageNumber}`      | Retrieves a specific page of a book by book ID and page number |

## Project Structure

The project follows the Onion Architecture, which organizes code into distinct layers:

- **Core**: Contains business logic and domain entities.
- **Infrastructure**: Handles data access, repositories, and external services.
- **Application**: Contains application logic, including services, DTOs, and interfaces.
- **Presentation**: The Web API layer, responsible for exposing endpoints and handling requests.

## How to Contribute

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.

## Coming Soon

- **Frontend**: A modern frontend built with React or Angular to consume the API.
- **Validations**: Input validation and error handling to ensure data integrity.
- **JSON Web Token (JWT)**: Authentication and authorization using JWT to secure the API endpoints.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.





