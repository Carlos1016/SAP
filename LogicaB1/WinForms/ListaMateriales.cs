using LogicaB1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;
using static LogicaB1.Modelos;

namespace B1S
{
    public partial class ListaMaterial : Form
    {
        SAPB1 _sap;
        public ListaMaterial()
        {
            InitializeComponent();
            _sap = new SAPB1();
            _sap.login();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            //hola
            _sap.login();

            var x = _sap.Listamateriales(txtCodigo.Text.ToString());

            if (x.TreeCode != null)
            {

                lbcodigo.Text = x.TreeCode;
                lbdescripcion.Text = x.ProductDescription;
                dataGridView1.DataSource = x.ProductTreeLines;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.Columns["Price"].Visible = false;
                dataGridView1.Columns["Currency"].Visible = false;

                label4.Text = x.ProductTreeLines.Sum(c => c.Costo).ToString();
            }
            else
            {

                MessageBox.Show("Articulo no encontrado " + txtCodigo.Text.ToString());

            }




        }

        private void ListaMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Formulario = new B1();
            Formulario.Show();
        }
    }
}
