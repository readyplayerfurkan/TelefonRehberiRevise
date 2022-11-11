using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiRevise.Data;

namespace TelefonRehberiRevise.Operations
{
    public class Listing : AllOperations
    {
        public override void ListingOperation()
        {
            while (true)
            {
                ExisitingNumbers displayTheList = new();
                displayTheList.DisplayTheList();

                Console.WriteLine("* Ana menüye dönmek için: (1)");
                Console.WriteLine("* Listeyi tekrar görmek için: (2)");
                string choose = Console.ReadLine();
                if (choose == "1")
                    break;
                else if (choose == "2")
                    continue;
            }
        }
    }
}
