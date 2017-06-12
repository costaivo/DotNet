namespace ClassObjects
{
   public class Program
    {
        static void Main(string[] args)
        {
        }
    }


    #region Class Defination

    public class Animal
    {
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }
    }

    //Inheritence
    public class Tiger: Animal
    {

    }


    //Access Modifiers
    //Private
    //Public
    //Internal
    //Protected
    #endregion
}
