# 🚗 Nova – The Smart Ride Companion

**Nova** is a clean and testable ride-sharing simulation backend built with C# and .NET. It mimics the core functionality of real-world platforms like Uber or Lyft, making it a perfect project for learning scalable design, service-oriented architecture, and unit testing with xUnit.

---

## 📌 Features

- 🔍 Driver discovery based on proximity
- 📍 Location tracking via latitude & longitude
- 🚗 Vehicle management (availability, assignment)
- 🧾 Fare calculation based on distance
- 🧑‍🤝‍🧑 Rider-Driver matching logic
- 🧳 Ride history tracking per user
- ✅ Unit-testable services with mocking support

---

## 📁 Project Structure

- **Nova.Core** – Entities (User, Vehicle, Ride, Location), enums, and business models
- **Nova.Services** – Core services like `DriverService`, `RideService`, etc.
- **Nova.Tests** – xUnit test project with Moq for service layer
- **Nova.ConsoleApp** – Console demo to simulate ride bookings

---

## 🚀 Getting Started

1. **Clone the repo**  
   ```bash
   git clone https://github.com/your-username/nova-ride-sharing.git
