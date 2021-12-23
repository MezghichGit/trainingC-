using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
       
            double a = double.Parse(textBoxE1.Text);
            double b = double.Parse(textBoxE2.Text);

            textBoxRes.Text = (a + b).ToString();
        }

        private void cmdDiff_Click(object sender, EventArgs e)
        {

        }
    }
}
