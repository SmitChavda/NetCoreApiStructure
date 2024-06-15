# .NetCoreApiStructure

## Project Overview

**.NetCoreApiStructure** is a .NET 6 solution designed to demonstrate a well-structured approach to building a web API using ASP.NET Core. The solution is divided into multiple projects to promote a clean architecture and separation of concerns. The projects included are:

- **NetCoreApi**: The main API project.
- **Services**: Contains the business logic and services.
- **Model**: Contains the domain models.
- **DTO**: Contains the Data Transfer Objects.

## Usage

### 1. NetCoreApi

The **NetCoreApi** project is the entry point of the application. It contains the controllers and handles incoming HTTP requests. It uses the services defined in the **Services** project to perform business logic operations and returns the appropriate responses.

### 2. Services

The **Services** project encapsulates the business logic of the application. This layer communicates with the data layer (repositories) and performs operations such as validation, processing, and manipulation of data before returning results to the API layer.

### 3. Model

The **Model** project contains the domain models which represent the data structure of the application. These models are used across the application and are the core entities in the business logic.

### 4. DTO

The **DTO** (Data Transfer Objects) project contains classes that are used to transfer data between layers of the application. DTOs are particularly useful for defining the shape of data sent over the network and for ensuring a clear separation between the internal model and the external data representation.


## Getting Started

To get started with the **.NetCoreApiStructure** project, follow these steps:

1. **Clone the repository:**
    ```sh
    git clone https://github.com/your-repo/.NetCoreApiStructure.git
    ```

2. **Navigate to the project directory:**
    ```sh
    cd .NetCoreApiStructure
    ```

3. **Restore dependencies and build the solution:**
    ```sh
    dotnet restore
    dotnet build
    ```

4. **Run the API:**
    ```sh
    cd NetCoreApi
    dotnet run
    ```

5. **Access the API:**
    Open your browser and navigate to `https://localhost:7082/swagger/index.html` or use an API client like Postman to interact with the endpoints.

---

Feel free to reach out if you have any questions or need further assistance. Happy coding!
