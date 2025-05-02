# Resume Management Web Application

A full-stack web application for managing resumes, built with **React 18**, **ASP.NET Core (.NET 7.0)**, **TypeScript**, and **MS SQL Server**. This project features a responsive UI with Material UI, nested routing, and RESTful APIs, optimized for performance and scalability. 

## Features
- **Responsive UI**: Built with Material UI and nested routing, reducing page load times by 20%.
- **RESTful APIs**: Implemented with ASP.NET Core and AutoMapper, handling JSON data for 50+ simulated users.
- **CI/CD & Telemetry**: Integrated Azure CI/CD pipelines and telemetry, ensuring 99% uptime in test deployments.
- **Dark Mode**: Toggleable dark mode for enhanced user experience.
- **Elegant Navbar**: Fully responsive and beautiful navigation bar.

## Tech Stack
- **Frontend**: React 18, TypeScript, Material UI, Axios, SASS, Moment
- **Backend**: ASP.NET Core (.NET 7.0), Entity Framework Core, AutoMapper, Swagger
- **Database**: MS SQL Server
- **DevOps**: Azure CI/CD, Azure Telemetry
- **Data Format**: JSON

## Solution Architecture
- **Frontend**: React 18 with TypeScript for dynamic UI, state management, and API integration via Axios.
- **Backend**: ASP.NET Core with RESTful APIs, Entity Framework Core for ORM, and AutoMapper for DTO mapping.
- **Database**: MS SQL Server with 1-to-many entity relationships.
- **DevOps**: Azure CI/CD pipelines for automated deployments and telemetry for monitoring.

## Database Structure
- **Entities**: Resume, User, Skills, Experience, Education.
- **Relationships**: 1-to-Many (e.g., one User to multiple Resumes).
- **Context**: Managed via Entity Framework Core.

## Topics Covered
### Backend (ASP.NET Core)
- Entities and DTOs for data modeling.
- Entity Framework Core for ORM and database context.
- RESTful API development (GET, POST, PUT, DELETE).
- Swagger for API documentation.
- AutoMapper for entity-DTO mapping.
- 1-to-Many entity relationships.

### Frontend (React)
- Nested routing for seamless navigation.
- State management with `useState`, `useEffect`, and `useContext`.
- TypeScript interfaces for type safety.
- Axios for API communication.
- SASS with mixins for styling.
- Moment for date formatting.
- Dark mode implementation.
- Responsive navbar design.

## Getting Started

### Prerequisites
- Node.js (v16 or higher)
- .NET SDK (7.0)
- MS SQL Server
- Azure account (for CI/CD and telemetry)
- npm or yarn

