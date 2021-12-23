using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

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

            textBoxRes.Text = (Calcul.somme(a,b)).ToString();
        }

        private void cmdDiff_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxE1.Text);
            double b = double.Parse(textBoxE2.Text);

            textBoxRes.Text = (Calcul.diff(a, b)).ToString();

        }

        private void cmdProd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxE1.Text);
            double b = double.Parse(textBoxE2.Text);

            textBoxRes.Text = (Calcul.produit(a, b)).ToString();
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxE1.Text);
            double b = double.Parse(textBoxE2.Text);
            try
            {
                if (b == 0)
                { throw new ArithmeticException("Attention division par Zéro"); }
                else 
                {
                    textBoxRes.Text = (Calcul.div(a, b)).ToString();
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Alerte", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
    }
}
