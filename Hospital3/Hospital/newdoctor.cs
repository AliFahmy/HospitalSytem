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
    public partial class newdoctor : Form
    {
        public newdoctor()
        {
            InitializeComponent();
        }

        private void addnewdoc_Click(object sender, EventArgs e)
        {

            if (ID_Textbox.Text.Length == 0 || Name_TextBox.Text.Length == 0 || Speciality_TextBox.Text.Length == 0)
            {
                MessageBox.Show("Wrong Entry");
            }
            else
            {
                dc doctor = new dc();
                doctor.id = ID_Textbox.Text;
                doctor.name = Name_TextBox.Text;
                doctor.specialty = Speciality_TextBox.Text;
                string record = "";
                int rec_len;
                byte[] record_b;
                record += doctor.id + "*" + doctor.name + "*" + doctor.specialty;
                rec_len = record.Length;
                record_b = new byte[rec_len];
                FileStream Doctor_File = new FileStream("doctor.txt", FileMode.Append);
                for (int i = 0; i < rec_len; i++)
                {
                    record_b[i] = (byte)record[i];
                }
                Doctor_File.WriteByte((byte)rec_len);
                Doctor_File.Write(record_b, 0, rec_len);
                Doctor_File.Close();

                ID_Textbox.Text = "";
                Name_TextBox.Text = "";
                Speciality_TextBox.Text = "";
                MessageBox.Show("done");
            }
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            home hh = new home();
            hh.Show();
            this.Hide();
        }
    }
}
