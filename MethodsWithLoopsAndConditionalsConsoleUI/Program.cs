using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionalsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# - Methods with Loops and Conditionals Exercise 2
            Console.WriteLine("Methods With Loops and Condistionals Exercise 3");

            //Luke Warm #1 - "Print numbers 1000 through -1000"
            Console.WriteLine("Luke Warm #1 Print numbers 1000 through -1000");
            NumberPrinter();
            Console.WriteLine();

            // Luke Warm #2 Print numbers 3 to 999 by 3
            Console.WriteLine("Luke Warm #2 Print numbers 3 to 999 by 3");
            PrintByThree();
            Console.WriteLine();

            // Luke Warm #3 Enter two numbers and compare if they are equal 
            Console.WriteLine("Luke Warm #3 Enter two numbers and compare if they are equal ");
            Console.Write("Enter a number ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter another number ");
            int secondNum = int.Parse(Console.ReadLine());
            string compareResult = NumberEqual(firstNum, secondNum);
            Console.WriteLine($"The numbers are {(compareResult)}");
            Console.WriteLine();

            // Luke Warm #4 Enter a number and print if even or odd
            Console.WriteLine("Luke Warm #4 Determine if an Integer is Even or Odd");
            Console.Write("Enter an integer ");
            int userNum = int.Parse(Console.ReadLine());
            string oddEvenResult = OddEven(userNum);
            Console.WriteLine($"{userNum} is {(oddEvenResult)}");

            // Luke Warm#5 Check the same number to determine if Positive or Negative
            Console.WriteLine("Luke Warm #5 Determine if an Integer is Positive or Negative");
            string positiveNegativeResult = PositiveNegative(userNum);
            Console.WriteLine($"{userNum} is {(positiveNegativeResult)}");
            Console.WriteLine();

            // Luke Warm #6 Determine if the user is Voting Age(18 or older)
            Console.WriteLine("Luke Warm #6 Determine if the user is Voting Age(18 or older)");
            Console.Write("Enter your age ");
            int userAge = int.Parse(Console.ReadLine());
            string userVotingStatus = DetermineVotingStatus(userAge);
            Console.WriteLine($"You are {userVotingStatus} to vote based on your age of {userAge}");
            Console.WriteLine();

            //Heatin Up #1
            //Determine if the Integer Entered is in a range of numbers
            Console.WriteLine("Heatin Up#1- Determine if an Integer is between 10 and -10");
            int lowNumber = -10;
            int highNumber = 10;
            string secretNumber = DetermineSecretNumber(userNum,lowNumber,highNumber);
            Console.WriteLine($"The integer {userNum} is a {secretNumber} Secret Number.");
            Console.WriteLine($"A Secret Number is between {lowNumber} and {highNumber}");
            Console.WriteLine();

            //Heatin Up #2
            //Display the Multiplication Table (1* 12) for given integer
            Console.WriteLine("Heatin Up#2-Display the Multiplication Table (1x12) for an Integer");
            Console.Write("Enter an integer ");
            int userInteger = int.Parse(Console.ReadLine());
            MultiplicationTableDisplay(userInteger);
            Console.WriteLine();

            //Heatin Up #3
            Console.Write("Heatin Up #3 Print a list of Random Number");
            Console.Write("Enter another Integer ");
            int userNumber = int.Parse(Console.ReadLine());
            int[] array = ArrayCreator(userNumber);
            Console.WriteLine($"Here is a list of {userNumber} Random Numbers :");
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //Heatin Up#4 Compute the sum of all the elements in an array of integers
            int[] newNumbers = { 1,2,3,4,5,6,7,8,9,10 };
            //Call Method Sum with this arrary
            int newAll = ArraySum(newNumbers);
            Console.WriteLine($"Heatin Up#4 The Sum of the array of integers 1 through 10 is {(newAll)}");
            Console.WriteLine();

            //Heatin Up #5 Display the cube of the numbers from 1 to user Integer
            Console.Write("Heatin Up #5 Display the cube of the numbers from 1 to user Integer ");
            Console.Write("Enter an Integer ");
            int userMaxInt= int.Parse(Console.ReadLine());
            CubedNumbers(userMaxInt);
         
        }
        // Luke Warm #1 While Loop Prints 1000 to  -1000
        public static void NumberPrinter()
        {
            Console.WriteLine("Print numbers 1000 through -1000");
            var i = 1000;
            while (i >= -1000)
            {
                Console.WriteLine($"i is {i}");
                i--;
            }
        }

        // Luke Warm #2 Print numbers 3 to 999 by 3
        private static void PrintByThree() 
        {
            Console.WriteLine("Print numbers 3 to 999 by 3");
        int i = 3;
        while (i <= 999) 
        {
            Console.WriteLine($"i is {i}");
            i += 3;
        }
        }
        public static string NumberEqual(int num1,int num2)
        // Luke Warm #3 Compares two numbers and determines if they are equal
        {                       
            if (num1 == num2)
                {                
                return "Equal";
                }
                else
                {
                return " Not Equal";
            }                  
        }
        public static string OddEven(int num1)
        // Luke Warm #4 Determines if an integer is Odd or Even
        {
            if (num1 % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        public static string PositiveNegative(int num1)
        // Luke Warm #5 Determines if an integer is Positive or Negative
        {
            if (num1 >= 0)
            {
                return "Positive";
            }
            else
            {
                return "Negative";
            }
        }
        public static string DetermineVotingStatus(int num1)
        // Luke Warm #6 Determines if an integer is >=18 for the age of voting
        {
            if (num1 >= 18)
            {
                return "Allowed";
            }
            else
            {
                return "Not Allowed";
            }
        }

        public static string DetermineSecretNumber(int num1, int low, int high)
        { //Heatin Up #1 Determine if an Integer is within a range of numbers
            if (num1 <= high && num1 >= low) 
            {
                return "Valid";
            }
            return "Not Valid";
        }
        public static void MultiplicationTableDisplay(int userInt)
        { //Heatin Up #2 - Display the Multiplication Table (1* 12) for userInt
            int product = 0;
            for (int i = 1; i <= 12; i++)
            {
                product = i * userInt;
                Console.WriteLine($"{userInt} x {i} = {product}");
            }
        }

        public static int[] ArrayCreator(int userNumber) 
        //Heatin Up #3 - Write a Method that takes a num for the user and return an array with 
        {
            //Create an array
            int[] customArray = new int[userNumber];
            //Create a random object 
            Random rng =  new Random();
            for (int index = 0; index < customArray.Length; index++) 
            {
                customArray[index] = rng.Next();
            }
            return customArray;
        }
        public static int ArraySum(params int[] args)
        {//Heating Up #4 Sum the numbers in an array
            int sum = 0;
            foreach (int num in args)
            {
                sum += num;
            }
            return sum;
        }

        public static void CubedNumbers(int maxInt)
        {//Display a list of cubes number from 1 to the maxInt
            int cubedAnswer = 0;
            for (int i = 1; i <= maxInt; i++) 
            {
                cubedAnswer = i * i * i;
                Console.WriteLine($"Number is {i} and the cube is {cubedAnswer}");               
            }       
        }        
    }
}
