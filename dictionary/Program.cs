namespace dictionary
{
    public delegate void ShowMessage(string message);
    internal class Program
    {
        static Dictionary<string, string> showUkrainian = new Dictionary<string, string>()
        {
            {"Ukraine", "Україна"},
            {"USA", "США"},
            {"Germany", "Німеччина"},
            {"France", "Франція"},
            {"Canada", "Канада"}
        };
        static Dictionary<string, string> showEnglish = new Dictionary<string, string>()
        {
            {"Україна", "Ukraine"},
            {"США", "USA"},
            {"Німеччина", "Germany"},
            {"Франція", "France"},
            {"Канада", "Canada"}
        };

        static void inUkrainian(string country)
        {
            if (showUkrainian.ContainsKey(country))
            {
                Console.WriteLine($"Translate: {showUkrainian[country]}");
            }
        }
        static void inEnglish(string country)
        {
            if (showEnglish.ContainsKey(country))
            {
                Console.WriteLine($"Translate: {showEnglish[country]}");
            }
        }
        static void Main(string[] args)
        {
            ShowMessage showMessage = null;
            bool exit = false;
            while (!exit) {
                Console.WriteLine("Choose language:");
                Console.WriteLine("1. English");
                Console.WriteLine("2.Ukrainian");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        showMessage = inEnglish;
                        break;
                    case "2":
                        showMessage = inUkrainian;
                        break;
                    case "3":
                        exit = true;
                        continue;
                }
                Console.WriteLine("Enter country: ");
                string country = Console.ReadLine();
                showMessage.Invoke(country);
            }
        }
    }
}
