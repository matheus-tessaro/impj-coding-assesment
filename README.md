# Impinj Coding Assessment API 🚀

Welcome to the **Impinj Coding Assessment API**! This project is a .NET 9 Web API designed to parse a sales record CSV file and provide key statistics about the data. Below, you'll find an overview of the project, its architecture, how caching works, and instructions for running the application.

---

## **Table of Contents** 📚
1. [Overview](#overview-)
2. [Features](#features-)
3. [Architecture](#architecture-)
4. [Caching](#caching-)
5. [Getting Started](#getting-started-)
6. [Running the Application](#running-the-application-)
7. [Testing](#testing-)
8. [API Endpoints](#api-endpoints-)
9. [OpenAPI Specification](#openapi-specification-)
---

## **Overview** 🌟
This API is built as part of a coding assessment for Impinj. It reads a large CSV file (`SalesRecords.csv`) containing 100,000 sales records, processes the data, and returns the following statistics:
- **Median Unit Cost** 📊
- **Most Common Region** 🌍
- **First and Last Order Dates** 📅 (and the number of days between them)
- **Total Revenue** 💰

The API was designed adhering to SOLID principles and best practices.

---

## **Features** ✨
- **CSV Parsing**: Reads and parses a large CSV file using `CsvHelper`.
- **Caching**: Uses `IMemoryCache` to cache parsed data for improved performance.
- **Statistics Calculation**: Computes key statistics from the sales data.
- **RESTful API**: Exposes a single endpoint to retrieve the statistics.
- **Unit Tests**: Includes comprehensive unit tests for all services and the controller.

---

## **Architecture** 🏗️
The project follows a **clean architecture** with clear separation of concerns. Here's a breakdown of the key components:

### **Layers**
1. **Controllers** (`SalesController`):
   - Handles HTTP requests and responses.
   - Depends on `ISalesStatisticsService` to retrieve statistics.

2. **Services**:
   - **`SalesService`**: Reads and parses the CSV file. Implements `ISalesService`.
   - **`SalesStatisticsService`**: Calculates statistics from the parsed data. Implements `ISalesStatisticsService`.

3. **Models**:
   - **`SalesRecordDTO`**: Represents a single sales record from the CSV file.
   - **`StatisticsResponseDTO`**: Contains the calculated statistics.

4. **Dependency Injection**:
   - All services are registered in `Program.cs` and injected into the controller.

---

## **Caching** ⚡
To improve performance, the API uses **in-memory caching** with `IMemoryCache`. Here's how it works:
1. **First Request**:
   - The CSV file is read, parsed, and cached.
   - The parsed data is stored in memory with a sliding expiration of 5 minutes.

2. **Subsequent Requests**:
   - The data is retrieved from the cache, avoiding the need to re-read and parse the file.

---

## **Getting Started** 🛠️
To run this project locally, follow these steps:

### **Prerequisites**
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- Git (optional)

### **Clone the Repository**
```bash
git clone https://github.com/your-username/impinj-coding-assessment.git
cd impinj-coding-assessment
```

**Running the Application** ▶️
------------------------------

1. **Restore Dependencies:**
    ```bash
    dotnet restore
    ```
    
2.  **Run the Application:**
    ```bash
    dotnet run
    ```
    
3.  **Access the API**:
    
    *   Open your browser or a tool like [Postman](https://www.postman.com/).
        
    *   Navigate to https://localhost:5001/api/sales/statistics.
        

**Testing** 🧪
--------------

The project includes unit tests for all services and the controller. To run the tests:

1.  **Run Tests in Visual Studio**:
    *   Open the Test Explorer (Test > Windows > Test Explorer).
    *   Click **Run All**.
        
2.  **Run Tests via CLI:**
    ```bash
    dotnet test
    ```

**API Endpoints** 🌐
--------------------

### **GET ```/api/sales/statistics```**

**Returns the following statistics:**
```json
{
  "mostCommonRegion": "South America",
  "medianUnitCost": 26.0,
  "totalRevenue": 1000.0,
  "orderDateRange": {
    "firstOrderDate": "2020-01-01T00:00:00",
    "lastOrderDate": "2023-01-01T00:00:00",
    "daysInBetween": 1095
  }
}
```

**OpenAPI Specification** 📄
----------------------------

The API is documented using the **OpenAPI Specification**. You can access the OpenAPI specification file at:

🔗 [**OpenAPI Specification**](http://localhost:5001/openapi/v1.json)

This file can be used with tools like [Swagger UI](https://swagger.io/tools/swagger-ui/) or [Scalar](https://github.com/scalar/scalar) to explore and interact with the API.

**License** 📜
--------------

This project is licensed under the MIT License. See the [LICENSE](https://opensource.org/license/mit) file for details.
