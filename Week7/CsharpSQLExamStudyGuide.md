# C#/SQL Exam Study Guide

## Git

    1. What is Git? 
    2. What is Gitbash?
    3. How do we create a branch?
    4. How do we clone a repo?
    5. Git add/commit/push and pull.
    6. What does Git allow us to do in a collaborative environment?

## C#/OOP

    1. What are you OOP Fundamentals? (4 Pillars of OOP)
       1. Abstraction - 
       2. Encapsulation - 
       3. Inheritance - 
       4. Polymorphism - 
   
    2. What does the syntax (in our code) look like for...
       1. implementing an interface?
       2. inheriting from a parent class?
       3. Declaring a collection of some specific type? 
    
    3. Exception Handling (Try-Catch-Finally)
    4. Within a class...
       1. What are class members? (fields/methods)
       2. How do we declare a property (using that {get;set;})
       3. What is a constructor? What does it allow us to do?
          1. How/when do we call it? 
    5. Access modifiers (Public vs Private vs Internal)
    6. Control Flow
       1. Our loops
       2. If-elseif-else
       3. Switch
       4. Our different comparison operatos (==, !=, >=, etc)
       5. For loops vs foreach
   
    7. What is an interface?
       1. How are they used?
       2. How do they compare/contrast to a class?
    8. List vs Dictionary?
       1. Both are collections, but how do they differ?
    9.  What does our .csproj contain?
       1.  Meta-data about our project (things like it's name)
       2.  Package references that we brought in via Nuget (things we dotnet add'd)
       3.  Project references to other .csproj files that we want to bundle together, such as with xUnit testing projects

## SQL
    1. SQL Sublanguages (DML, DQL, DDL, DCL*)
       1. Data Query Language - SELECT
       2. Data Definition Language - CREATE, DROP, ALTER, TRUNCATE
       3. Data Manipulation Language - INSERT, UPDATE, DELETE
       4. Data Control Language* - GRANT, REVOKE (These probably *hint* wont come up in the exam)
    2. SELECTs with filters inside  -SELECT WHERE
    3. Basics of Joins
       1. What is a Join?
       2. What do they do/return for us?
       3. Inner vs Outer Join, Left vs Right Joins. 
       4. Null values in a table, and Joins - How do nulls behave within a Join query?
    4. What are the properties of a Primary Key in SQL? (Unique, Not Null)
    5. What is a Foreign Key?

## ADO.NET
    1. What is ADO.NET (at a high level?)
    2. What does it let us do in our projects?
    3. What is a connection string? 
    4. What is the DataReader in ADO.NET
       1. What is it's behavior?
          1. Read only, forward only. 
