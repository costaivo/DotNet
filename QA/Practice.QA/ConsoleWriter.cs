using System;

namespace Practice.QA
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string Message)
        {
            Console.WriteLine("Hello World");
        }
    }

    public class PDFWriter:IWriter
    {
        public void Write(string Message)
        {
            Console.WriteLine("Hello World -- I am an PDF writer ");
        }


    }

    public class ExcelWriter : IWriter
    {
        public void Write(string Message)
        {
            Console.WriteLine("Hello World -- Iam an excel Writer");
        }


    }
}
