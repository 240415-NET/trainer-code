class Program
{
    static void Main(string[] args)
    {
        //Calls some tests for Question 0:
        QuestionZero();
        //Calls some tests for Question 1:
        QuestionOne();
        //Calls some tests for Question 2:
        QuestionTwo();
        //Calls some tests for Question 3:
        QuestionThree();
        //Calls some tests for Question 4:
        QuestionFour();
        //Calls some tests for Question 5:
        QuestionFive();
        //Calls some tests for Question 6:
        QuestionSix();
        //Calls some tests for Question 7:
        QuestionSeven();
        //Calls some tests for Question 8:
        QuestionEight();
        //Calls some tests for Question 9:
        QuestionNine();
        //Calls some tests for Question 10:
        QuestionTen();
        //Calls some tests for Question 11:
        QuestionEleven();
        //Calls some tests for Question 12:
        QuestionTwelve();
        //Calls some tests for Question 13:
        QuestionThirteen();
        //Calls some tests for Question 14:
        QuestionFourteen();
        //Calls some tests for Question 15:
        QuestionFifteen();

    }

    static void QuestionZero()
    {
        // Call method 0: Sum
        Console.WriteLine("Question 0: Sum");
        int result1 = PracticeChallenge.Sum(5, 10);
        int result2 = PracticeChallenge.Sum(-5, 10);
        int result3 = PracticeChallenge.Sum(-5, -10);

        Console.WriteLine("Test 1: " + (result1 == 15 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 5 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == -15 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionOne()
    {
        // Call method 1: ArrayAverage
        Console.WriteLine("Question 1: ArrayAverage");
        double result1 = PracticeChallenge.ArrayAverage([1, 2, 3, 4]);
        double result2 = PracticeChallenge.ArrayAverage([-1, -2, -3]);
        double result3 = PracticeChallenge.ArrayAverage([0]);

        Console.WriteLine("Test 1: " + (result1 == 2.5 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == -2 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 0 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionTwo()
    {
        // Call method 2: CountPassingGrades
        Console.WriteLine("Question 2: CountPassingGrades");
        int result1 = PracticeChallenge.CountPassingGrades([75, 80, 90, 65, 85], 70);
        int result2 = PracticeChallenge.CountPassingGrades([60, 55, 45, 35], 60);
        int result3 = PracticeChallenge.CountPassingGrades([100, 100, 100], 90);

        Console.WriteLine("Test 1: " + (result1 == 4 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 1 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 3 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionThree()
    {
        // Call method 3: IsPerfectSquare
        Console.WriteLine("Question 3: IsPerfectSquare");
        bool result1 = PracticeChallenge.IsPerfectSquare(16);
        bool result2 = PracticeChallenge.IsPerfectSquare(25);
        bool result3 = PracticeChallenge.IsPerfectSquare(14);

        Console.WriteLine("Test 1: " + (result1 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (!result3 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionFour()
    {
        // Call method 4: CountDistinctCharacters
        Console.WriteLine("Question 4: CountDistinctCharacters");
        int result1 = PracticeChallenge.CountDistinctCharacters("Hello World");
        int result2 = PracticeChallenge.CountDistinctCharacters("aabbcc");
        int result3 = PracticeChallenge.CountDistinctCharacters("");
        int result4 = PracticeChallenge.CountDistinctCharacters("Aaron");

        Console.WriteLine("Test 1: " + (result1 == 8 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 3 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 0 ? "Success" : "Fail"));
        Console.WriteLine("Test 4: " + (result4 == 5 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionFive()
    {
        // Call method 5: FizzBuzz
        Console.WriteLine("Question 5: FizzBuzz");
        string result1 = PracticeChallenge.FizzBuzz(45);
        string result2 = PracticeChallenge.FizzBuzz(10);
        string result3 = PracticeChallenge.FizzBuzz(7);
        string result4 = PracticeChallenge.FizzBuzz(3);

        Console.WriteLine("Test 1: " + (result1 == "FizzBuzz" ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == "Buzz" ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == "" ? "Success" : "Fail"));
        Console.WriteLine("Test 4: " + (result4 == "Fizz" ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionSix()
    {
        // Call method 6: AreaOfTriangle
        Console.WriteLine("Question 6: AreaOfTriangle");
        double result1 = PracticeChallenge.AreaOfTriangle(5, 7);
        double result2 = PracticeChallenge.AreaOfTriangle(3, 10);
        double result3 = PracticeChallenge.AreaOfTriangle(0, 5);

        Console.WriteLine("Test 1: " + (result1 == 17.5 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 15 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 0 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionSeven()
    {
        // Call method 7: IsAnagram
        Console.WriteLine("Question 7: IsAnagram");
        bool result1 = PracticeChallenge.IsAnagram("listen", "silent");
        bool result2 = PracticeChallenge.IsAnagram("hello", "world");
        bool result3 = PracticeChallenge.IsAnagram("", "");

        Console.WriteLine("Test 1: " + (result1 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (!result2 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionEight()
    {
        // Call method 8: CountWordFrequency
        Console.WriteLine("Question 8: CountWordFrequency");
        Dictionary<string, int> result1 = PracticeChallenge.CountWordFrequency("Hello Hello World");
        Dictionary<string, int> result2 = PracticeChallenge.CountWordFrequency("apple banana apple banana cherry cherry");
        Dictionary<string, int> result3 = PracticeChallenge.CountWordFrequency("");

        Console.WriteLine("Test 1: " + (result1.ContainsKey("Hello") && result1["Hello"] == 2 && result1.ContainsKey("World") && result1["World"] == 1 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2.ContainsKey("apple") && result2["apple"] == 2 && result2.ContainsKey("banana") && result2["banana"] == 2 && result2.ContainsKey("cherry") && result2["cherry"] == 2 && !result2.ContainsKey("orange") ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3.Count == 0 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionNine()
    {
        // Call method 9: ReverseAndAdd
        Console.WriteLine("Question 9: ReverseAndAdd");
        int result1 = PracticeChallenge.ReverseAndAdd(123);
        int result2 = PracticeChallenge.ReverseAndAdd(1);
        int result3 = PracticeChallenge.ReverseAndAdd(987123);

        Console.WriteLine("Test 1: " + (result1 == 444 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 2 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 1112220 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionTen()
    {
        // Call method 10: AgeInSeconds
        Console.WriteLine("Question 10: AgeInSeconds");
        long result1 = PracticeChallenge.AgeInSeconds(30);
        long result2 = PracticeChallenge.AgeInSeconds(1);
        long result3 = PracticeChallenge.AgeInSeconds(0);
        long result4 = PracticeChallenge.AgeInSeconds(80); //Testing limits of ints. Need long.

        Console.WriteLine("Test 1: " + (result1 == 946080000 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 31536000 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 0 ? "Success" : "Fail"));
        Console.WriteLine("Test 4: " + (result4 == 2522880000 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionEleven()
    {
        // Call method 11: Factorial
        Console.WriteLine("Question 11: Factorial");
        int result1 = PracticeChallenge.Factorial(5);
        int result2 = PracticeChallenge.Factorial(10);
        int result3 = PracticeChallenge.Factorial(1);

        Console.WriteLine("Test 1: " + (result1 == 120 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 3628800 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 1 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionTwelve()
    {
        // Call method 12: CountRecordBreaks
        Console.WriteLine("Question 12: CountRecordBreaks");
        int result1 = PracticeChallenge.CountRecordBreaks([100, 105, 200, 150, 250, 200]);
        int result2 = PracticeChallenge.CountRecordBreaks([100, 90, 80, 70, 60, 50]);
        int result3 = PracticeChallenge.CountRecordBreaks([100, 105, 110, 115, 120]);

        Console.WriteLine("Test 1: " + (result1 == 4 ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2 == 1 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3 == 5 ? "Success" : "Fail"));
        Console.WriteLine();
    }

    static void QuestionThirteen()
    {
        // Call method 13: CompareToOrange
        // Test 1: Ensure color properties are not compared
        PracticeChallenge.Apple apple1 = new() { Weight = 100, Color = "Red" };
        PracticeChallenge.Orange orange1 = new() { Weight = 100, Variety = "Navel" };
        bool result1 = apple1.CompareToOrange(orange1);
        Console.WriteLine("Test 1: " + (result1 ? "Success" : "Fail"));

        // Test 2: Negative result when weights are not equal
        PracticeChallenge.Apple apple2 = new() { Weight = 200 };
        PracticeChallenge.Orange orange2 = new() { Weight = 100 };
        bool result2 = apple2.CompareToOrange(orange2);
        Console.WriteLine("Test 2: " + (!result2 ? "Success" : "Fail"));

        // Test 3: Weight inequality does not affect comparison if other properties are same
        PracticeChallenge.Apple apple3 = new() { Weight = 200, Color = "Red" };
        PracticeChallenge.Orange orange3 = new() { Weight = 100, Variety = "Red" };
        bool result3 = apple3.CompareToOrange(orange3);
        Console.WriteLine("Test 3: " + (!result3 ? "Success" : "Fail"));
        Console.WriteLine();

    }

    static void QuestionFourteen()
    {
        // Call method 14: CarColor
        Console.WriteLine("Question 14: CarColor");
        PracticeChallenge.Car car = new PracticeChallenge.Car();
        Console.WriteLine("Test 1: " + (car.Color == "Black" ? "Success" : "Fail"));

        // Try changing the color
        // Sample test. If Uncommenting this works....then you've messed up the readonly Property....tsk tsk.
        // try
        // {
        //     car.Color = "Red";
        //     Console.WriteLine("Test 2: Fail (Exception not thrown)");
        // }
        // catch (Exception)
        // {
        //     Console.WriteLine("Test 2: Success (Exception thrown)");
        // }

        Console.WriteLine();
    }

    static void QuestionFifteen()
    {
        // Call method 15: CompareSets
        Console.WriteLine("Question 15: CompareSets");
        HashSet<int> result1 = PracticeChallenge.CompareSets([1, 2, 3, 4], [3, 4, 5, 6]);
        HashSet<int> result2 = PracticeChallenge.CompareSets([1, 2, 3], [4, 5, 6]);
        HashSet<int> result3 = PracticeChallenge.CompareSets([], [1, 2, 3]);
        HashSet<int> result4 = PracticeChallenge.CompareSets([1, 2, 3], [1, 2, 3]);

        Console.WriteLine("Test 1: " + (result1.SetEquals([3, 4]) ? "Success" : "Fail"));
        Console.WriteLine("Test 2: " + (result2.Count == 0 ? "Success" : "Fail"));
        Console.WriteLine("Test 3: " + (result3.Count == 0 ? "Success" : "Fail"));
        Console.WriteLine("Test 4: " + (result4.SetEquals([1, 2, 3]) ? "Success" : "Fail"));
        Console.WriteLine();


    }

}
