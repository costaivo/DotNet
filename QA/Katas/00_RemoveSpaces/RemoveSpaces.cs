namespace Katas
{
    public class RemoveSpaces
    {
        public static string NoSpace(string input)
        {
            //Remove Extra Spaces
            string result = input.Trim();

            string finalResult = "";
            foreach(char c in result.ToCharArray())
            {
                if(!char.IsWhiteSpace(c))
                {
                    finalResult += c;
                }
                
            }
            return finalResult;
        }

        #region Optimized Solution
        public static string NoSpaceOptimized(string input)
        {
            //return input.Replace(" ", string.Empty);
            return input.Replace(" ", "");
        }
        #endregion

        #region Twisted Problem
        //Remove ExclamationMarks
        //Write function RemoveExclamationMarks which removes all exclamation marks from a given string.
        public static string NoExclamationMarks(string input)
        {
            return input.Replace(" ", string.Empty);
        }
        #endregion
    }
}
