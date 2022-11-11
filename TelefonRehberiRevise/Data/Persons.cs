using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiRevise.Data
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public Person(string name, string surname, string number) 
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
    }
}
