namespace Practice.QA
{
    interface IWriter
    {
         void Write(string Message);
    }

    interface ISuperWriter:IWriter
    {
        void SuperWrite(string Message);
    }
}
