using System;
using System.Collections.Generic;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Data Types Introduction
            //DataTypeIntro();

            //Enum Introduction
            //EnumIntro();

            //Value Types Demo
           // ValueTypesDemo();

            //Passing Value type by reference to retain its value
            PassByReferenceDemo();

            //Introduction to Var
            VarIntro();

            //Arrays & List
            ArrayIntro();
            ListIntro();

        } 

        private static void DataTypeIntro()
        {
            /* C# is a Strongly Typed Language. i.e you need to define the data type before using the variable. */
            /*
             * ### Varaible ###
             * A Variable is a named location in memory which can be referenced by a familiar name. 
             * l
           */

            int age = 10;
            float height =5.9f; // For Float Data Type you need to put the f at the end of the number
            string name ="Ivo Costa";

            Console.WriteLine(string.Format("My Name is {0}, i am {1} years old. My Height is {2}", name, age, height));
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
            Trainee,
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

        private static List<int> ListIntro()
        {
            //Add using system.collections.generic
            List<int> lstIntergers = new List<int>();
            lstIntergers.Add(1);
            lstIntergers.Add(2);

            lstIntergers.Remove(2);

            return lstIntergers;
        }
        #endregion


    }
}
