# Overview

In this project, I am working on laying out a way to track and manage vendors of a startup protein drink company.  Vendors include companies that sell the product and companies that provide some or all of the supplies to make or store the product.  The list can get quite long and difficult to keep straight.

The software I created is protected with registration/login system. Initial registration only gives a user "salesperson" status and limited access.  Manager and Admin are the other two access levels.  I used the Microsoft Identity library in .NET to create the roles and login tables.  The process of creating roles and having them function in a program creates multiple tables that have to interact with each other. Examples of these tables are: user table, user role table, net role table, and a login table (pluse a few that are administrative related to these).  Additionally, I created a Vendor class with full CRUD abilities.  This Vendor class can only be accessed by users that are logged in and access is more limited for the edit and delete categories.  

I wanted to write this software in order to learn and practice creating software with user login and be able to practice limiting control according to the user rank.  The process of writing this software stretched my ablities and created many learning opportunites. 

[Mastery Protein Vendor Management System Demo](https://youtu.be/MfT1TzM_Iec)

# Relational Database

- SQL Local Database

- Identity tables that track login, user role, user information, possible roles.

- Vendor tables: create, edit, details, delete_

# Development Environment

- Visual Studios

- ASP.NET Core 8.0 Razor Pages

- Libraries: Identity, Enitity Framework.

- Languages: C# & HTML


# Useful Websites

- [ASP.NET Core Web App](https://www.youtube.com/watch?v=dyN_LB8nWWM&t=2596s)

- [Tutorial: Create a Razor Pages Web App](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-8.0)

- [.NET on Azure for Beginners](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oVSBX3Lde8owu6dSgZLIXfu)

# Future Work

- Pages are made, but content needs to be added to individual pages for each role. A salesperson page will have access to tools a salesperson will need like vendor leads to pursue. A manager page will have additional tools like scheduling that a manager needs. And an Admin page will be able have access to all and be able to do crud operations on users (adding limitations on who can access registration and further protect the site).  

- Product Views and info should be added that is accessible to anyone who wants to learn more.

- Evenutally placing orders and receiving payment would be great making this a complete ecommerce site.
