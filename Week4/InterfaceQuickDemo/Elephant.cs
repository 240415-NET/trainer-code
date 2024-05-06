namespace InterfaceQuickDemo;

//Implementing an interface LOOKS a lot like inheriting from a base class, this is another reason why that 
//leading capital "I" can be important, so that we know at a glance what we are inheriting (class) 
//versus what we are implementing (interfaces)
//Additionally, convention is that we put the base class we inherit from first, and then list our 
//interfaces, if any
public class Elephant: Animal, INoise
{
    public string subSpecies {get;set;}
    public int trunkLength {get;set;}

    //These are my methods I contractually MUST implement because I used the INoise interface.
    //Every class that uses the INoise interface can have it own bespoke unique special one of a kind novel 
    //individual implementation of the methods within it.

    //If a base class you inherit from already satisfies the requirement for a method that comes in from an interface,
    //You do not necessarily have to define it in a derived class that implements that interface
    //However you should consider why you need this method in either the base class or the interface.
    // public void MakeHappyNoise()
    // {
    //     Console.WriteLine("*Happy elephant noises*");
    // }

    public void MakeSadNoise()
    {

    }

}