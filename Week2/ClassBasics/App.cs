namespace ClassBasics
{
    public class App
    {
        public static void Main(string[] args)
        {

            // App.ClassesExample();
            // App.TodoItemExample();
            App.PillarsExample();

        }

        public static void ClassesExample()
        {
                        ExampleClass exampleClass; // Declaration

            exampleClass = new ExampleClass(); // Setting through instantiation

            exampleClass.Age = 55; // Updating

            // Initialization is all of it in one fell swoop


            // exampleClass.Name = "    Hello   "; // this will not compile as we are accessing a private variable

            exampleClass.SetName("   Hello         ");
            // Console.WriteLine(exampleClass.GetName());

            exampleClass.Age = 55; // this is fine because the Age field is public

            // Console.WriteLine(exampleClass.GetMaxLimit());




            // Person Class Examples

            Person personA = new Person();

            // Console.WriteLine(personA.GetFirstName());
            // Console.WriteLine(personA.GetLastName());
            // Console.WriteLine(personA.GetEmail());
            // Console.WriteLine(personA.GetAge());
            // Console.WriteLine(personA.GetOnHoliday());


            Person personB = new Person(); // invoking the default constructor
            personB.SetFirstName(""); // will default to John because of the conditional in the setter method
            personB.SetLastName("Arayathel");
            personB.SetEmail("brian.arayathel@revature.com");
            personB.SetAge(-2); // will default to 18 because of the conditional in the setter method
            personB.SetOnHoliday(false);

            // Console.WriteLine(personB.GetFirstName());
            // Console.WriteLine(personB.GetLastName());
            // Console.WriteLine(personB.GetEmail());
            // Console.WriteLine(personB.GetAge());
            // Console.WriteLine(personB.GetOnHoliday());



            Person personC = new Person("Jane", "Smith", "jane.smith@email.com", 33, true); // invoking the parameterized constructor
            // Console.WriteLine(personC);

            // Console.WriteLine(personC.GetFirstName());
            // Console.WriteLine(personC.GetLastName());
            // Console.WriteLine(personC.GetEmail());
            // Console.WriteLine(personC.GetAge());
            // Console.WriteLine(personC.GetOnHoliday());

            List<Person> people = new List<Person>();

            people.Add(personA);
            people.Add(personB);
            people.Add(personC);

            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
        }
    
        public static void TodoItemExample()
        {
           // TodoItem item1 = new TodoItem();

            // Console.WriteLine(item1);

            // TodoItem item2 = new TodoItem("Get Milk", 60, "4/25/2024", false);

            // Console.WriteLine(item2);

            List<TodoItem> todoItems = new List<TodoItem>();

            Console.WriteLine(new TodoItem("Sharpen my pencil", 5));
            Console.WriteLine(new TodoItem("Sharpen my pencil", 5, "5/25/2024"));
            Console.WriteLine(new TodoItem("Sharpen my pencil", 5, "5/25/2024", true));

            // new TodoItem();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Type Description:\n");

                string description = Console.ReadLine();

                Console.WriteLine("Estimated Time:\n");

                int estimatedTime = int.Parse(Console.ReadLine());

                Console.WriteLine("Due Date:\n");

                string dueDate = Console.ReadLine();

                TodoItem newItem = new TodoItem(description, estimatedTime, dueDate);

                todoItems.Add(newItem);
            }


            foreach(var item in todoItems){
                Console.WriteLine(item);
            }

            // Organizing my UI into a class
            // Adding validation and checks for userinput and saving to my object
            // Adding a way to add items individually, instead of 6 at a time
            // etc

        }
    
        public static void PillarsExample()
        {
            /**
                Polymorphism
                    - Polymorphism allows methods to do different things based on the object that is acting on them
                    - This can be achieved by method overriding
                        - Where a child class can provide their own specific implementation of a method already provided by one of its parent classes
                        - For example, overriding the ToString() method
                        - In order to override a method in C#, the method in the parent class must be defined with the keyword virtual and in the child class it must use the keyword override
                    - This can be achieved by method overloading
                        - Where multiple methods can have the same name but different parameters or order of parameters
                            - Unique method signatures
                                - A method signature is the 'return_type method_name(parameter_list)'
                                - What matters for overloading is the method_name being consistent, but the parameter list being different
            */

            PolymorphismExample polymorphismExample = new PolymorphismExample();
            Console.WriteLine(polymorphismExample.Add(1, 2));
            Console.WriteLine(polymorphismExample.Add(1.5f, 2.23432f));
            Console.WriteLine(polymorphismExample.Add(long.MaxValue / 2, long.MinValue / 5));
            Console.WriteLine(polymorphismExample);

            /*
                Inheritance

                    - Inheritance allows a class to inherit attributes and methods from another class
                    - The class which inehrits is called the subclass/ derived class/ child class
                    - The class that is being inherited is called the superclass/ base class/ parent class
                    - Inheritance enforces heirarchical structures to your objects and classes
                    - Class A -> Class B -> Class C -> Class D
                        - Class D will have everything above it
                        - Class A will not have anything from below it
            */

            Animal animal = new Animal("Monkey", "Ooh Ooh Ahh Ahh");
            Dog lassie = new Dog(42, true);
            Dog pancake = new Dog("Pancake", 30, true, "Woof!");
            GermanShepherd hans = new GermanShepherd("Hans", 35, true, true, 42);

            animal.Speak();
            
        }


        public class PolymorphismExample
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public float Add(float a, float b)
            {
                return a + b;
            }

            public long Add(long a, long b)
            {
                return a + b;
            }

            public override string ToString()
            {
                return "Polymorphism Example Overriding method";
            }
        }


        // Inheritance Example

        // Base Class
        public class Animal
        {
            public string Name {get;set;}

            public string Speech {get;set;}

            public Animal(string Name, string Speech){
                this.Name = Name;
                this.Speech = Speech;
            }

            public virtual void Speak(){
                Console.WriteLine($"{Name} says {Speech}");
            }
        }

        public class Dog : Animal
        {
            public int TeethCount {get;set;}
            public bool IsDomesticated {get;set;}
            public Dog(string Name, int TeethCount, bool IsDomesticated, string Speech) : base(Name, Speech){
                this.TeethCount = TeethCount;
                this.IsDomesticated = IsDomesticated;
            }

            public Dog(int TeethCount, bool IsDomesticated) : base("Lassie", "Timmy fell down the well!"){
                this.TeethCount = TeethCount;
                this.IsDomesticated = IsDomesticated;
            }

            public override void Speak()
            {
                // base.Speak();

                Console.WriteLine($"Dog with name {Name} says {Speech}");
            }

        }

        public class GermanShepherd : Dog
        {

            public bool HasFullTail = true;
            public int DogShowWins = 0;

            public GermanShepherd(string Name, int TeethCount, bool IsDomesticated, bool HasFullTail, int DogShowWins) : base(Name, TeethCount, IsDomesticated, "Komm her, Schafe")
            {
                this.HasFullTail = HasFullTail;
                this.DogShowWins = DogShowWins;
            }

            public override void Speak()
            {
                Console.WriteLine($"German Shepherd called {Name} says {Speech}");
            }
        }
    }
}