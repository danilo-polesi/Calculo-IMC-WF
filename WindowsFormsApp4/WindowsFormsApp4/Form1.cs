using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Seja Bem Vindo! \n Vou ajudar voçê a lutar contra a obesidade!");
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesoIdealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesoIdeal2 frmPesoIdeal = new frmPesoIdeal2();
            frmPesoIdeal.ShowDialog();
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIMC2 frmIMC = new frmIMC2();
            frmIMC.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("calc.exe");
            process.WaitForExit();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("mspaint.exe");
            process.WaitForExit();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("notepad.exe");
            process.WaitForExit();
        }

        private void recursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("resmon.exe");
            process.WaitForExit();
        }

        private void monitorDeDesempenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("perfmon.exe");
            process.WaitForExit();
        }

        private void tecladoVirtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("osk.exe");
            process.WaitForExit();
        }

        private void lupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("Magnify.exe");
            process.WaitForExit();
        }

        private void gerenciadorDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("LaunchTM.exe");
            process.WaitForExit();
        }

        private void diagnosticoDoDirectXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("dxdiag.exe");
            process.WaitForExit();
        }

        private void desfragmentadorDeDiscoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("dfrgui.exe");
            process.WaitForExit();
        }

        private void painélDeControleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("control.exe");
            process.WaitForExit();
        }

        private void promptDeComandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("cmd.exe");
            process.WaitForExit();
        }

        private void mapaDeCaracteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("charmap.exe");
            process.WaitForExit();
        }

        private void controleDeContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("UserAccountControlSettings.exe");
            process.WaitForExit();
        }

        private void editorDeRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("regedt32.exe");
            process.WaitForExit();
        }

        private void configuraçãoDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("msconfig.exe");
            process.WaitForExit();
        }

        private void remoçãoDeSoftwareMalintencionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("MRT.exe");
            process.WaitForExit();
        }
    }
    }

