using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;

namespace HMS___CA_ONE
{
    internal class AddPersons : DAO
    {

        SqlDataAdapter ada;
        DataTable dt = new DataTable();

        // INSERT DATA

        public void AddPatient(string name, string address, string county, int age, string gender, string phone, string email, int patNum)
        {
            string insert = "INSERT INTO Patients(Name, Address, County, Age, Gender, Phone, Email, PatientNumber) VALUES(@name, @address, @county, @age, @gender, @phone, @email, @patNum)";

            SqlCommand cmd = new SqlCommand(insert, OpenCon());

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@patNum", patNum);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddDoctor(string name, string address, string county, int age, string gender, string phone, string email, double pay)
        {
            string insert = "INSERT INTO Doctors(Name, Address, County, Age, Gender, Phone, Email, Pay) VALUES(@name, @address, @county, @age, @gender, @phone, @email, @pay)";

            SqlCommand cmd = new SqlCommand(insert, OpenCon());

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pay", pay);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddNurse(string name, string address, string county, int age, string gender, string phone, string email, int hours)
        {
            string insert = "INSERT INTO Nurses(Name, Address, County, Age, Gender, Phone, Email, Hours) VALUES(@name, @address, @county, @age, @gender, @phone, @email, @hours)";

            SqlCommand cmd = new SqlCommand(insert, OpenCon());

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@hours", hours);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        // VIEW DATA

        public DataTable viewDoctor()
        {
            ada = new SqlDataAdapter("GetAllDoctors", OpenCon());
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            ada.Fill(dt);
            CloseCon();
            return dt;
        }

        public DataTable viewPatient()
        {
            ada = new SqlDataAdapter("GetAllPatients", OpenCon());
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            ada.Fill(dt);
            CloseCon();
            return dt;
        }


        public DataTable viewNurse()
        {
            ada = new SqlDataAdapter("GetAllNurses", OpenCon());
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            ada.Fill(dt);
            CloseCon();
            return dt;
        }

        public DataTable viewMaleNurses()
        {
            ada = new SqlDataAdapter("GetMaleNurses", OpenCon());
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            ada.Fill(dt);
            CloseCon();
            return dt;
        }

        public DataTable viewPatientsAbove25()
        {
            ada = new SqlDataAdapter("GetPatientsAbove25", OpenCon());
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            ada.Fill(dt);
            CloseCon();
            return dt;
        }

        public DataTable viewHighPaidDoctors()
        {
            ada = new SqlDataAdapter("GetDoctorsWithHighPay", OpenCon());
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            ada.Fill(dt);
            CloseCon();
            return dt;
        }

        public DataTable viewOvertimeNurses()
        {
            ada = new SqlDataAdapter("GetNursesWorkingOver40Hours", OpenCon());
            ada.SelectCommand.CommandType = CommandType.StoredProcedure;
            ada.Fill(dt);
            CloseCon();
            return dt;
        }



    }
}
