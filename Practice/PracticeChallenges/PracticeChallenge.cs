class PracticeChallenge
{
    // 0. Sample Solved Problem:
    // Return the sum of two integers.
    public static int Sum(int a, int b)
    {
        return a + b;
    }


    // 1. Calculate the average of all elements in an array.
    // Basic formula for average is <sum of all elements> / <number of elements>
    public static double ArrayAverage(double[] arr)
    {
        return 0; // Placeholder return
    }

    // 2. Count the number of passing grades.
    // 'threshold' is the cutoff for a passing grade. If they are equal, then its passing.
    public static int CountPassingGrades(double[] grades, double threshold)
    {
        return 0; // Placeholder return
    }

    // 3. Return true if the given number is a perfect square, otherwise false.
    // A Perfect Square means that the number is the product of squaring a Whole Number.
    // Example: 25 is a Perfect Square -> 5 * 5 = 25.
    public static bool IsPerfectSquare(int num)
    {
        return false; // Placeholder return
    }


    // 4. Return the count of distinct characters in a given string. Case-Sensitive -> A != a
    // Examples: "CAT" contains 3 distinct characters.
    // "Hello World" contains 8 distinct characters. "H,e,l,o, ,W,r,d"
    public static int CountDistinctCharacters(string str)
    {
        return 0; // Placeholder return
    }


    // 5. Perform the FizzBuzz game up to a given number.
    // FizzBuzz game:
    // Return "Fizz" if number, 'n', is divisible by 3.
    // Return "Buzz" if number, 'n', is divisible by 5.
    // Return "FizzBuzz" if number, 'n', is divisible by both 3 and 5.
    // Return empty string, otherwise.
    public static string FizzBuzz(int n)
    {
        return ""; // Placeholder return
    }

    // 6. Return the area of a triangle given its base and height.
    // Formula is Area = (1/2) * Base * Height
    public static double AreaOfTriangle(double base1, double height)
    {
        return 0.0; // Placeholder return
    }

    // 7. Return true if the given string is an anagram of another string, otherwise false.
    // An anagram of a string -> contains all the same characters, just in a different order.
    public static bool IsAnagram(string str1, string str2)
    {
        return false; // Placeholder return
    }

    // 8. Count the frequency of words in a given string and return a frequency of each word.
    // In the Dictionary, Keys should be the words found. Values are their frequency.
    // Example: "Hello Hello World" -> Dictionary should have 2 Key-Value Pairs -> "Hello" : 2 and "World" : 1.
    // Consider using split() method on 'sentence' to divide it into smaller strings/words.
    public static Dictionary<string, int> CountWordFrequency(string sentence)
    {

        return []; //Placeholder return
    }

    // 9. Reverse a given integer and add it to the original number.
    // Example: 123 -> Reversed: 321 -> 321 + 123 = 444
    // You can assume the numbers will be positive and not exceed the limit of int when added.
    public static int ReverseAndAdd(int num)
    {
        return 0; //Placeholder return
    }

    // 10. Convert Age into Seconds
    // Given an Age (in years) return how old they were on their birthday in seconds.
    // Example: 1 year old -> 31536000 seconds.
    // Assume exactly 365 days / year for simplicity.
    // Using long to handle higher ages.
    public static long AgeInSeconds(long age)
    {
        return 0; //Placeholder return
    }

    // 11. Calculate the factorial of a positive integer.
    // Factorials are calculated as follows: 1 * 2 * 3 * ... * n
    // Factorial of 5 = 1 * 2 * 3 * 4 * 5 = 120
    // Assume the answer fits inside of an int data type. 
    public static int Factorial(int num)
    {
        return 0; //Placeholder return
    }


    // 12. Count how many times the record is broken in a list of scores.
    // Assume the scores represent a chronological order in which they were earned.
    // First number counts as the first broken record. Then every new highest number after that.
    // Example: scores -> [100, 105, 200, 150, 250, 200] -> The record is broken 4 times. 
    // Starting with 100, then 105, then 200, then 250.
    public static int CountRecordBreaks(List<int> scores)
    {
        return 0; //Placeholder return
    }

    // 13. Compare Apples to Oranges
    // Apples and Oranges are...not like each other. But we could still compare them!
    // Implement the CompareToOrange() method such that an Apple and Orange 
    // are considered equal if their same named properties are equal.
    public class Apple
    {
        public int Weight { get; set; }
        public string? Color { get; set; }

        public bool CompareToOrange(Orange orange)
        {
            return false; //Placeholder return
        }
    }
    public class Orange
    {
        public int Weight { get; set; }
        public string? Variety { get; set; }
    }

    // 14. All Cars are now Black!
    // Add a constructor below such that all cars are now Black.
    // (Is already so, but) ensure that you cannot change the color away from Black.
    public class Car
    {
        public string? Color { get; }

    }

    // 15. Same Numbers, Different Set
    // Return all the numbers shared by the two sets.
    // Example: set1 -> [1, 2, 3, 4] - set2 -> [3, 4, 5, 6] - returns -> [3, 4]
    public static HashSet<int> CompareSets(HashSet<int> set1, HashSet<int> set2)
    {
        return []; // Placeholder return
    }
}