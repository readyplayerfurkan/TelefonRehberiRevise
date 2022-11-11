using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiRevise.Data;
using TelefonRehberiRevise.Operations;


namespace TelefonRehberiRevise
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Adding addingOperation = new();
                        addingOperation.AddingOperation();
                        break;
                    case "2":
                        Deleting removeOperation = new();
                        removeOperation.DeletingOperation();
                        break;
                    case "3":
                        Editinig editingOperation = new();
                        editingOperation.EditiingOperation();
                        break;
                    case "4":
                        Listing listingOperation = new();
                        listingOperation.ListingOperation();
                        break;
                    case "5":
                        Searching searchingOperation = new();
                        searchingOperation.SearchingOperation();
                        break;
                    default:
                        Console.WriteLine("Yanlış bir giriş yaptınız, lütfen tekrar deneyiniz.");
                        break;
                }
            }
        }
    }
}