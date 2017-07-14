using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.QA
{
    class Program
    {
        static void Main(string[] args)
        {

            IWriter app;
            int count =0;
            while(count < 3)
            { 
                string inputParameter = Console.ReadLine();
            switch(inputParameter)
            {
                case "C":
                    app = new ConsoleWriter();
                    break;
                case "P":
                    app = new PDFWriter();
                    break;
                case "E":
                    app = new ExcelWriter();
                    break;
                default:
                    app = new ConsoleWriter();
                    break;
            }

            app.Write("Your Name is : Writer");
                count++;
        }
            Console.ReadKey();
        }
    }
}
