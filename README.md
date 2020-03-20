**NOTE:** 
 - All back-end code should be written in C#
 - Please consider that code should be **production** quality not POC

**Tech Stacks Requirement:**
You can chose whether finish this task by creating a single-page application or using traditional way, here is some requirements for each of these:

For traditional web application
 - Backend: ASP.NET MVC or ASP.NET MVC Core
 - Frontend: Free to chose libraries or framework you like to use

For single page application
 - ASP.NET WebApi or ASP.NET Core WebApi
 - React (Redux/Mobx) or Angular

For Persistence
 - You can chose whatever you want (File, database etc)

**Description:**

Write a little web application which allow to manage user's data. A single user should have following properties:
 - id
 - username
 - age
 - sex (male/female)

This application contains two screens. In the first screen, we will be able to find all the users in a list integrated with a pagination and searching engine which allow us to search user by username. We will be able to click on the username in order to redirect to the second screen that allow us to view/edit user's detail and a button to add a new user in the first screen. In the second screen, we will be able to add/modify user's properties except id in a form.