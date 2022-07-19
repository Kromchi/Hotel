using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static BetterBooking.Core.Attractions.OwnerMenu;
using static BetterBooking.Core.Attractions.CleanMenu;

namespace BetterBooking.Core.Attractions // Note: actual namespace depends on the project name.
{
    internal class AttractionMenu
    {
        

         static void Main(string[] args)
        {
            int userInput = 999;
            Console.WriteLine("Witaj! \n");
            while (userInput != 0)
            {
                
                Console.WriteLine("Wybierz jedną z opcji: \n");
                Console.WriteLine("1 - Zaloguj się");
                Console.WriteLine("2 - Przeglądaj Atrakcje");
                Console.WriteLine("0 - Wyjście");

                string pw = "123";
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Wprowadź Hasło: ");
                        string pwCheck = Console.ReadLine();
                        if (pwCheck == pw)
                        {
                            Console.Clear();
                            Console.WriteLine("Pomyślnie Zalogowano! \n");
                            BetterBooking.Core.Attractions.OwnerMenu.stuff(userInput);

                        }
                        else Console.WriteLine("Złe hasło! \n");

                        break;

                    case 2:
                        BetterBooking.Core.Attractions.CleanMenu.View();


                        break;
                    
                    default: 
                        if (userInput == 0)
                        {
                            Console.WriteLine("Wybierz jeszcze raz \n");
                        }
                        
                        break;



                }
            };
            
            //Console.Clear();
        }
    }
}