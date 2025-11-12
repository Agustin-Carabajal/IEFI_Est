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
    public partial class Form4 : Form
    {   
        MMM_Datos_Agrupados mm = new MMM_Datos_Agrupados();
        public Form4()
        {
            InitializeComponent();
            lblMMRes.Text = "";
        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            decimal limiteInferior = decimal.Parse(txtExtremoInferiorInterv.Text);
            decimal frecAbsInterv = decimal.Parse(txtFrecAbsInterv.Text);
            decimal frecAbsAntInterv = decimal.Parse(txtFrecAbsAnteriorInterv.Text);
            decimal frecAbsPostInterv = decimal.Parse(txtFrecAbsPostInterv.Text);
            decimal amplitudInterv = decimal.Parse(txtAmplitudInterv.Text);

            lblMMRes.Text = mm.Moda(limiteInferior, frecAbsInterv, frecAbsAntInterv, frecAbsPostInterv, amplitudInterv).ToString();

            ClearTodo();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            decimal limiteInferior = decimal.Parse(txtExtremoInferiorInterv.Text);
            decimal frecAbsInterv = decimal.Parse(txtFrecAbsInterv.Text);
            decimal sumatoriafi = decimal.Parse(txtSumatoriafi.Text);
            decimal frecAcumAntInterv = decimal.Parse(txtFrecAcumAnterior.Text);
            decimal amplitudInterv = decimal.Parse(txtAmplitudInterv.Text);

            lblMMRes.Text = mm.Media(limiteInferior, sumatoriafi, frecAcumAntInterv, frecAbsInterv, amplitudInterv).ToString();

            ClearTodo();
        }

        public void ClearTodo()
        {

            txtAmplitudInterv.Clear();
            txtExtremoInferiorInterv.Clear();
            txtFrecAbsAnteriorInterv.Clear();
            txtFrecAbsInterv.Clear();
            txtFrecAbsPostInterv.Clear();
            txtAmplitudInterv.Clear();
            txtSumatoriafi.Clear();
            txtFrecAcumAnterior.Clear();
        }

        private void txtFrecAbsInterv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
