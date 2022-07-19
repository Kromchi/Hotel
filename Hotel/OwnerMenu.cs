using static BetterBook.Hotel;

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

        }
        
    }
}