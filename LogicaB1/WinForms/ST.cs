using LogicaB1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogicaB1.Modelos;

namespace WinForms
{
    public partial class ST : Form
    {

        SAPB1 _sap;
        public ST()
        {
            InitializeComponent();
            _sap = new SAPB1();
            _sap.login();
        }

        private void ST_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _sap.login();
            var x = _sap.SolicitudTraslado(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridViewST.DataSource = x;
            dataGridViewST.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridViewST_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el elemento seleccionado
                var elementoSeleccionado = dataGridViewST.Rows[e.RowIndex].DataBoundItem as SolicitudTraslado;

                // Hacer algo con el elemento seleccionado
                if (elementoSeleccionado != null)
                {

                    var res = _sap.SolicitudTraslado(elementoSeleccionado.DocEntry);

                    dataGridViewSTInfo.DataSource = res;
                    dataGridViewSTInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);



                }
            }

        }

        private void ST_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Formulario = new B1();
            Formulario.Show();
        }
    }
}
