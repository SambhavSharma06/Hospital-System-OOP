using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS___CA_ONE
{
    public class Nurse : Staff
    {
        public int Hours { get; set; }

        // Constructor
        public Nurse(string name, string address, string county, int age, string gender, string phone, string email, int hours)
            : base(name, address, county, age, gender, phone, email)
        {
            Hours = hours;
        }
    }
}