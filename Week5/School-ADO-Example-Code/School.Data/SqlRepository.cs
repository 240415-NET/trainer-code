using System;
using School.Logic;
using System.Data.SqlClient;

namespace School.Data
{
    public class SqlRepository : IRepository //by extending the interface, this class agrees to fulfill all the methods of the interface.
    {
        // Fields

        // your connection string has all the details needed to connect to a database
        private readonly string _connectionString;

        //the readonly modifier allows us to set a value in the constructor, then prevents modification.



        // Constuctor
        public SqlRepository( string connectionString)
        {
            this._connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        //Methods

        //An example of inserting into a database using ADO.NET 
        public void Insert(Student st1)
        {
            // a SQLConnection object is created to connect to the database, and is provided the connection string

            //This using statement allows for this reference to be disposed of, and the connection closed after the 
            //method finishes running
            using SqlConnection connection = new SqlConnection(this._connectionString);

            //Once we create our SqlConnection object, we call a method off of it to open the connection to the database.
            connection.Open();

            //We then create a string, for the query or statement we are going to run, that allows us to update it's parameters later.
            string cmdText =
                @"INSERT INTO School.Students (Id, Name, Email, Phone, Address1, Address2, City, State, Zip, Age, YearsCompleted)
                VALUES
                (@Id, @Name, @Email, @Phone, @Address1, @Address2, @City, @State, @Zip, @Age, @YearsCompleted)";

            //So we use the parameterized string above to create a SqlCommand object. 
            using SqlCommand cmd = new SqlCommand(cmdText, connection);

            cmd.Parameters.AddWithValue("@ID", st1.Id);
            cmd.Parameters.AddWithValue("@Name", st1.name);
            cmd.Parameters.AddWithValue("@Email", st1.email);
            cmd.Parameters.AddWithValue("@Phone", st1.phone);
            cmd.Parameters.AddWithValue("@Address1", st1.address1);
            cmd.Parameters.AddWithValue("@Address2", st1.address2);
            cmd.Parameters.AddWithValue("@City", st1.city);
            cmd.Parameters.AddWithValue("@State", st1.state);
            cmd.Parameters.AddWithValue("@Zip", st1.zip);
            cmd.Parameters.AddWithValue("@Age", st1.age);
            cmd.Parameters.AddWithValue("@YearsCompleted", st1.YearsCompleted);

            //We execute the above INSERT with this Execute non query. Because we are not querying the DB
            //we will execute this as a nonquery. 
            cmd.ExecuteNonQuery();

            //We then close the connection, and after line 62 - our SqlConnection object is disposed of,
            //because we created it with that using statement above. 
            connection.Close();
        }

        public void GetStudents()
        {

            // a SQLConnection object is created to connect to the database, and is provided the connection string
            using SqlConnection connection = new SqlConnection(this._connectionString);

            connection.Open(); // open the connection to the database

            //using SqlCommand cmd = new SqlCommand("SELECT * FROM School.Students;", connection);
            //we can use a string as a parameter of the SqlCommand

            //A consideration for SELECT statments... avoid using the asterisk/wildcard character to 
            //return all values. We can't be sure things will return back to us in a certain order
            //UNLESS we specify the order by selecting the columns how we want them to come in. 
            string cmdText = "SELECT Id, Name, Phone FROM School.Students;";

            //Create the command object
            using SqlCommand cmd = new SqlCommand(cmdText, connection);

            //We create a SqlDataReader... so that we can read our data from the database.
            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Students in the database:");

            //We use this while loop, because the SqlDataReader will continue to read data, one row at a time,
            //until we reach the end of what was returned. 
            while (reader.Read())
            {

                // Select Name, Id, Phone From School.Students; returns...
                // Id, Name, Phone

                //We then read from the row starting at 0 based on the order we gave it when we 
                //created the command text above. We have to be mindful of what our datatypes are.
                //And select the appropriate GetX method for that data type. 
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string phone = reader.GetString(2);
                
                //Once datareader advances past a certain row, that's it. So Inside of this While block,
                //you will want to do whatever you need to, to persist or work with your returned data. 

                //This can be things like, creating an object based on some model, like a student, and
                //adding them to a collection declared OUTSIDE of the while loop of type student. 

                //In the case of this example, they simply print out info about the student. 
                Console.WriteLine(id + " " + name + " " + phone);
            }

            connection.Close();
        }

        public Student GetStudent(int ID)
        {
            Student tmpStudent = new Student();

            using SqlConnection connection = new SqlConnection(this._connectionString);
            connection.Open();

            string cmdText = @"SELECT * FROM School.Students WHERE Id = @Id;";

            using SqlCommand cmd = new SqlCommand(cmdText, connection);
            cmd.Parameters.AddWithValue("@Id", ID);

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string name = reader.GetString(1);
                string email = reader.GetString(2);
                string phone = reader.GetString(3);
                string address1 = reader.GetString(4);
                string address2 = reader.GetString(5);
                string city = reader.GetString(6);
                string state = reader.GetString(7);
                int zip = reader.GetInt32(8);
                int age = reader.GetInt32(9);
                int yearsComp = reader.GetInt32(10);

                tmpStudent = new Student(ID, name, email, phone, address1, address2, city, state, zip, age, yearsComp);
            }

            return tmpStudent;
        }
    }
}