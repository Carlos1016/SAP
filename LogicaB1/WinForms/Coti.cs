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
using static LogicaB1.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class Coti : Form
    {

        SAPB1 _sap;
        List<Cotizaciones> listacoti;
        public Coti()
        {
            InitializeComponent();
            _sap = new SAPB1();
            _sap.login();
            listacoti = new List<Cotizaciones>();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            _sap.login();
            var x = _sap.ArticulosEX(txtCodigo.Text.ToString());

            if (x)
            {
                var respuesta = _sap.Articulos(txtCodigo.Text);

                txtCodigo.Text = respuesta.ItemCode;
                txtAdicional.Text = respuesta.SWW;
                txtDescripcion.Text = respuesta.ItemName;
                if (respuesta.ItemPrices != null)
                {
                    textPrecio.Text = respuesta.ItemPrices[0].Price.ToString();
                }

                var bodegasOrdenadas = respuesta.Bodegas.OrderByDescending(b => b.InStock).ToList();
                dataGridView.DataSource = bodegasOrdenadas;
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView.Columns["CodigoAlmacen"].Visible = false;
            }

            else
            {
                MessageBox.Show("Articulo no encontrado " + txtCodigo.Text.ToString());
            }
        }

        private void Coti_Load(object sender, EventArgs e)
        {

        }

        private void Coti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Formulario = new B1();
            Formulario.Show();

        }

        private async void txtDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            txtCodigo.Clear();
            txtAdicional.Clear();
            textPrecio.Clear();


            await Task.Run(async () =>
            {
                await Task.Delay(100);

                _sap.login();
                var x = _sap.buscardescripcion(txtDescripcion.Text.ToString());

                // Actualizar el DataGridView en el subproceso de la interfaz de usuario
                Invoke((MethodInvoker)delegate
                {
                    dataGridView.DataSource = x;
                    dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView.Columns["SWW"].Visible = false;
                });
            });


        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el elemento seleccionado
                var elementoSeleccionado = dataGridView.Rows[e.RowIndex].DataBoundItem as Item;

                // Hacer algo con el elemento seleccionado
                if (elementoSeleccionado != null)
                {


                    var respuesta = _sap.Articulos(elementoSeleccionado.ItemCode);

                    txtCodigoSap.Text = respuesta.ItemCode;
                    txtCodigo.Text = respuesta.ItemCode;
                    txtAdicional.Text = respuesta.SWW;
                    txtDescripcion.Text = respuesta.ItemName;
                    if (respuesta.ItemPrices != null)
                    {
                        textPrecio.Text = respuesta.ItemPrices[0].Price.ToString();
                    }




                    var bodegasOrdenadas = respuesta.Bodegas.OrderByDescending(b => b.InStock).ToList();
                    dataGridView.DataSource = bodegasOrdenadas;
                    dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView.Columns["CodigoAlmacen"].Visible = false;
                }
            }

        }

        private async void txtAdicional_KeyUp(object sender, KeyEventArgs e)
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            textPrecio.Clear();


            await Task.Run(async () =>
            {
                await Task.Delay(100);

                _sap.login();
                var x = _sap.buscarcodigoadicional(txtAdicional.Text.ToString());

                // Actualizar el DataGridView en el subproceso de la interfaz de usuario
                Invoke((MethodInvoker)delegate
                {
                    dataGridView.DataSource = x;
                    dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView.Columns["ItemCode"].Visible = false;
                });
            });

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            decimal numero = numericUpDown1.Value;
            if (numero == 0)
            {
                MessageBox.Show("Ingrese Cantidad " + txtCodigo.Text.ToString());
            }

            else
            {
                Cotizaciones coti = new Cotizaciones();
                coti.CodigoSap = txtCodigoSap.Text;
                coti.Descripcion = txtDescripcion.Text;
                coti.Cantidad = (double)numero;
                double valorDouble;
                double.TryParse(textPrecio.Text, out valorDouble);
                coti.Precio = valorDouble;
                coti.Total = (double)numero * valorDouble;
                listacoti.Add(coti);

                dataGridView1.DataSource = null; // Limpiar el origen de datos actual
                dataGridView1.DataSource = listacoti; // Asignar la lista actualizada
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


                txtCodigo.Clear();
                txtCodigoSap.Clear();
                txtDescripcion.Clear();
                txtAdicional.Clear();          
               
                numericUpDown1.Value = 0;

                //label13.Text = listacoti.Sum(c => c.Total).ToString();




            }

        }
    }
}
