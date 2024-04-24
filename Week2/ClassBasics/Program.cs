using ClassBasics.Classes;

namespace ClassBasics
{
    public class ClassBasics
    {
        public static void Main(string[] args)
        {
            ExampleClass exampleClass = new ExampleClass {Age = 30};

            // exampleClass.Name = "    Hello   "; // this will not compile as we are accessing a private variable

            exampleClass.SetName("   Hello         ");
            Console.WriteLine(exampleClass.GetName());

            exampleClass.Age = 55; // this is fine because the Age field is public

            Console.WriteLine(exampleClass.GetMaxLimit());
        }
    }

}