namespace InterfaceQuickDemo;

//So here is how I define an new interface, it is almost identical to creating a class
//The common convention is, to begin Interface files and names with a capital "I",
//so we know we are dealing with an Interface at a glance.
public interface INoise
{
    //Inside our interface we only care about method signatures.
    //Access modifier, what you return, and it's name is, and what it expects.
    //Thats it, no curly braces, no actual logic is written in this interface.
    public void MakeHappyNoise();

    //Our interfaces can contain as many method signatures as needed, as well as 
    //account for overloads of the same method (so same name, but different arguments)
    public void MakeSadNoise();




}