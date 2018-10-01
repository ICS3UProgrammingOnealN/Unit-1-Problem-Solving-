using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotOneal
{
    public partial class SchoolMascotForm : Form
    {
        public SchoolMascotForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mniManCity_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Man City";
        }

        private void mniBarcelona_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Barcelona";

        }

        private void mniWolvesFc_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Wolves fc";
        }

        private void mniArsenal_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Arsenal";
        }
    }
}
