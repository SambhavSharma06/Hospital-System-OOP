using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS___CA_ONE
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Constructor
        public Person(string name, string address, string county, int age, string gender, string phone, string email)
        {
            Name = name;
            Address = address;
            County = county;
            Age = age;
            Gender = gender; 
            Phone = phone;
            Email = email;
        }
    }

}
