using System;
using System.Linq;

namespace Statements
{
    public class Program
    {
        static void Main(string[] args)
        {

            //IF-ELSE loop 
            int number =10;
            if(number>0)
            {
                Console.WriteLine("Number is greater then zero");
            }
            else
            {
                Console.WriteLine("Number is less then zero");
            }

            //For Loop 
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }

            //Foreach Loop
            int [] arr = new int[5];
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }

            //terenary Operator
            bool value = 1 > 0? true:false;

            string strCode = "LOW";

            switch(strCode)
            {
                case "LOW":
                    Console.WriteLine("Code is Low");
                    break;
                case "HIGH":
                    Console.WriteLine("Code is High");
                    break;
                case "MEDIUM":
                    Console.WriteLine("Code is Medium");
                    break;                                                                                                                     
            }


            /* Problem -- Positive Numbers */
            var sum = PositiveSum(new int[5] { 1, 0, -9, -2, 1 });
            Console.WriteLine("Sum of Array is  is :" + sum);
            Console.ReadKey();


            /* Problem -- Reverse String */
            Console.Write("Enter Input String:");
            var inputString = Console.ReadLine();
            var strReversed = ReverseString("Ivo Costa");
            Console.WriteLine(strReversed);
            Console.ReadKey();

            /* Problem --StairCase */
            //int number = 0;
            //int.TryParse(Console.ReadLine(),out number);
            //PrintStaircaseOptimizedWithLinQ(number);
            //Console.ReadKey();


        }

        #region Problem {Staircase} 
        public static void PrintStaircase(int number)
        {
            for(int i = 0; i < number; i++)
            {
                for(int k=1;k<number-i;k++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
        }
        public static void PrintStaircaseOptimized(int number)
        {
            var charArray = new char[number];

            //Not required since by default char is assigned to empty
            ////Assign the list elements to empty character
            //for(int i = 0; i < number; i++)
            //{
            //    charArray[i]=' ';
            //}

            //Assign an existing elelment in  the list with '#' char during each loop
            for(int i = number - 1; i >= 0; i--)
            {
                charArray[i] = '#';
                Console.WriteLine(charArray.ToArray());
            }

        }

        public static void PrintStaircaseOptimizedWithLinQ(int number)
        {
            var charList = new char[number].ToList();

           // charList.ForEach(x => x = '9');
           

            //Assign an existing elelment in  the list with '#' char during each loop
            for(int i = number - 1; i >= 0; i--)
            {
                charList[i] = '#';
                Console.WriteLine(charList.ToArray());
            }

        }
        #endregion

        #region Problem {Positive Numbers}
        //Introduction to IF Statement adn for Loop and Arrays
        //You get an array of numbers, return the sum of all of the positives ones.

        //Example [1,-4,7,12] => 1 + 7 + 12 = 20

        //Note: array may be empty, in this case return 0.

        public static int PositiveSum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                    sum += arr[i];
            }
            return sum;
        }

        public static int PositiveSum_UsingLinq(int[] arr)
        {
            var positiveNumbers = arr.Where(x => x > 0);
            return positiveNumbers.Sum();
        }

        public static int PositiveSum_UsingLinqOptimized(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
        #endregion

        #region Problem {Reverse String}
        public static string ReverseString(string inputString)
        {
            if(inputString == null)
                return null;
            else if(inputString == string.Empty)
                return string.Empty;

           var charArray=  inputString.ToCharArray();
            string reversedString ="";
           for(int i =charArray.GetLength(0)-1;i>=0;i--)
            {

                reversedString += charArray[i];
            }

            return reversedString;
        }
        #endregion
    }
}
