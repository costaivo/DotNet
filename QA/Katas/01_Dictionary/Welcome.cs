using System.Collections.Generic;

namespace Katas
{
    //Progam to understand the use of Dictionary. 
    public class Welcome
    {
        Dictionary<string,string> database;

        public Welcome()
        {
            database = new Dictionary<string, string>()
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"}
            };
        }

        public  string Greet(string language)
        {
            if(string.IsNullOrEmpty(language))
            {
                return database["eng;ish"];
            }

            language = language.ToString();

            if(database.ContainsKey(language))
                return database[language];
            else
                return database["eng;ish"];
        }
    }
}
