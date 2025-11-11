using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Est
{
    public partial class Form3 : Form
    {   
        Conteo conteo = new Conteo();
        
        public Form3()
        {
            InitializeComponent();
            lblPermutacion.Text = "";
            lblSelecResult.Text = "";
        }

        private void btnPermutar_Click(object sender, EventArgs e)
        {
            
            
            int n = int.Parse(txtPermutar.Text);
            
            lblPermutacion.Text = conteo.Factorial(n).ToString();

            txtPermutar.Clear();



        }

        private void btnImporta_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSeleccN.Text);
            int k = int.Parse(txtSelecK.Text);

            lblSelecResult.Text = conteo.Permutacion(n, k).ToString();
            txtSeleccN.Clear();
            txtSelecK.Clear();
        }

        private void btnNoImporta_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSeleccN.Text);
            int k = int.Parse(txtSelecK.Text);

            lblSelecResult.Text = conteo.Combinacion(n, k).ToString();
            txtSeleccN.Clear();
            txtSelecK.Clear();
        }
    }
}
