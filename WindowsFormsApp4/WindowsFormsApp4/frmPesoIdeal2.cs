using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class frmPesoIdeal2 : Form
    {
        public frmPesoIdeal2()
        {
            InitializeComponent();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                double num = 0.0;
                double num2 = 0.0;
                num = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "Feminino")
                {
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + (62.7 * num - 44.7) + " Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (cmbSexo.Text == "Masculino")
                {
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + (72.7 * num - 58.0) + " Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os valores informado", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
