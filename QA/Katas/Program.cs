using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            //00- Remove Spaces 
            //var result = RemoveSpaces.NoSpace("BABA this is a space remover            test");
            //Console.WriteLine("Final Result:" + result);

            //result = RemoveSpaces.NoSpaceOptimized("This is a second       TEST    . hope it works");
            //Console.WriteLine("Final Result (optimized):" + result);

            //Dictionary
            //Welcome w = new Welcome();
            //Console.WriteLine( w.Greet("english"));

            //003 - Vowel Counter
            VowelCounter v = new VowelCounter();
            var answer =  v.GetVowelCount("Ivo");

            Console.ReadKey();

          
        }
    }
}
