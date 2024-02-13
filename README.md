# API with CRUD Operations

This is a sample API built using C# ASP.NET that demonstrates CRUD (Create, Read, Update, Delete) operations on a hypothetical resource.

## Getting Started

To get started with using this API, follow the instructions below.

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- [Visual Studio](https://visualstudio.microsoft.com/) or any text editor of your choice.

### Installation

1. Clone this repository to your local machine:

```sh
git clone https://github.com/guettafa/ASP.NET-API.git
```
2. Go to project dir
```sh
cd ASPAPI
```
3. Build solution
```sh
dotnet build
```
4. Run the application
```sh
dotnet run
```

## Endpoints

| Method | Endpoint                | Description                              |
|--------|-------------------------|------------------------------------------|
| GET    | `/movie/`               | Retrieve all resources.                  |
| GET    | `/movie/{id}`           | Retrieve a specific resource by ID.      |
| POST   | `/movie/`               | Create a new resource.                   |
| PUT    | `/movie/`               | Update an existing resource.             |
| DELETE | `/movie/{id}`           | Delete a resource by ID.                 |
