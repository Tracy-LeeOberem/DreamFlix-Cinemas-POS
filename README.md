# DreamFlix-Cinemas-POS
The DREAMFLIX application is a computerized automated booking system designed for DREAMFLIX Cinema. It streamlines the entire process of booking movie tickets and tracking ticket sales in real time. The system aims to improve the efficiency and accuracy of cinema operations by reducing manual work and minimizing errors. Through this system, users can seamlessly reserve movie seats, and the cinema staff can easily manage customer bookings, view seat availability, and track sales.

## Description:
Developed a POS(point-of-sale) system for a cinema to help employees with day-to-day operations such as movie schedualing, maintaining employees, maintaining movie timeslots as well as maintaining seat bookings. It includes built-in tools for tracking sales, income and employee performance. This project was created as a group assignment and developed using C#.
The system has built in access controls to only allow employees and administrators access to the system. 

## Features:
For administrators:
·	Log into system
<br>
·	Maintenance of movies
<br>
·	Maintain timeslots
<br>
·	Maintain MovieRooms
<br>
·	Maintain RoomSeats
<br>
·	Maintenance of employees  
<br>
·	Request reports
 
For employees:
·	Log into system 
<br>
·	Sell tickets

## Setup Instructions:
------Requirements:------
<br>
·	Have Visual Studio installed
<br>
·	Have SQL Server Management Studio (SSMS) installed
<br>
<br>
------Restore the "MoviesDB.bacpac" file:------
<br>
·	In SSMS connect to your local server instance.
<br>
·	In Object Explorer - right click Databases. 
<br>
      Databases => Import Data-tier Application.
 <br>     
      Choose "Import from Local Disk" and select the "MoviesDB.bacpac" file
<br>
· Follow the prompts and instructions
<br>
<br>
------Configure the project:------
<br>
· In Visual Studio open "CMPG223_Group6_Project.sln"
<br>
· Update the connection string within the project to your connection string created in SSMS.
<br>
· Build and run the project.
<br>
· Test the database connectivity.



