namespace School.Logic
{
    public class Teacher : Person
    {
        // Fields
        private string? Subject;
        private string? Room;
        private bool? Tenure;
        private double? Salary;
        private List<string>? Certifications;

        // Constructor
        public Teacher(string name, string email, string phone, string address1, string address2, string city,
            string state, string zip, int age, string Subject, string Room, bool Tenure, double Salary,
            List<string> Certifications)
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
            this.Subject = Subject;
            this.Room = Room;
            this.Tenure = Tenure;
            this.Salary = Salary;
            this.Certifications = Certifications;
        }
            // Methods
    }
}
