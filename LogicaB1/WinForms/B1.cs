using B1S;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Formulario = new Stock();
            Formulario.Show();
            this.Hide();
        }

        private void B1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cotiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new Coti();
            Formulario.Show();
            this.Hide();

        }

        private void sTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new ST();
            Formulario.Show();
            this.Hide();
        }

        private void lMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new ListaMaterial();
            Formulario.Show();
            this.Hide();

        }
    }
}
