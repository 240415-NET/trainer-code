namespace School.Logic
{
    public abstract class Person
    {
        // Fields
        public string? name;
        public int? Id;
        public string? email;
        public string? phone;
        public string? address1;
        public string? address2;
        public string? city;
        public string? state;
        public string? zip;
        public int? age;
        public static int MaxId = 1; // we need to make sure this gets updated every time the program starts.

        // NO CONSTRUCTOR - no need for a constructor

        // Methods        
    }
}

