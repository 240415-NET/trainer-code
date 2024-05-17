using System.Text;

namespace School.Logic
{
    public class Student : Person
    {
        // Fields
        public double? GPA = 0.0;
        public int? YearsCompleted;

        // Constructor
        public Student()
        { }

        public Student(int Id, string name, string email, string phone, string address1, string address2, string city, string state, int zip, int age, int YearsCompleted)
        {
            this.Id = Id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.state = state;
            this.zip = zip.ToString();
            this.age = age;
            this.YearsCompleted = YearsCompleted;
        }

        public Student(string name, string email, string phone, string address1, string address2,
            string city, string state, string zip, int age, int YearsCompleted)
        {
            this.name = name;
            this.Id = MaxId;
            MaxId++;
            this.email = email;
            this.phone = phone;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.age = age;
            this.YearsCompleted = YearsCompleted;
        }

        // Methods
        public double? GetGPA()
        {
            return GPA;
        }

        public string Introduce()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hello there, my name is {this.name}.");
            return sb.ToString();
        }
    }
}
