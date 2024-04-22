namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Arrays are continguous data structures
                They can only have a single data type assigned to them
                They are of fixed length in memory

                They start counting from 0, so if you want to get 3rd item in an array, you would reference it using (n - 1) = 3 - 1 = 2

                To access or update a value in an array, we index it using []

                We can declare and initialize an array in one line using {}
                int[] student_grades = {1, 2, 3, 4};

                    - This is syntactic sugar, it simplifies the number of lines of code you need to write as a developer


            */
            int student_one_grade = 93;
            int student_two_grade = 93;
            int student_three_grade = 100;
            int student_four_grade = 85;

            // Console.WriteLine(student_one_grade);
            // Console.WriteLine(student_two_grade);
            // Console.WriteLine(student_three_grade);
            // Console.WriteLine(student_four_grade);


            int[] student_grades = new int[4];

            student_grades[0] = 97;
            student_grades[1] = 93;
            student_grades[2] = 100;
            student_grades[3] = 85;

            // Console.WriteLine(student_grades[0]);

            int[] student_grades2 = {97,93,100,85};

            // Console.WriteLine(student_grades[0]);

            // for(int i = 0; i < 4; i++)
            // {
            //     Console.WriteLine(i);
            //     Console.WriteLine(student_grades[i]);
            // }

            // Enhanced For Loop
            // foreach(int grade in student_grades2)
            // {
            //     Console.WriteLine(grade);
            // }

            char[] hello_chars = {'H', 'e', 'l', 'l', 'o'};
            string hello_string = new string(hello_chars);

            Console.WriteLine(hello_string);
            Console.WriteLine(hello_chars);

            // .ToCharArray() method

            string world_string = "world!";
            char[] world_chars = world_string.ToCharArray();

            Console.WriteLine(world_string);
            Console.WriteLine(world_chars);

            // String methods

            // string new_word = Console.ReadLine();
            // Console.WriteLine(new_word);

            // new_word = new_word.ToUpper();
            // Console.WriteLine(new_word);

            // Console.WriteLine(new_word.ToLower());

            // Console.WriteLine(new_word);

            // foreach(char c in new_word){
            //     Console.WriteLine(c);
            // }

            // for(int i = 1; i < new_word.Count(); i++){
            //     Console.WriteLine(new_word[i]);
            // }

            // substring

            // Console.WriteLine(new_word.Substring(0, 3));

            // Contains

            Console.WriteLine("Please write your name!");
            // string name = Console.ReadLine();

            // if (name.ToLower().Contains("mike!"))
            // {
            //     Console.WriteLine("Hello Mike, I know your name specifically");
            // }else{
            //     Console.WriteLine("Hello " + name);
            // }
            
            // Trim() - remove all leading and trailing whitespace from a string


            Console.WriteLine("Please write your name!");
            // string name2 = Console.ReadLine().Trim().ToLower();

            // Console.WriteLine(name2);


            // Replace - Replaces all occurrences of a specified substring with another substring
            string text = "Hello Hello, World!";

            string newText = text.Replace(" ", "_");

            Console.WriteLine(newText);


        }
    }
}