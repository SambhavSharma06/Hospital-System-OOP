using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS___CA_ONE
{
    public class Staff : Person
    {
        // Constructor
        public Staff(string name, string address, string county, int age, string gender, string phone, string email)
            : base(name, address, county, age, gender, phone, email)
        {
        }
    }
}
