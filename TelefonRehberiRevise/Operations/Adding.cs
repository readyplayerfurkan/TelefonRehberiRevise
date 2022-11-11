using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiRevise.Data;

namespace TelefonRehberiRevise.Operations
{
    public class Adding : AllOperations
    {
        public override void AddingOperation()
        {
            while (true)
            {
                Console.WriteLine("Lütfen isim giriniz:");
                Console.WriteLine("Lütfen soyisim giriniz:");
                Console.WriteLine("Lütfen telefon numarasını giriniz:");

                string name = Console.ReadLine();
                string surname = Console.ReadLine();
                string number = Console.ReadLine();

                ExisitingNumbers addingNewNumber = new ExisitingNumbers();
                addingNewNumber.AddNewNumber(name, surname, number);

                Console.WriteLine("Ekleme işimi başarıyla tamamlandı.");
                Console.WriteLine("* Başka bir ekleme işi yapmak için: (1)");
                Console.WriteLine("* Ana menüye dönmek için: (2)");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                    continue;
                else if (choose == 2)
                    break;
            }
        }
    }
}
