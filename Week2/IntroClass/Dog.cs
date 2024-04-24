namespace IntroClass;

public class Dog
{
    //A class has members
    //These members are fields(variables) and methods

    //Fields
    //We need to give our fields (and methods) access modifiers so we can control who gets to access them.
    //The most common are going to be public, private, and internal - but there are others.
    /* (most common -> least common)
    public - access isn't restricted whatsoever
    private - we can only see this from within our Class 
    internal - Access is limited to the current assembly 
    protected - Access is limited to this class, or classes that inherit from the current class
    protected internal - Access is limited to the current assembly or types derived from the containing class.
    private protected - Access is limited to the containing class or types derived from the containing class within the current assembly.
    */    


    // Instance Fields
    public string name {get; set;}
    public string breed {get; set;}

    // Static Fields
    public static int legs = 4;
    public static bool hasTail = true;

    //The {get; set;} shorthand is a shorthand for this.
    public int age
    {
        get { return age; }
        set { age = value; }
    }
    public string gender {get; set;}
    public double weight {get; set;}

    //Methods

    //This is an example of an instance method. It is called via dot notation from an instance of the class.
    public void Bark()
    {
        Console.WriteLine($"{name}: bark bark!");
    }

    //This is an example of a static method
    //We call it by referencing the class itself, not an object of that class. 
    public static void DefineDog()
    {   
        //The @ infront of the string turns it into a Verbatim string. This lets us spread a long
        //string across multiple lines of code.
        Console.WriteLine(@"The dog is a domesticated descendant of the wolf. 
        Also called the domestic dog, it is derived from extinct gray wolves, 
        and the gray wolf is the dog's closest living relative.");
    }
}