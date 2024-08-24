# PiusFighters
MonkeyRiver hackathon
1. Set Up Angular Frontend
a. Install Angular CLI:
If you haven't installed Angular CLI yet, run the following command:
npm install -g @angular/cli
b. Create a New Angular Project:
You can create a new Angular project by running:
bash
Copy code
ng new my-angular-app
Navigate to the project directory:
cd my-angular-app
c. Install Project Dependencies:
Run the following command to install all required dependencies:
npm install
d. Serve the Angular Application:
To start the Angular development server, run:
ng serve
Open your browser and go to http://localhost:4200 to view the application.
2. Set Up Node.js Backend
a. Install Node.js:
Ensure that Node.js and npm (Node Package Manager) are installed. You can download and install them from the official Node.js website.
b. Initialize a New Node.js Project:
Navigate to your backend directory (or create a new one):
mkdir my-node-backend
cd my-node-backend
Initialize a new Node.js project:
npm init -y
c. Install Backend Dependencies:
You may need packages like express, cors, body-parser, and others. Install them using npm:
npm install express cors body-parser mssql
d. Create the Backend Server:
Create a server.js or app.js file to define your Node.js server and connect it to the SQL database.
Run the Node.js Server:
Run your Node.js server using:
node server.js
3. Set Up SQL Database
a. Install SQL Server:
If you haven't installed SQL Server, you can download and install it from the official Microsoft website.
b. Create a New Database:
Use SQL Server Management Studio (SSMS) to create a new database.
Example SQL command to create a database:
sql
CREATE DATABASE MyDatabase;
c. Create Tables:
Define your database schema by creating tables.
Example SQL command to create a table:
sql
CREATE TABLE Users (
    UserID int PRIMARY KEY,
    UserName varchar(255) NOT NULL,
    PasswordHash varchar(255) NOT NULL
);
4. Integrate C# (Optional)
a. Set Up Visual Studio for C# Development:
Open Visual Studio and create a new C# project (e.g., ASP.NET Core or Console App).
Add a connection to your SQL Server database using Entity Framework or ADO.NET.
b. Install C# Dependencies:
Use NuGet Package Manager to install necessary libraries like EntityFrameworkCore, SqlClient, etc.
c. Build and Run the C# Application:
Build and run your C# application using Visual Studio.
5. Integrate Angular with Node.js Backend
a. Update Angular Service:
In your Angular project, create or update a service to communicate with the Node.js backend.
Run Both Frontend and Backend:
Make sure both the Angular frontend (ng serve) and Node.js backend (node server.js) are running.
6. Final Testing
Ensure that your Angular frontend can successfully communicate with your Node.js backend.
Test the database connection by performing CRUD operations from your application.
7. Version Control (Optional but Recommended)
Use Git for version control:
git init
git add .
git commit -m "Initial commit"
This setup provides a full stack development environment with Angular, Node.js, SQL, and C#
