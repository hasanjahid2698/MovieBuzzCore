# 🎥 Cinema Management System

This repository implements a **Cinema Management System** with a **Clear Architecture** using **ASP.NET Core 9** and **Entity Framework Core**. It supports multiple user roles to manage cinema complexes, handle movie scheduling, and facilitate ticket booking for public viewers.

---

## 🌟 Features
- **Cinema Complex Owners**: Manage multiple locations, halls, schedules, and seat configurations. 🏢🎫  
- **Movie Owners**: Book shows for movies across various halls and cinema complexes. 🎬🕒  
- **Public Viewers**: Browse movies, choose locations and halls, and book tickets seamlessly. 🎟️🍿  

---

## 🛠️ Technology Stack
- **Framework**: ASP.NET Core 9
- **Database**: Entity Framework Core
- **Architecture**: Clear Architecture (ensures maintainability and scalability)

---

## 📂 Project Structure
- **Domain**: Contains core entities and business logic.  
- **Application**: Houses use cases, interfaces, and service abstractions.  
- **Infrastructure**: Implements data access and third-party services.  
- **API**: Exposes endpoints for user interaction and integration.  

---

## 🚀 Getting Started

### 1️⃣ Clone the Repository
```bash
  git clone https://github.com/hasanjahid2698/MovieBuzzCore.git
  cd cinema-management-system
```

### 2️⃣ Restore Dependencies
```bash
  dotnet restore
```

### 3️⃣ Set Up the Database
- Configure the connection string in `appsettings.json`.  
- Apply migrations:
  ```bash
    dotnet ef database update
  ```

### 4️⃣ Run the Application
```bash
  dotnet run
```

### 5️⃣ Access the API
Open your browser and navigate to:  
`http://localhost:5000` (default port)

---

## 🤝 Contribution Guidelines
- Follow **Clear Architecture** principles.  
- Use consistent naming conventions.  
- Submit a pull request for new features or bug fixes.  

---

## 📜 License
This project is licensed under the [MIT License](LICENSE).  

