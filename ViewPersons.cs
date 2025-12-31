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
    public partial class ViewPersons : Form
    {
        public ViewPersons()
        {
            InitializeComponent();
        }

        AddPersons ap = new AddPersons();
        DataTable dt = new DataTable();

        private void patientBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = ap.viewPatient();
            dataGridView.DataSource = dt;
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = ap.viewDoctor();
            dataGridView.DataSource = dt;
        }

        private void nurseBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = ap.viewNurse();
            dataGridView.DataSource = dt;
        }

        private void querycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (querycomboBox.SelectedIndex == 0)
            {
                dt.Clear();
                dt = ap.viewMaleNurses();
                dataGridView.DataSource = dt;
            }
            else if (querycomboBox.SelectedIndex == 1)
            {
                dt.Clear();
                dt = ap.viewPatientsAbove25();
                dataGridView.DataSource = dt;
            }
            else if (querycomboBox.SelectedIndex == 2)
            {
                dt.Clear();
                dt = ap.viewHighPaidDoctors();
                dataGridView.DataSource = dt;
            }
            else if (querycomboBox.SelectedIndex == 3)
            {
                dt.Clear();
                dt = ap.viewOvertimeNurses();
                dataGridView.DataSource = dt;
            }
        }
    }
}
