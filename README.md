<h1 align="center">CRM Blazor WASM 📈💻⚡ </h1>

<p align = center>
by <a href="https://github.com/Cecilia-Coutinho">Cecilia Coutinho</a>
</p>

## 🌍 Overview

This project is a simplified Customer Relationship Management (CRM) system designed specifically for small businesses. The goal was to create a streamlined and user-friendly application, without the complexities often associated with larger CRM solutions. This project demonstrates the feasibility of a simplified CRM tool, designed to be efficiently managed and implemented by individual developers.

## 🚀 MVP Features

✅ User Authentication: Implementation of user authentication via Identity.

✅ Intuitive Navigation: Integration of an intuitive and user-friendly navigation.

✅ Customer Management: Enable creation and management of customers.

✅ Company Management: Enable creation and management of companies.

✅ Contact Management: Enable creation and management of contacts.

✅ Deal Tracking: Enable creation and management of deals, including assigning them to customers, tracking deal status, value, and priorities.

✅ Lead Management: Capture and track leads, including lead source, contact information, and status in the sales pipeline.

✅ Activity Tracking: Log activities such as calls, meetings, and emails related to customers, deals, and leads.

✅ Priority Management: Provision of priority levels for deals and leads.


## 💻 Technology Stack

* C#

* .NET 8 

* ASP.NET Web API

* Blazor WebAssembly

* SQL Server Management Studio (SSMS)

* Entity Framework

* Visual Studio

* GitHub


## 📋 Additional Information


### SQL Design

The SQL design follows a relational database model, with tables representing entities such as Users, Customers, Companies, Contacts, Deals, Leads, Activities, DealsStatus, Priorities and ActivitiesType. These tables handle tasks such as user authentication, customer information, company details, contact records, deal tracking, lead management, activity logging, deal status tracking, priority management, and activity categorization. Relationships are established using foreign keys to maintain data integrity.

![ER Model](/FlowCRM/FlowCRM/wwwroot/images/Db-Diagram.png)


### Code Structure

This project is set up to work as a Single Page Application (SPA) using ASP.NET on the server side and Blazor on the client side. The structure keeps the code organized and makes it easier to work on different parts of the project.

On the server side, tasks involve managing user accounts, handling SQL data, and processing client requests. The logic revolves around nine main controllers (Customers, Companies, Contacts, Deals, Leads, Activities, DealsStatus, Priorities, and ActivitiesType). Specific folders manage database context, repository patterns, data, and Action Filters. Meanwhile, the client side focuses on creating the user interface and communicating with the server. Additionally, a shared library serves both sides, managing functionalities like entities and interfaces.

### User Authentication

User authentication is implemented using Identity feature within .NET 8. Future improvements could include adding roles and permissions to manage user access levels and restrict certain functionalities based on user roles. For now this feature is not implemented.

### Repository Pattern

The repository pattern is implemented to manage data access and abstract the data source for separation of concerns. The implementation includes interfaces for each repository that handles common CRUD operations. 

### Action Filters

Action filters are implemented to perform additional logic before or after an action method is executed. This allows for common logic to be applied across multiple controllers and action methods. The implementation needs to be refactored to improve functionalities and make it more robust.

### Components

This project has components that are reusable pieces of code that can be shared across different parts of the application. They help to keep the code organized and make it easier to maintain and update the application. Refactoring is still needed to improve and use components that can help to reduce code duplication and improve the overall structure of the application.

Both the server and client sides have components that are used to display data, handle user input, and interact with the application. These components are organized into folders based on their functionality and purpose.

### Validation

Validation is implemented to prevent invalid data from being stored in the database. The validation model is implemented using Data Annotations and are used to define validation rules directly in the model class. The implementation includes validation rules for required fields and can be improved to use data.

The validation model needs to be refactored for improvements.

### Future Improvements

#### User Access Control:

    🌟 Implement roles and permissions.

    🌟 Restrict functionalities based on user roles.

    🌟 Ensure authorized access to specific parts of the application.

#### Authorization Rules:

    🌟 Enhance AuthorizeView with roles and permissions.

    🌟 Implement ‘Authorize’ attribute with claims in API controllers.

#### New features:

    🌟 Ability to upload files

    🌟 Calendar integration

    🌟 Send emails

    🌟 Support case management 

    🌟 Integration with other services

#### UI/UX Improvements:

    🌟 Improve the layout and design of the application.

### Conclusion

In conclusion, this project uses Blazor WASM to create an interactive Single Page Application (SPA). The design incorporates distinct server-side controllers, a repository pattern implementation, and shared components, ensuring efficient data handling and an engaging user experience.

 There are areas for potential improvements and a refactoring of the codebase is needed to enhance functionalities and make the application more robust. The current implementation demonstrates basic functionalities for a simplified CRM system.

