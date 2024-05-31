//In our Program.cs we still have to be mindful of the namespaces we create for things like our
//service and data access classes/interfaces. 
using TrackMyStuff.API.Services;

// This program.cs is way different than what we are used to seeing
// It runs almost as a script, from top to bottom, where we add services to our AppBuilder,
// and then we build the app. After the app has been built, we can toggle different options for it.
// All of this is done, when we dotnet run our webapi
var builder = WebApplication.CreateBuilder(args);

// Adding services to the container - these below came in from the template.
//By default, you will have AddControllers(), AddEndpointsApiExplorer(), and AddSwaggerGen() in your
//Program.cs included. We are going to move AddControllers() to be the last thing added, so that it is
//added AFTER all of our dependencies. 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Here are the dependencies that we are going to register. These are things we create or choose to bring in.
builder.Services.AddScoped<IUserService, UserService>(); // This adds our UserService, that our UserController then asks for
builder.Services.AddScoped<IUserStorageEFRepo, UserStorageEFRepo>();// This adds our UserStorageEFRepo (data-access layer), that our UserService asks for. 


//This came in by default with the template that dotnet new gave us, we just moved it AFTER our dependencies. 
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
