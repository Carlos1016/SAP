using LogicaB1;
using System.Windows.Forms;
using static LogicaB1.Modelos;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms
{
    public partial class Form1 : Form
    {

        SAPB1 _sap;

        List<Cotizaciones> listacoti;


        public Form1()
        {
            InitializeComponent();
            _sap = new SAPB1();
            listacoti = new List<Cotizaciones>();

            _sap.login();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            _sap.login();
            var x = _sap.ArticulosEX(textBox1.Text.ToString());

            if (x)
            {
                var respuesta = _sap.Articulos(textBox1.Text);

                txtCodigo.Text = respuesta.ItemCode;
                txttadicional.Text = respuesta.SWW;
                txtcostocoti.Text = respuesta.AvgStdPrice.ToString();
                txtdes.Text = respuesta.ItemName;
                if (respuesta.ItemPrices != null)
                {
                    textPrecio.Text = respuesta.ItemPrices[0].Price.ToString();
                }

                var bodegasOrdenadas = respuesta.Bodegas.OrderByDescending(b => b.InStock).ToList();
                dataGridView1.DataSource = bodegasOrdenadas;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                dataGridView1.Columns["CodigoAlmacen"].Visible = false;
            }

            else
            {
                MessageBox.Show("Articulo no encontrado " + textBox1.Text.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            _sap.login();
            var x = _sap.ArticulosEX(txtcoti.Text.ToString());

            if (x)
            {
                var respuesta = _sap.Articulos(txtcoti.Text);

                txtCodigoSapCoti.Text = respuesta.ItemCode;
                txtadicionalcoti.Text = respuesta.SWW;
                txtcostocoti.Text = respuesta.AvgStdPrice.ToString();
                txtdescoti.Text = respuesta.ItemName;
                if (respuesta.ItemPrices != null)
                {
                    textPrecio.Text = respuesta.ItemPrices[0].Price.ToString();
                }

                var bodegasOrdenadas = respuesta.Bodegas.OrderByDescending(b => b.InStock).ToList();
                dataGridView2.DataSource = bodegasOrdenadas;
                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                dataGridView2.Columns["CodigoAlmacen"].Visible = false;
            }

            else
            {
                MessageBox.Show("Articulo no encontrado " + textBox1.Text.ToString());
            }


        }

        private async void textBox3_KeyUp(object sender, KeyEventArgs e)
        {

            //_sap.login();
            //var x = _sap.buscardescripcion(textBox3.Text.ToString());
            //dataGridView2.DataSource = x;
            //dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            txtcoti.Clear();
            txtCodigoSapCoti.Clear();
            txtadicionalcoti.Clear();
            txtcostocoti.Clear();

            await Task.Run(async () =>
            {
                // Esperar un breve período antes de realizar la búsqueda
                await Task.Delay(200);

                // Realizar la búsqueda
                _sap.login();
                var x = _sap.buscardescripcion(txtdescoti.Text.ToString());

                // Actualizar el DataGridView en el subproceso de la interfaz de usuario
                Invoke((MethodInvoker)delegate
                 {
                     dataGridView2.DataSource = x;
                     dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                 });
            });



        }



        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el elemento seleccionado
                var elementoSeleccionado = dataGridView2.Rows[e.RowIndex].DataBoundItem as Item;

                // Hacer algo con el elemento seleccionado
                if (elementoSeleccionado != null)
                {


                    var respuesta = _sap.Articulos(elementoSeleccionado.ItemCode);


                    txtcoti.Text = respuesta.ItemCode;
                    txtCodigoSapCoti.Text = respuesta.ItemCode;
                    txtadicionalcoti.Text = respuesta.SWW;
                    txtcostocoti.Text = respuesta.AvgStdPrice.ToString();

                    txtdescoti.Text = respuesta.ItemName;
                    //if (respuesta.ItemPrices != null)
                    //{
                    //    txtcostocoti.Text = respuesta.ItemPrices[0].Price.ToString();
                    //}

                    var bodegasOrdenadas = respuesta.Bodegas.OrderByDescending(b => b.InStock).ToList();
                    dataGridView2.DataSource = bodegasOrdenadas;
                    dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    dataGridView2.Columns["CodigoAlmacen"].Visible = false;
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal numero = numericUpDown1.Value;
            if (numero == 0)
            {
                MessageBox.Show("Articulo no encontrado " + textBox1.Text.ToString());
            }

            else
            {
                Cotizaciones coti = new Cotizaciones();
                coti.CodigoSap = txtCodigoSapCoti.Text;
                coti.Descripcion = txtdescoti.Text;
                coti.Cantidad = (double)numero;
                double valorDouble;
                double.TryParse(txtcostocoti.Text, out valorDouble);
                coti.Costo = valorDouble;
                coti.Total = (double)numero * valorDouble;
                listacoti.Add(coti);

                dataGridView3.DataSource = null; // Limpiar el origen de datos actual
                dataGridView3.DataSource = listacoti; // Asignar la lista actualizada
                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


                txtcoti.Clear();
                txtCodigoSapCoti.Clear();
                txtadicionalcoti.Clear();
                txtcostocoti.Clear();
                txtdescoti.Clear();
                dataGridView2.DataSource = null;
                numericUpDown1.Value = 0;

                label13.Text = listacoti.Sum(c => c.Total).ToString();




            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Formulario = new ST();
            Formulario.Show();
        
        }
    }
}
