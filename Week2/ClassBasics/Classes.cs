namespace ClassBasics.Classes
{
    public class ExampleClass
    {
        // Fields
        // Unique to each instance of a type
        // Allowing individual objects to maintain distinct values
        public string exampleString;

        // Static Fields
        // Belong to the type / class itself
        // Shared across all instances
        // Accessible only through the type name
        public static int instanceCount;

        // Access Modifiers
        // public
        // private
        // internal
        // protected - Only accessible to children of the class and the class itself

        // readonly - Can only be assigned during initialization or in the constructor
        private readonly int MAX_LIMIT = 100;

        // You cannot have a set method for a readonly variable as it cannot be updated after being initialized
        public int GetMaxLimit()
        {
            return this.MAX_LIMIT;
        }
    
        // Object Initialzers
        // ALlow properties to be initialized directly without calling constructors explicitly

        private string Name;

        // Property
        // These are a pattern of fields in classes
        // public datatype name
        // These properties can have the shorthand {get;set;}
        public int Age {get; set;}

        // Getter and Setter
        // Example of Encapsulation as you are limiting the field to private
        // and allowing access to it explicitly through methods that you have created yourself
        public string GetName()
        {
            return this.Name.ToUpper();
        }

        public void SetName(string Name)
        {
            this.Name = Name.Trim();
        }

    }

    public class Person
    {

        // These are fields
        private string FirstName = "John";
        private string LastName = "Doe";
        private string Email = "john.doe@email.com";
        private int Age = 18;
        private bool OnHoliday = false;

        // Constructor
        /*
            Constructors in C# are special methods used to initialize a new instance of a class
            They are called at the time an object is created and can be used to set initial values or perform any setup required before the object is used
        */

        // This is the default constructor is created for us when we run our code
        // It will do nothing other than instantiate the object
        public Person()
        {
            
        }

        // The constructor is a unique method that is called when we use the new keyword
        // new Person(); // the new keyword explicitly invokes the constructor
        public Person(string FirstName, string LastName, string Email, int Age, bool OnHoliday)
        {
            // this.FirstName = FirstName;
            // this.LastName = LastName;
            // this.Email = Email;
            // this.Age = Age;
            // this.OnHoliday = OnHoliday;

            SetFirstName(FirstName);
            SetLastName(LastName);
            SetEmail(Email);
            SetAge(Age);
            SetOnHoliday(OnHoliday);
        }

        // Design Patterns
        // Design patterns are repeated patterns throughout programming languages that are repeated often enough that it is known by a specific name or phrase
        // A lot of design patterns were developed in the 90s when a group of experienced programmers got together and wrote a book


        // Getters and Setters

        // Getters are responsible for retrieving the value from an object
        // Typically, this is for a private field in order to enforce encapsulation
        // If the field were to be public, then someone could just directly update the field or get the field without going through your getters or setters

        // The this keyword is used to refer to the object that has been created
        public string GetFirstName(){
            return this.FirstName;
        }

        public void SetFirstName(string FirstName){
            if(FirstName.Count() == 0)
            {
                return;
            }
            this.FirstName = FirstName.Trim();
        }

        public string GetLastName(){
            return this.LastName;
        }

        public void SetLastName(string LastName){
            if(LastName.Count() == 0)
            {
                return;
            }
            this.LastName = LastName;
        }
        
        public string GetEmail(){
            return this.Email;
        }

        public void SetEmail(string Email){
            this.Email = Email;
        }
        public int GetAge(){
            return this.Age;
        }

        public void SetAge(int Age){
            if(Age <= 0 || Age > 100){
                return;
            }
            this.Age = Age;
        }
        public bool GetOnHoliday(){
            return this.OnHoliday;
        }

        public void SetOnHoliday(bool OnHoliday){
            this.OnHoliday = OnHoliday;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName: {LastName}\nEmail: {Email}\nAge: {Age}\nOnHoliday: {OnHoliday}";
        }

    }
}

// If a class is outside a namespace, it becomes globally accessible and will override behaviors of other classes within namespaces
class OutsideNamespaceClass
{

}