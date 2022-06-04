using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int CompanyId { get; set; }

        public Person() { }

        public Person(int id, string name, string surname, DateTime birthdate, int companyId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            CompanyId = companyId;
        }
    }

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Company(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
