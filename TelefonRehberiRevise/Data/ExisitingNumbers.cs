using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiRevise.Data
{
    public class ExisitingNumbers
    {
        public static List<Person> peopleList = new List<Person>();

        static ExisitingNumbers()
        {
            peopleList.Add(new Person("Furkan", "Yılmaz", "05555555555"));
            peopleList.Add(new Person("Flip", "Yazılımcı", "05555555554"));
            peopleList.Add(new Person("Köroğlu", "Balaban", "05555555553"));
            peopleList.Add(new Person("Zagor", "Balaban", "05555555552"));
            peopleList.Add(new Person("Hilal", "Turan", "05555555551"));
            peopleList.Add(new Person("Acil", "Ambulans", "112"));
            peopleList.Add(new Person("Acil", "Polis", "155"));
            peopleList.Add(new Person("Bilinmeyen", "Numaralar", "11880"));
        }
        
        public Person FindNameorSurname(string name)
        {
            var item = peopleList.Find(x => x.Name == name || x.Surname == name);
            return item;
        }

        public List<Person> SearchTheNumber(string number)
        {
            var item = peopleList.FindAll(x => x.Number == number);
            return item;
        }

        public List<Person> SearchTheNameOrSurname(string name)
        {
            var item = peopleList.FindAll(x => x.Name.Equals(name) || x.Surname.Equals(name));
            return item;
        }

        public void RemovingName(Person person)
        {
            peopleList.Remove(person);
        }

        public void AddNewNumber(string name, string surname, string number)
        {
            peopleList.Add(new Person(name, surname, number));
        }

        public void EditTheNumber(Person person)
        {
            Console.WriteLine("İsim:");
            person.Name = Console.ReadLine();
            Console.WriteLine("Soyisim:");
            person.Surname = Console.ReadLine();
            Console.WriteLine("Numara:");
            person.Number = Console.ReadLine();
        }

        public void DisplayTheList()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***************");
            foreach (Person people in peopleList) 
            {
                Console.WriteLine("İsim: " + people.Name);
                Console.WriteLine("Soyisim: " + people.Surname);
                Console.WriteLine("Telefon numarası: " + people.Number);
            }
        }
        
    }
}
