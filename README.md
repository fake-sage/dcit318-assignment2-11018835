# DCIT 318: Programming II - Assignment 2

## 📌 Overview
This repository contains **three C# console application tasks** demonstrating different aspects of **Object-Oriented Programming (OOP)**:

1. **Inheritance and Method Overriding**
2. **Abstract Classes and Methods**
3. **Interfaces**

Each task is implemented in its own file, and all are called from `Program.cs`.

---

## 📂 Project Structure
Assignment2/
│
├── Program.cs # Entry point - calls each task's Run() method
├── InheritanceDemo.cs # Task 1: Inheritance and Method Overriding
├── AbstractDemo.cs # Task 2: Abstract Classes and Methods
├── InterfaceDemo.cs # Task 3: Interfaces
└── README.md # Project documentation


---

## 📝 Tasks

### **Task 1: Inheritance and Method Overriding**
- **Base class:** `Animal` with method `MakeSound()` printing `"Some generic sound"`.
- **Derived classes:**
  - `Dog` → prints `"Bark"`
  - `Cat` → prints `"Meow"`
- **Demonstrates:** Method overriding using `virtual` and `override` keywords.

---

### **Task 2: Abstract Classes and Methods**
- **Abstract class:** `Shape` with abstract method `GetArea()`.
- **Derived classes:**
  - `Circle` → calculates area using radius.
  - `Rectangle` → calculates area using width and height.
- **Demonstrates:** Abstraction and method implementation in derived classes.

---

### **Task 3: Interfaces**
- **Interface:** `IMovable` with method `Move()`.
- **Implementations:**
  - `Car` → prints `"Car is moving"`.
  - `Bicycle` → prints `"Bicycle is moving"`.
- **Demonstrates:** Interface creation and implementation.

---

## 🚀 How to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/<your-username>/dcit318-assignment2-ID.git
   cd dcit318-assignment2-ID

2. **Run the program**
   ```bash
   dotnet run

3. **Expected Output**
=== Task 1: Inheritance and Method Overriding ===
Some generic sound
Bark
Meow

=== Task 2: Abstract Classes and Methods ===
Circle Area: 78.53981633974483
Rectangle Area: 24

=== Task 3: Interfaces ===
Car is moving
Bicycle is moving
