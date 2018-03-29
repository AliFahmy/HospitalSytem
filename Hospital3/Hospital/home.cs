using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_newpatient_Click(object sender, EventArgs e)
        {
            newpatient np = new newpatient();
            np.Show();
            this.Hide();
        }

        private void add_newdoc_Click(object sender, EventArgs e)
        {
            newdoctor nd = new newdoctor();
            nd.Show();
            this.Hide();
        }

        private void findbydisease_Click(object sender, EventArgs e)
        {
            findbydisease f = new findbydisease();
            f.Show();
            this.Hide();
        }

        private void findbydoc_Click(object sender, EventArgs e)
        {
            findbydoc ff = new findbydoc();
            ff.Show();
            this.Hide();
        }
    }
}
