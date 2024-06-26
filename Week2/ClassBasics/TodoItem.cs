using System.Runtime.InteropServices;

namespace ClassBasics
{
    public class TodoItem
    {

        // These are the fields that will make up the shape of my object
        private string Description = "Default Description";
        private int EstimatedTime = 60; // int as minutes

        private string DueDate = "4/24/2024";

        private bool Status = false; // false is incomplete

        // This is the default constructor that any class will create automatically if no other constructor is provided by the developer
        // If this constructor is created by the developer, it is also referred to as a No-Args Constructor

        // public TodoItem(){

        // }

        // This is an All-Args constructor

        // public TodoItem(string Description, int EstimatedTime, string DueDate, bool Status)
        // {
        //     this.Description = Description;
        //     this.EstimatedTime = EstimatedTime;
        //     this.DueDate = DueDate;
        //     this.Status = Status;
        // }


        // These are all examples of Constructor overloading
        // All of these will make an object, but based on the arguments provieded when the object is created, a different constructor will be called
        // Only one constructor can be called to create an object
        // Console.WriteLine(new TodoItem("Sharpen my pencil", 5));

        // Comment

        // Comment 2
        public TodoItem(string Description, int EstimatedTime)
        {
            this.Description = Description;
            this.EstimatedTime = EstimatedTime;
            this.DueDate = $"{DateTime.Now}";
        }

        // The : this() is used as a shorthand to minimise the amount of code that needs to be written
        // We can use other constructors inside the class and how they implement their methods instead of rewriting inside each of them
        // Console.WriteLine(new TodoItem("Sharpen my pencil", 5, "5/25/2024"));
        public TodoItem(string Description, int EstimatedTime, string DueDate) : this(Description, EstimatedTime)
        {
            this.DueDate = DueDate;
        }

        // Console.WriteLine(new TodoItem("Sharpen my pencil", 5, "5/25/2024", true));
        public TodoItem(string Description, int EstimatedTime, string DueDate, bool Status) : this(Description, EstimatedTime, DueDate)
        {
            this.Status = Status;
        }

        // Test comment


        // My methods are how I will interact with the objects, and how the objects will interact with each other
        public string GetDescription(){
            return this.Description;
        }

        public void SetDescription(string Description){
            this.Description = Description;
        }

        public bool GetStatus(){
            return this.Status;
        }

        public void SetStatus(bool Status){
            this.Status = Status;
        }

        public int GetEstimatedTime(){
            return this.EstimatedTime;
        }

        public void SetEstimatedTime(int EstimatedTime){
            this.EstimatedTime = EstimatedTime;
        }

        public string GetDueDate(){
            return this.DueDate;
        }

        public void SetDueDate(string DueDate){
            this.DueDate = DueDate;
        }


        // Override the ToString

        public override string ToString()
        {
            // I do not want to put a raw boolean inside my ToString, so I have created my own string representing the status of the boolean
            // It will default to false, showing incomplete
            string CurrentStatus = "Incomplete";


            // If the todo Item field Status is set to be true, then this If statement will evaluate
            // And update the CurrentStatus string to "Complete"
            if(Status){
                CurrentStatus = "Complete";
            }

            return $"{Description} - {DueDate}\nEstimated Time: {EstimatedTime}\nStatus: {CurrentStatus}";
        }
    }
}