using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiRevise.Data;

namespace TelefonRehberiRevise.Operations
{
    public class Deleting : AllOperations
    {
        public override void DeletingOperation()
        {
            while (true)
            {
                Console.WriteLine("Lütfen silmek istediğiniz kişinin adını veya soyadını giriniz:");
                string input = Console.ReadLine();
                ExisitingNumbers removingNumber = new ExisitingNumbers();
                var item = removingNumber.FindNameorSurname(input);
                if (item != null)
                {
                    Console.WriteLine($"{item.Name}" + " " + $"{item.Surname} adlı kişi rehberden silinmek üzere, onaylıyor musunuz? y/n");
                    string yesOrNo = Console.ReadLine();                 
                    if (yesOrNo == "y")
                    {
                        removingNumber.RemovingName(item);
                        Console.WriteLine("Silme işlemi başarıyla gerçekleşti.");
                        Console.WriteLine("* Başka bir silme işlemi yapmak için: (1)");
                        Console.WriteLine("* Ana menüye dönmek için: (2)");
                        int choose = int.Parse(Console.ReadLine());
                        if (choose == 1)
                            continue;
                        else if (choose == 2)
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        Console.WriteLine("* Başka bir silme işlemi yapmak için: (1)");
                        Console.WriteLine("* Ana menüye dönmek için: (2)");
                        int choose = int.Parse(Console.ReadLine());
                        if (choose == 1)
                            continue;
                        else if (choose == 2)
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Kişi bulunamadı.");
                    Console.WriteLine("* Yeni bir arama yapmak için: (1)");
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
}
