using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiRevise.Data;

namespace TelefonRehberiRevise.Operations
{
    public class Editinig : AllOperations
    {
        public override void EditiingOperation()
        {
            while (true)
            {
                Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ve ya soyadını giriniz:");
                string editingPerson = Console.ReadLine();
                ExisitingNumbers editPerson = new();
                var item = editPerson.FindNameorSurname(editingPerson);

                if (item != null)
                {
                    Console.WriteLine($"{item.Name}" + " " + $"{item.Surname} adlı kişinin yeni değerlerini giriniz");
                    editPerson.EditTheNumber(item);
                    Console.WriteLine("Güncelleme işlemi tamamlandı.");
                    Console.WriteLine("* Yeni bir güncelleme işi yapmak için: (1)");
                    Console.WriteLine("* Ana menüye dönmek için: (2)");

                    string choose = Console.ReadLine();

                    if (choose == "1")
                        continue;
                    else if (choose == "2")
                        break;
                }

                else
                {
                    Console.WriteLine("Aradığınız kriterlerde bir kişi bulunamadı.");
                    Console.WriteLine("* Tekrar denemek için: (1)");
                    Console.WriteLine("* Ana menüye dönmek için: (2)");

                    string choose = Console.ReadLine();

                    if (choose == "1")
                        continue;
                    else if (choose == "2")
                        break;
                }
            }
        }
    }
}
