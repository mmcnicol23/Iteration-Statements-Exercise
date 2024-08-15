using System.ComponentModel.Design;
using System.Globalization;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // DONE 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // DONE 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumbers()
        {
            for (int i = 3; i >= 3 && i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // DONE 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // DONE 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool isEven(int num3)
        {
            if (num3 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // DONE 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool isPositive(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DONE 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {
            if (age > 18)
            {
                Console.WriteLine("Yes, you can vote!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough to vote.");
                return false;
            }
        }

        // DONE Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange(int num5)
        {
            if (num5 >= -10 && num5 <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // DONE 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable()
        {
            Console.WriteLine("Enter a number to be multiplied by numbers 1 through 12:");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered the number {userInput}.");
            Console.WriteLine($"Here is your times table for {userInput}:");
            
            for (int i = 1; i <= 12; i++)
            {
                int result = i * userInput;
                Console.WriteLine($"{i} * {userInput} = {result}");
            }
        }


        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();

            PrintEveryThirdNumbers();

            bool answer1 = AreNumbersEqual(5, 6);
            Console.WriteLine(answer1);

            bool answer2 = isEven(25);
            Console.WriteLine(answer2);

            bool answer3 = isPositive(10);
            Console.WriteLine(answer3);

            Console.WriteLine("What is your age? Please enter it below:");
            string age = Console.ReadLine();
            int parsedAge = int.Parse(age);
            bool answer4 = CanVote(parsedAge);
            Console.WriteLine(answer4);

            Console.WriteLine("Enter a number between -10 and 10:");
            string num5 = Console.ReadLine();
            int UserInput = int.Parse(num5);
            bool num6 = IsInRange(UserInput);
            Console.WriteLine(num6);


            DisplayMultiplicationTable();

        }
    }
}

