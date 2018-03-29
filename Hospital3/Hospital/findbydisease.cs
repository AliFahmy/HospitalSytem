using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Hospital
{
    public partial class findbydisease : Form
    {
        public findbydisease()
        {
            InitializeComponent();
        }

        private void search_for_disease_Click(object sender, EventArgs e)
        {
            bool exist = false;
            string[] fields;
            FileStream fs = new FileStream("patient.txt", FileMode.Open);
            // adding columns
            DataTable dataTable_patients_with_disease = new DataTable();
            dataTable_patients_with_disease.Columns.Add("ID", typeof(string));
            dataTable_patients_with_disease.Columns.Add("Name", typeof(string));
            dataTable_patients_with_disease.Columns.Add("Disease", typeof(string));
            dataTable_patients_with_disease.Columns.Add("Doctor's ID", typeof(string));
            dataTable_patients_with_disease.Columns.Add("Appointment date", typeof(string));
            while (fs.Position != fs.Length)
            {
                patient patien = new patient();
                int rec_len;
                rec_len = fs.ReadByte();
                byte[] record_b = new byte[rec_len];
                string record = "";
                fs.Read(record_b, 0, rec_len);
                for (int i = 0; i < rec_len; i++)
                    record += (char)record_b[i];
                fields = record.Split('@');
                patien.id = fields[0];
                patien.name = fields[1];
                patien.disease = fields[2];
                patien.doctor_id = fields[3];
                patien.appointment_date = fields[4];


                // checking of disease is equal to written disease then adds a row to the table of patient's information
                if (patien.disease == Disease.Text)
                {
                    dataTable_patients_with_disease.Rows.Add(patien.id, patien.name, patien.disease, patien.doctor_id, patien.appointment_date);
                    exist = true;
                }


            }
            if (exist == false)
                MessageBox.Show("No patients are found ");

            fs.Close();

            Data_of_patients_with_disease_table.DataSource = dataTable_patients_with_disease;
        }

        private void back_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
