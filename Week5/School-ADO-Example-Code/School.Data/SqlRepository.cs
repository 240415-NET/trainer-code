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

        public void Insert(Student st1)
        {
            // a SQLConnection object is created to connect to the database, and is provided the connection string
            using SqlConnection connection = new SqlConnection(this._connectionString);

            connection.Open();
            string cmdText =
                @"INSERT INTO School.Students (Id, Name, Email, Phone, Address1, Address2, City, State, Zip, Age, YearsCompleted)
                VALUES
                (@Id, @Name, @Email, @Phone, @Address1, @Address2, @City, @State, @Zip, @Age, @YearsCompleted)";

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

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void GetStudents()
        {

            // a SQLConnection object is created to connect to the database, and is provided the connection string
            using SqlConnection connection = new SqlConnection(this._connectionString);

            connection.Open(); // open the connection to the database

            //using SqlCommand cmd = new SqlCommand("SELECT * FROM School.Students;", connection);
            //we can use a string as a parameter of the SqlCommand

            string cmdText = "SELECT Id, Name, Phone FROM School.Students;";

            using SqlCommand cmd = new SqlCommand(cmdText, connection);

            //cmd.ExecuteNonQuery();
            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Students in the database:");

            while (reader.Read())
            {
                // Select * From School.Students; returns...
                // Id, Name, Email, Phone, Address1, Address2, City, State, Zip, Age

                // Select Name, Id, Phone From School.Students; returns...
                // Name, Id, Phone

                // Console.WriteLine(reader.GetInt32(0) +  reader.GetString(1));
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string phone = reader.GetString(2);
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