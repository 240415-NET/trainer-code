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
}

// If a class is outside a namespace, it becomes globally accessible and will override behaviors of other classes within namespaces
class OutsideNamespaceClass
{

}