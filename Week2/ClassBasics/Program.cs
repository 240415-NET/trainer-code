using System.Collections;
using ClassBasics.Classes;

namespace ClassBasics
{
    public class ClassBasics
    {
        public static void Main(string[] args)
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
    }

}