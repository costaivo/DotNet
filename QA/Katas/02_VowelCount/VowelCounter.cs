using System.Linq;

namespace Katas
{
    public class VowelCounter
    {
       

        public int GetVowelCount(string inputString)
        {

            int vowelCount =0;
            if(string.IsNullOrWhiteSpace(inputString))
                return vowelCount;

            foreach(char c in inputString.Trim().ToCharArray())
            {
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c=='A' || c=='E' || c== 'I' || c== 'O' || c=='U')
                    vowelCount++;
            }
            return vowelCount;
        }

        public int GetVowelCount2(string inputString)
        {
            int vowelCount =0;

            foreach(char c in inputString.Trim().ToLower().ToCharArray())
            {
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    vowelCount++;
            }
            return vowelCount;
        }

        public int GetVowelCount3(string inputString)
        {
            int vowelCount =0;

            //Write your awesome code here
            string vowels ="aeiou";

            foreach(char c in inputString.Trim().ToLower().ToCharArray())
            {
                if(vowels.Contains(c))
                    vowelCount++;
            }
            return vowelCount;
        }


        public int GetVowelCount4(string inputString)
        {

            //Write your awesome code here
            string vowels ="aeiou";

            return inputString.ToLower().Count(x => vowels.IndexOf(x) != -1);
        }

        public int GetVowelCount5(string inputString)
        {
            return inputString.ToLower().Count(x => "aeiou".IndexOf(x) != -1);
        }
    }
}
