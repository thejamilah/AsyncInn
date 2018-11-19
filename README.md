# .NET C# Educational Lab Assignment - The Async Inn

## Intro to Entity Framework
This is an educational assignment that focuses on Intro to Entity Framework by building a database for a sample problem domain of a hotel.</br>

#### Entity Framework
You can read more about Entity Framework on MSDOCS below </br>
https://docs.microsoft.com/en-us/ef/#pivot=entityfmwk&panel=entityfmwk1</br>

#### Entity Framework Turtorial
https://www.c-sharpcorner.com/article/entity-framework-introduction-using-c-sharp-part-one/</br>
https://www.youtube.com/watch?v=ZX7_12fwQLU</br>

#### Entity Framework
Entity Framework is an open source ORM Framework. That means it is an Object-Relational Mapping tool that allows developers alike the ability to work with data using objects. Simply put, it allows developers to work at a higher level of database implementation an management without most (not all) of the data-access. The Entity Framework fits in right before the Database and the beauty is that it is cross platform. It doesn't stop there, there's modelling, Querying, Change Tracking, Saving, Concurrency, Transactions, Caching, Built-in Conventions, Configurations and Migrations...it's pretty powerful stuff which leads to the next topic.

#### Data Seeding
Simple terms Data Seeing is the initial set of data sent to the database when it is installed/instantiated. The initiation is in the Models directory then Data directory.


### Assignment Instructions
_Startup File_
* Explicit routing of MVC
* MVC dependency in ConfigureServices
* DBContext registered in ConfigureServices
* Use of static files accepted

_Controller_
* Home Controller
* Controllers for each of the pages described in the Design section (you do not have to scaffold if you don’t want to)

_Data_
* DBContext present and properly configured
* DB Tables for each entity model (DbSet<T>)
* Composite key association present in OnModelCreating override.
* appsettings.json file present with name of database updated

_Models_
* Each Entity from the DB Table converted into a Model
* Proper naming conventions of Primary keys, or utilization of the [Key] data annotation
* Navigation properties present in each Model where required
* Enum present in appropriate model

_Views_
* View for home page that matches default routing

_Home Page_
* stylesheet present in web application
* stylesheet referenced on home page.
* Web application should build, compile, and redirect us to the home page upon launch. If you decided to scaffold the controllers, they should be accessible through their default actions

### Visual
_Database Schema Visual Design(Created by @Aiverson1011)_ 
![asyncinndbschema](https://user-images.githubusercontent.com/39015829/47542663-425d4100-d893-11e8-97ec-e747d1ef239f.jpg)
