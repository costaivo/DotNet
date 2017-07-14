using System;
using System.Collections.Generic;
using static System.Console;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Data Types Introduction
            //DataTypeIntro();

            //Enum Introduction
            // EnumIntro();

            //Value Types Demo
            // ValueTypesDemo();

            //Passing Value type by reference to retain its value
            // PassByReferenceDemo();


            //  Student s = new Student();
            // s.Age = 100;
            //  IncrementAge(s);
            // Console.WriteLine(s.Age);

            //Introduction to Var
            // VarIntro();

            //Arrays & List
            // ArrayIntro();
            //ListIntro();


            //Generics
            // WriteLine(addNumberInt(1, 2));
            // WriteLine(addNumberFloat(1, 2));
            // WriteLine(addNumberDouble(1, 2));
            //WriteLine(addNumbers<double>(1, 2));

            //  GetName()


            Person p = new Person() {Firstname="Zohaib",LastName="Mulla" };
            Student s = new Student {Firstname="Gaurav",LastName="Borkar" };

            WriteLine(p.ToString());
            WriteLine(s.ToString());


            ReadKey();
        } 


        //single line comments
        /*
         * This is a multiline comments
         */ 
        private static void DataTypeIntro()
        {
            /* C# is a Strongly Typed Language. i.e you need to define the data type before using the variable. */
            /*
             * ### Varaible ###
             * A Variable is a named location in memory which can be referenced by a familiar name. 
             * l
           */

            int age = 10;
            long years = age;

            age =(int) years;

            float height =5.9f; // For Float Data Type you need to put the f at the end of the number
            double b = height;

            string name ="Ivo Costa";

            char c ='x';
            name = c.ToString();

           

            Console.WriteLine(string.Format("My Name is {0}, i am {1} years old. My Height is {2}", name, age, height));
            Console.WriteLine("My Name is "+ name +", i am "+age+" years old. My Height is " + height);
            Console.WriteLine("My Name is {name}, i am {age} years old. My Height is {height}"); //String Interpolation
            Console.ReadKey();

        }

        #region Enums
        private static void EnumIntro()
        {
            Designation yourDesignation = Designation.Developer;

            Console.WriteLine(string.Format("Your Designation is {0}", yourDesignation));
            
            //TypeCasting in Action: Explain TypeCasting. 
            Console.WriteLine((int) yourDesignation);
            Console.ReadKey();
        }
        public enum Designation
        {
            Trainee=4,
            JuinorProgramer,
            Developer,
            SeniorProgrammer,
            TeamLead,
            SeniorTeamLead,
            ProjectManager,
            GroupManager
        }
        #endregion

        #region ValueTypes vs ReferenceTypes
        /* There are two types of Data Types  : Value Types and Reference Types */
        /* Below Example shows the difference how Value type and Reference types behave when passed around */
        private static void ValueTypesDemo()
        {
            int x =100;
            IncrementNumber(x);
            Console.WriteLine($"Value of variable x is {x}"); //Alert! New Concept :String Interpolation. Explain in detail 
            Console.ReadKey();
        }
        private static void IncrementNumber(int number)
        {
            number = number + 10;
        }

        private static void PassByReferenceDemo()
        {
            int x =100;
            IncrementNumber(ref x);
            Console.WriteLine($"Value of variable x is {x}"); //Alert! New Concept :String Interpolation. Explain in detail 
            Console.ReadKey();
        }

        private static void IncrementNumber(ref int number)
        {
            number = number + 10;
        }

        private static void IncrementAge(Student student)
        {
            student.Age = student.Age + 10;
        }
        #endregion

        #region Var
        private static void VarIntro()
        {
            /* When we use Var keyword for a datatype the compiler determines the type based on the type set. 
             * var i= 10; //implicitly typed
             * int i= 10; //explicitly typed
             */
            var i = 10; //int
            var name ="QA"; //string

        }
        #endregion

        #region Arrays & Lists
        private static int[] ArrayIntro()
        {
            //Array defination 
            int [] intArray = new  int [5];

            //Assignments
            intArray[0] = 1;
            intArray[1] = 2;

            string [] strArray = new string[2] {"Hello ","World"};

            char [] charArray = new char[3] {'x','x','x'};

            return intArray;
        }

        private static List<double> ListIntro()
        {
            //Add using system.collections.generic
            List<double> lstIntergers = new List<double>();
        
            lstIntergers.Add(1);
            lstIntergers.Add(2);

            lstIntergers.Remove(2);

            return lstIntergers;
        }


        #endregion

        #region Genrics
        private static int addNumberInt(int a, int b)
        {
            return a + b;
        }
        private static float addNumberFloat(float a, float b)
        {
            return a + b;
        }
        private static double addNumberDouble(double a, double b)
        {
            return a + b;
        }

        //private static T addNumbers<T>(T a, T b)
        //{
        //    return a + b;
        //}
        #endregion

        #region Function Overloading
        private static string GetName()
        {
            return "Neha";
        }
        private static int GetName(double s)
        {
            return 1;
        }
        private static string GetName(string prefix)
        {
            return prefix + " Neha";
        }
        private static string GetName(int prefix)
        {
            string name = "Neha";
            switch(prefix)
            { case 1:
                    name = "Miss " + name;
                    break;
                default:
                    break; 
            }
            return name;
        }


        #endregion

        #region Class 
        public class Person
        {
            public string Firstname { get; set; }
            public string LastName { get; set; }

            public int Age { get; set; }

            public override string ToString()
            {
                return GetName();
            }

            private string GetName()
            {
                return Firstname + " " + LastName;
            }
            public virtual string MyAge()
            {
                return Age.ToString();
            }
        }

        public class Student: Person
        {

            public override string MyAge()
            {
                return "My age is :" + Age.ToString();
            }

        }
        #endregion
    }
}
