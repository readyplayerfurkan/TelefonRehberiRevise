using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiRevise.Data;

namespace TelefonRehberiRevise.Operations
{
    public class Searching : AllOperations
    {
        public override void SearchingOperation()
        {
            while (true)
            {
                Console.WriteLine("Lütfen arama yapmak için kriteri seçiniz:");
                Console.WriteLine("******************************************");
                Console.WriteLine("* İsim ve ya soyisme göre arama yapmak için: (1)");
                Console.WriteLine("* Numaraya göre arama yapmak için: (2)");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    ExisitingNumbers searchingPeople = new();
                    Console.WriteLine("Arama yapılacak ismi ve ya soyismi giriniz:");
                    List<Person> allSearchingPeople = searchingPeople.SearchTheNameOrSurname(Console.ReadLine());

                    foreach (Person person in allSearchingPeople)
                    {
                        Console.WriteLine("Arama sonuçlarınız:");
                        Console.WriteLine("*******************");
                        Console.WriteLine($"İsim: {person.Name}");
                        Console.WriteLine($"Soyisim: {person.Surname}");
                        Console.WriteLine($"Numara: {person.Number}");
                        Console.WriteLine("-");
                    }

                    Console.WriteLine("* Yeni bir arama yapmak için: (1)");
                    Console.WriteLine("* Ana menüye dönmek için: (2)");
                    string choose1 = Console.ReadLine();
                    if (choose1 == "1")
                        continue;
                    else if (choose1 == "2")
                        break;
                    
                }
                else if (choose == "2")
                {
                    ExisitingNumbers searchingPeople = new();
                    Console.WriteLine("Arama numarayı giriniz:");
                    List<Person> allSearchingPeople = searchingPeople.SearchTheNumber(Console.ReadLine());

                    foreach (Person person in allSearchingPeople)
                    {
                        Console.WriteLine("Arama sonuçlarınız:");
                        Console.WriteLine("*******************");
                        Console.WriteLine($"İsim: {person.Name}");
                        Console.WriteLine($"Soyisim: {person.Surname}");
                        Console.WriteLine($"Numara: {person.Number}");
                        Console.WriteLine("-");
                    }

                    Console.WriteLine("* Yeni bir arama yapmak için: (1)");
                    Console.WriteLine("* Ana menüye dönmek için: (2)");
                    string choose1 = Console.ReadLine();
                    if (choose1 == "1")
                        continue;
                    else if (choose1 == "2")
                        break;
                }
            }
        }
    }
}
