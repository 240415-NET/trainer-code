using TrackMyStuff.Models;
using System.Data.SqlClient;

namespace TrackMyStuff.Data;

public class SqlUserStorage : IUserStorageRepo
{
    //Using a verbatim string literal to ignore all issues related to the slashes for windows file paths
    //And using an absolute file path, starting from my C drive to avoid any relative file path issues
    //If I move my entire project directory, this file path will still work because it's an exact address to my
    //connection string
    public static string connectionString = File.ReadAllText(@"C:\Users\JonathanDeLaCruz\Documents\Revature\connstring.txt");

    public User FindUser(string usernameToFind)
    {
        throw new NotImplementedException();
    }

    public void StoreUser(User user)
    {
        //Create a SQLConnection object to be able to connect to our Database.
        //we want this object to be "disposable" - that is to say, we want it to be destroyed or dereferenced
        //as soon as this method is done executing. We do this with a "using" statement.  
        using SqlConnection connection = new SqlConnection(connectionString);

        //After we create our connection object, we call an instance method called Open() to open the connection
        connection.Open();

        //After this, we start to create our command, we can do this with a templated string as shown below.
        //Doing this we can avoid any issues with SQL Injection, as well as not have to mess with 
        //manual string concatenation 
        string cmdText = @"INSERT INTO dbo.Users (userId, userName)
                            VALUES (@userId, @userName);";

        //We use the connection we created and opened, as well as the command text template we created above
        //to create a new SqlCommand object that we will eventually send to do stuff on our database. 
        using SqlCommand cmd= new SqlCommand(cmdText, connection);

        //Now that we have our SqlCommand object, in this case named cmd, we can call a method AddWithValue()
        //to fill out the templated INSERT command string
        //We call this a little differently than other instance methods, because we are reaching deeper into
        //the cmd object. 
        cmd.Parameters.AddWithValue("@userId", user.userId);
        cmd.Parameters.AddWithValue("@userName", user.userName);

        //We then execute our INSERT statement that we created and fleshed out above by running
        //the instance method ExecuteNonQuery() off of our cmd object
        cmd.ExecuteNonQuery();

        //Once that is done, we simply close the connection
        connection.Close();

    }
}