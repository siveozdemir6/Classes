using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public void WriteInfo()
        {
            Console.WriteLine("İsim: " + Name + " Soyisim: " + Surname + " Doğum Tarihi: " + BirthDate );
        }
    }
}
