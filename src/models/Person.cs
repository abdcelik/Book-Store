using System;
using System.Collections.Generic;
using System.Text;

namespace Fusion
{
    class Person
    {
        public String name { get; set; }
        public String surname { get; set; }
        public int ID { get; }

        public Person(String name, String surname, int ID)
        {
            this.name = name;
            this.surname = surname;
            this.ID = ID;
        }

        public override string ToString() { return String.Format("Name: {0}\nSurname: {1}\nID: {2}\n", name, surname, ID); }
    }
}
