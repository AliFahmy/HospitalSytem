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
    public partial class findbydoc : Form
    {
        public findbydoc()
        {
            InitializeComponent();
        }

        private void searchbyname_Click(object sender, EventArgs e)
        {
            string record;
            bool Doctor_Exist = false;
            string doctorid = "";
            int rec_len;
            byte[] record_b;
            //open file
            FileStream Doctor_File = new FileStream("doctor.txt", FileMode.Open);
            string[] fields;
            //search by doctor name
            while (Doctor_File.Position != Doctor_File.Length)
            {
                dc doc = new dc();
                rec_len = Doctor_File.ReadByte();
                record_b = new byte[rec_len];
                record = "";
                Doctor_File.Read(record_b, 0, rec_len);
                for (int i = 0; i < rec_len; i++)
                    record += (char)record_b[i];
                fields = record.Split('*');
                 doc.id= fields[0];
                doc.name = fields[1];
                doc.specialty = fields[2];
                if (doc.name == Doctor_TextBox.Text)
                {
                    doctorid = doc.id;
                    Doctor_Exist = true;
                    break;
                }
            }
            if (!Doctor_Exist)
            {
                MessageBox.Show("Doctor not Found");
            }

            Doctor_File.Close();
            //making table
            DataTable Table = new DataTable();
            Table.Columns.Add("ID", typeof(string));
            Table.Columns.Add("Patient Name", typeof(string));
            Table.Columns.Add("Disease", typeof(string));
            Table.Columns.Add("Doctor's ID", typeof(string));
            Table.Columns.Add("Appointment Date", typeof(string));
            
            //open file patient
            FileStream Patient_File = new FileStream("Patient.txt", FileMode.Open);
            string[] pat_field;
            //display patient by doctor name
            while (Patient_File.Position != Patient_File.Length)
            {

                patient patien = new patient();
                rec_len = Patient_File.ReadByte();
                record_b = new byte[rec_len];
                record = "";
                Patient_File.Read(record_b, 0, rec_len);
                for (int i = 0; i < rec_len; i++)
                    record += (char)record_b[i];
                pat_field = record.Split('@');
                patien.id = pat_field[0];
                patien.name = pat_field[1];
                patien.disease = pat_field[2];
                patien.doctor_id = pat_field[3];
                patien.appointment_date = pat_field[4];
                if (patien.doctor_id == doctorid)
                {
                    Table.Rows.Add(patien.id, patien.name, patien.disease, patien.doctor_id, patien.appointment_date);

                }
            }
            data_findbyname.DataSource = Table;
            Patient_File.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }

        private void findbydoc_Load(object sender, EventArgs e)
        {

        }
    }
    }

