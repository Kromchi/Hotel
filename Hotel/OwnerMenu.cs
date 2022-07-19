using static BetterBook.Hotel;
using static BetterBook.CleanMenu;

namespace OMenu
{
    public class OwnerMenu
    {
        public static void stuff(int userInput)
        {
            Console.WriteLine("Co byś chciał zrobić? \n");
            Console.WriteLine("1 - Dodaj Atrakcję \n");
            Console.WriteLine("2 - Zobacz istniejące atrakcje \n");
            Console.WriteLine("3 - Usuń atrakcje \n");
            Console.WriteLine("0 - Wyjście \n");


            userInput = int.Parse(Console.ReadLine());

            string opis = "tak";
            var name = new Attraction("<name>", opis);

            Console.WriteLine($"Nazwa: {name.name}, ");
        }

        

    }
    
    public class Attraction
    {
        public string name { get; }
        public string about { get; }

        public void AddAttraction(string name, string about)
        {

        }
        public void DeleteAttraction(string name, string about)
        {

        }
        public Attraction(string attractionName, string aboutAttraction)
        {
            attractionName = this.name;
            aboutAttraction = this.about;
        }
    }


}