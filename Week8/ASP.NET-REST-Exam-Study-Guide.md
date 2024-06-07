# C#/SQL Exam Study Guide

## ASP.NET

1. What is ASP.NET?
    - An open source web framework, created by microsoft, to let us make web apps using .NET. We specifically, are using
        it to create web apis.
2. Structure of a URL
    - <https://www.geeksforgeeks.org/components-of-a-url/>
    - Our URL is made up of seperate sections. For example, lets use this sample url from the above article.
    - <https://www.example.co.uk/blog/article/search?docid=720&hl=en>
    - The first section, with the "https://" is the scheme, this denotes which protocol use. Most modern sites will use https.
    - The next section is the domain "www.example.co.uk" - the site that we are accessing.
    - Next we have a path, "/blog/article/search" that tells the browser where to send our HTTP request.
    - The "?" is the query string separator, everything after this is would be a search parameter.
    - Finally, we have the query string, "docid=720&hl=en".
3. What does ASP.NET give us?
    - Model binding/JSON serialization happening under the hood
      - We are converting things like JSON text and query parameters into objects that we can work with in our code. And ASP.NET does this for us automatically.
    - ASP.NET handles our dependency injection, as long as we register our different dependencies inside the Program.cs.
    - Gives us access to a starting template for our program, that makes it easy to then add our layers to.
    - It handles routing our HTTP request from something sent to a specific URL down to our actual controller methods written in C#.
4. What is middleware? (Not specifically on the exam, but nice to know.)
    - Middleware is a pipeline of different softwares that handles our incoming requests. We've been using it under the hood the entire time. It is set up using Program.cs. It allows different sets of software to interact with our request after it hits our API.
    - We can include middleware in our Program.cs using the app object. For example, app.UseCORS().

## REST

1. What kinds of return data can we get inside of an HTTP response? (hint: besides JSON!)
    - We can get 
      - JSON 
      - plain text (this is not really done anymore)
      - XML (microsoft JSON competitor, not really used much for web development anymore)
2. What does an HTTP method being idempotent mean?
   - A method being IDEMPOTENT means that the result of one request and the result of many repeated requests will be the same. 
     - For example, if I have a user named "Ross", and I send a DELETE request to delete the "Ross" user, one request vs many behaves the same.
    - Which methods are idempotent? Which aren't?
      - GET, PUT, DELETE are idempotent
      - POST and PATCH are not idempotent
3. What does our API being "stateless" mean?
   1. We are not saving some sort of record of previous HTTP requests that were sent to our server
   2. Every request may as well the first request ever sent. 
4. PUT vs PATCH - Both can be used to update, but what is the difference?
   1. PUT - replaces everything about the object, effectively recreating it in place
   2. PATCH - replaces specific information about the object
5. What is a URI/URL?
   1. ULR: Uniform Resource Locator - address of a unique resource, whether hosted locally or on the internet.
   
6. What is JSON and what does it look like?
   1. It is a special text format that can be used to represent objects.
   2. Technically stands for Javascript Object Notation, though this wont be on the exam. 
   3. Here is a sample of JSON - In this case representing a user object in TrackMyStuff
    {
	    username: "Phillip",
	    userID: "6ffd4f60-3252-44ab-8e6b-29f586f9eef6"
	} 

## (Not on the Exam) EF Core vs ASP.NET  

1. ASP.NET vs Entity Framework Core (THIS WILL NOT BE ON THE EXAM, ITS JUST GOOD TO KNOW)
   1. ASP.NET - Inside of our TrackMyStuffAPI, we have build an ASP.NET web api.
      1. Program.cs
      2. Our HTTP verb tags on our controller methods
      3. registering dependencies with our builder
      4. our controllers that extend controllerbase
      5. the different appsettings.json files
      6. the properties directory with launchSettings.json
      7. SwaggerUI for testing
   2. Entity Framework Core
       1. Inside of TrackMyStuffAPI we have chosen to use EF Core as an Object Relational Mapper.
       2. Our EF Core specific components are things like:
          1. The migration folder
          2. The "dotnet ef" family of CLI commands we use for migrations and database updates
          3. The TrackMyStuffContext that inherits from DBContext
          4. The structure of our model classes is influenced by EF Core
       3. EF Core, like ADO.NET only concerns itself with database access. Getting things to and from our database.  
