using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS___CA_ONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.ShowDialog();
        }

        private void nurseBtn_Click(object sender, EventArgs e)
        {
            AddNurse addNurse = new AddNurse();
            addNurse.ShowDialog();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ViewPersons viewPersons = new ViewPersons();
            viewPersons.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
