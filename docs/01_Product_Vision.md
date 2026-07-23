# NineLives.API — Product Vision

> **Version:** 1.0 (Minimum Viable Product)  
> **Project Type:** ASP.NET Core Web API

---

# 1. Product Overview

| Field			| Value							|
|---------------|-------------------------------|
| Product Name	| NineLives.API					|
| Project Type	| ASP.NET Core Web API			|
| Version		| 1.0 (Minimum Viable Product)	|

---

# 2. Vision Statement / Background

Independent cat rescuers and small foster caregivers often manage rescued cat information using notebooks, spreadsheets, messaging apps, or memory. As the number of rescued cats grows, it becomes increasingly difficult to track:

- Rescue history
- Health condition
- Vaccination status
- Current progress

**NineLives.API** aims to provide a simple, centralized backend system that helps rescuers organize rescued cat information efficiently.

---

# 3. Problem Statement

Managing rescued cats without a centralized system can result in:

- Incomplete records
- Duplicate information
- Difficulty tracking each rescue journey

The goal is to provide a lightweight system that is easy to maintain while offering quick access to essential information.

---

# 4. Target Users

| User						| Goals																					|
|---------------------------|---------------------------------------------------------------------------------------|
| Independent Cat Rescuer	| Register rescued cats, record rescue details, update rescue status, maintain records	|
| Foster Caregiver			| View cat information, update health notes, monitor progress							|

> Version 1 is implemented as a **RESTful Web API** without a graphical user interface.

---

# 5. Project Objective

Develop a lightweight RESTful Web API that enables rescuers and foster caregivers to manage rescued cats through a centralized system.

The MVP focuses on:

- CRUD operations
- ASP.NET Core
- Entity Framework Core
- SQL Server
- Git
- Unit Testing
- CI/CD

---

# 6. MVP Features

## Core Functions

- Register a rescued cat
- View all rescued cats
- View rescued cat details
- Update rescued cat information
- Delete rescued cat

## Cat Information

- Name
- Estimated Age
- Gender
- Breed
- Rescue Date
- Rescue Location
- Current Status
- Vaccination Status
- Health Notes

---

# 7. Out of Scope (Version 1)

- User Login / Authentication
- Role-Based Authorization
- Adoption Management
- Medical History Timeline
- Appointment Scheduling
- Vaccination Reminder Notifications
- Photo Upload
- Reporting Dashboard
- Mobile Application
- Email Notifications
- Multi-organization Support

---

# 8. Future Vision

Future releases may include:

- JWT Authentication
- Rescue Organization Management
- Adoption Workflow
- Foster Home Management
- Vaccination Reminders
- Medical Treatment Records
- Photo Management
- Dashboard & Reporting
- Public Adoption Listings
- Azure Cloud Deployment

---

# 9. Success Metrics

Version 1 is successful when it:

- Performs CRUD operations successfully
- Uses SQL Server for persistence
- Implements layered architecture (Controller → Service → Data Access)
- Includes validation and error handling
- Has unit tests
- Uses Git with meaningful commits
- Includes GitHub Actions CI/CD
- Is documented and deployable

---

# 10. Technology Stack

| Component			| Technology					|
|-------------------|-------------------------------|
| Backend			| ASP.NET Core Web API			|
| Language			| C#							|
| ORM				| Entity Framework Core			|
| Database			| Microsoft SQL Server			|
| API Testing		| Swagger (OpenAPI)				|
| Version Control	| Git & GitHub					|
| Unit Testing		| xUnit							|
| CI/CD				| GitHub Actions				|
| Deployment		| Azure App Service (Planned)	|
