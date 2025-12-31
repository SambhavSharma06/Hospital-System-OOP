using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS___CA_ONE
{
    public class Doctor : Staff
    {
        public decimal Pay { get; set; }

        // Constructor
        public Doctor(string name, string address, string county, int age, string gender, string phone, string email, decimal pay) : base(name, address, county, age, gender, phone, email)
        {
            Pay = pay;
        }
    }
}
