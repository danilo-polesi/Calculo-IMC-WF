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
    public partial class frmIMC2 : Form
    {
        public frmIMC2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAlltura.Clear();
            txtPeso.Clear();
            txtAlltura.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				num = double.Parse(txtPeso.Text);
				num2 = double.Parse(txtAlltura.Text);
				num3 = Math.Round(num / (num2 * num2), 2);
				if (num3 < 18.5)
				{
					MessageBox.Show("Seu IMC é " + num3 + "\n Você está abaixo do peso", "Pratique atividade física e beba água", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (num3 >= 18.5 && num3 <= 24.9)
				{
					MessageBox.Show("Seu IMC é " + num3 + "\n Parabéns, você está com seu peso ideal", "Pratique atividade física e beba água", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (num3 >= 25.0 && num3 <= 29.9)
				{
					MessageBox.Show("Seu IMC é " + num3 + "\n você está com Sobrepeso", "Pratique atividade física e beba água", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (num3 >= 30.0 && num3 <= 34.9)
				{
					MessageBox.Show("Seu IMC é " + num3 + "\n você está na Obesidade grau 1", "Pratique atividade física e beba água", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (num3 >= 35.0 && num3 <= 39.9)
				{
					MessageBox.Show("Seu IMC é " + num3 + "\n você está na Obesidade grau 2", "Pratique atividade física e beba água", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					MessageBox.Show("Seu IMC é " + num3 + "\n você está na Obesidade grau 3", "Pratique atividade física e beba água", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Verifique os valores informados", "Pratique atividade física e beba água", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
    }
}
