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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        AddPersons ap = new AddPersons();

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string address = addresstextBox.Text;
            string county = countytextBox.Text;
            int age = int.Parse(agetextBox.Text);

            string gender = "Male";
            if (femaleRB.Checked == true)
            {
                gender = "female";
            }

            string phone = phonetextBox.Text;
            string email = emailtextBox.Text;

            double pay = double.Parse(paytextBox.Text);

            ap.AddDoctor(name, address, county, age, gender, phone, email, pay);
            MessageBox.Show("Doctor data added successfully!");

            clearData();
        }

        private void clearData()
        {
            nametextBox.Text = string.Empty;
            addresstextBox.Text = string.Empty;
            countytextBox.Text = string.Empty;
            agetextBox.Text = string.Empty;
            phonetextBox.Text = string.Empty;
            emailtextBox.Text = string.Empty;
            paytextBox.Text = string.Empty;
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
