using System;
using School.Data;
using School.Logic;

namespace School.App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Creating a School...");

            Teacher t1 = new Teacher("Eunice", "Eunice@hotmail.com", "(567)-432-9012", "1700 Pennsylvania Ave", "", "Washington", "DC", "20500", 27, "Math", "Room 1", true, 100000, new List<string>() { "Math", "Physics" });
            Course c1 = new Course("Math", "Mathmatics", "B5-103", DateTime.Now, 3);

            Console.WriteLine("School created!");

            // instead of hard-coding your connections, look for other ways to get the infromation to your program.
            // like a file that is read in.

            string path = @"c:\Revature\ConnectionStrings\220705-School-DB.txt";

            string connectionString = File.ReadAllText(path);

            IRepository repo = new SqlRepository(connectionString);

            School mySchool = new School(repo);
            Student a = mySchool.GetStudent(1);
            Console.WriteLine(a.Introduce());

        }
    }
}