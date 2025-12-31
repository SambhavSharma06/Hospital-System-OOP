using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS___CA_ONE
{
    public class Patient : Person
    {
        public int PatientNumber { get; set; }

        // Constructor
        public Patient(string name, string address, string county, int age, string gender, string phone, string email, int patientNumber)
            : base(name, address, county, age, gender, phone, email)
        {
            PatientNumber = patientNumber;
        }
    }
}
