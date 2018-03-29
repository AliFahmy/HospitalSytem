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
    public partial class newpatient : Form
    {
        public newpatient()
        {
            InitializeComponent();
        }

        private void add_patient_Click(object sender, EventArgs e)
        {

            if (ID.Text.Length == 0 || Name.Text.Length == 0 || Disease.Text.Length == 0 || Doctor_ID_textbox.Text.Length == 0 || Date_textbox.Text.Length == 0)
            {
                MessageBox.Show("Wrong Entry");
            }
            else
            {
                patient patien = new patient();
                int recordlength;
                patien.id = ID.Text;
                patien.name = Name.Text;
                patien.disease = Disease.Text;
                patien.doctor_id = Doctor_ID_textbox.Text;
                patien.appointment_date = Date_textbox.Text;
                string record = "";
                record += patien.id + "@" + patien.name + "@" + patien.disease + "@" + patien.doctor_id + "@" + patien.appointment_date;
                recordlength = record.Length;
                byte[] byterecord = new byte[recordlength];
                for (int i = 0; i < recordlength; i++)
                {
                    byterecord[i] = (byte)record[i];
                }
                FileStream PatientFile = new FileStream("Patient.txt", FileMode.Append);
                PatientFile.WriteByte((byte)recordlength);
                PatientFile.Write(byterecord, 0, recordlength);
                PatientFile.Close();
                ID.Text = "";
                Name.Text = "";
                Disease.Text = "";
                Doctor_ID_textbox.Text = "";
                Date_textbox.Text = "";
                MessageBox.Show("done");
            }
            
        }

       
        private void back_click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
