using System;

namespace Fusion.Entity
{
    public class Person : EntityBase
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Address { get; set; } = "-";
        public String PhoneNumber { get; set; } = "-";

        public Person(String Name, String Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public override string ToString() { return String.Format("Name: {0}\nSurname: {1}\nAddress: {2}\nPhone Number: {3}\n", Name, Surname, Address, PhoneNumber); }
    }
}