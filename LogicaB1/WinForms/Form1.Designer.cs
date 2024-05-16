namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Articulo = new TabControl();
            Articulos = new TabPage();
            textPrecio = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            txtdes = new TextBox();
            label5 = new Label();
            txttadicional = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            Coti = new TabPage();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            txtcostocoti = new TextBox();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            txtdescoti = new TextBox();
            label8 = new Label();
            txtadicionalcoti = new TextBox();
            label9 = new Label();
            txtCodigoSapCoti = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtcoti = new TextBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ST = new TabPage();
            button4 = new Button();
            bindingSource1 = new BindingSource(components);
            dataGridView3 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            label13 = new Label();
            Articulo.SuspendLayout();
            Articulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Coti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // Articulo
            // 
            Articulo.Controls.Add(Articulos);
            Articulo.Controls.Add(Coti);
            Articulo.Controls.Add(ST);
            Articulo.Location = new Point(20, 3);
            Articulo.Name = "Articulo";
            Articulo.SelectedIndex = 0;
            Articulo.Size = new Size(454, 560);
            Articulo.TabIndex = 0;
            Articulo.Tag = "q";
            // 
            // Articulos
            // 
            Articulos.Controls.Add(textPrecio);
            Articulos.Controls.Add(label6);
            Articulos.Controls.Add(dataGridView1);
            Articulos.Controls.Add(pictureBox1);
            Articulos.Controls.Add(txtdes);
            Articulos.Controls.Add(label5);
            Articulos.Controls.Add(txttadicional);
            Articulos.Controls.Add(label3);
            Articulos.Controls.Add(txtCodigo);
            Articulos.Controls.Add(label2);
            Articulos.Controls.Add(label1);
            Articulos.Controls.Add(textBox1);
            Articulos.Controls.Add(button1);
            Articulos.Location = new Point(4, 24);
            Articulos.Name = "Articulos";
            Articulos.Padding = new Padding(3);
            Articulos.Size = new Size(446, 532);
            Articulos.TabIndex = 0;
            Articulos.Text = "Articulos";
            Articulos.UseVisualStyleBackColor = true;
            // 
            // textPrecio
            // 
            textPrecio.Enabled = false;
            textPrecio.Location = new Point(270, 153);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(62, 23);
            textPrecio.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 135);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 26;
            label6.Text = "Precio";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(419, 288);
            dataGridView1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // txtdes
            // 
            txtdes.Enabled = false;
            txtdes.Location = new Point(25, 195);
            txtdes.Name = "txtdes";
            txtdes.Size = new Size(379, 23);
            txtdes.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 177);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 22;
            label5.Text = "Descripcion";
            // 
            // txttadicional
            // 
            txttadicional.Enabled = false;
            txttadicional.Location = new Point(159, 153);
            txttadicional.Name = "txttadicional";
            txttadicional.Size = new Size(81, 23);
            txttadicional.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 135);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 18;
            label3.Text = "Adicional";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(26, 153);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 135);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 16;
            label2.Text = "Codigo Sap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 98);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 15;
            label1.Text = "Ingrese codigo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 14;
            textBox1.Text = "REP-025-001-0001";
            // 
            // button1
            // 
            button1.Location = new Point(311, 90);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Coti
            // 
            Coti.Controls.Add(button3);
            Coti.Controls.Add(numericUpDown1);
            Coti.Controls.Add(label12);
            Coti.Controls.Add(txtcostocoti);
            Coti.Controls.Add(label7);
            Coti.Controls.Add(dataGridView2);
            Coti.Controls.Add(txtdescoti);
            Coti.Controls.Add(label8);
            Coti.Controls.Add(txtadicionalcoti);
            Coti.Controls.Add(label9);
            Coti.Controls.Add(txtCodigoSapCoti);
            Coti.Controls.Add(label10);
            Coti.Controls.Add(label11);
            Coti.Controls.Add(txtcoti);
            Coti.Controls.Add(button2);
            Coti.Controls.Add(pictureBox2);
            Coti.Location = new Point(4, 24);
            Coti.Name = "Coti";
            Coti.Padding = new Padding(3);
            Coti.Size = new Size(446, 532);
            Coti.TabIndex = 1;
            Coti.Text = "Cotiza";
            Coti.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(317, 91);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 45;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(321, 150);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 23);
            numericUpDown1.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(321, 131);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 42;
            label12.Text = "Cantidad";
            // 
            // txtcostocoti
            // 
            txtcostocoti.Enabled = false;
            txtcostocoti.Location = new Point(249, 149);
            txtcostocoti.Name = "txtcostocoti";
            txtcostocoti.Size = new Size(62, 23);
            txtcostocoti.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 131);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 40;
            label7.Text = "Costo";
            label7.Click += label7_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 241);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(421, 265);
            dataGridView2.TabIndex = 39;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick_1;
            // 
            // txtdescoti
            // 
            txtdescoti.Location = new Point(17, 191);
            txtdescoti.Name = "txtdescoti";
            txtdescoti.Size = new Size(379, 23);
            txtdescoti.TabIndex = 36;
            txtdescoti.KeyUp += textBox3_KeyUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 173);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 35;
            label8.Text = "Descripcion";
            // 
            // txtadicionalcoti
            // 
            txtadicionalcoti.Enabled = false;
            txtadicionalcoti.Location = new Point(151, 149);
            txtadicionalcoti.Name = "txtadicionalcoti";
            txtadicionalcoti.Size = new Size(81, 23);
            txtadicionalcoti.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(151, 131);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 33;
            label9.Text = "Adicional";
            // 
            // txtCodigoSapCoti
            // 
            txtCodigoSapCoti.Enabled = false;
            txtCodigoSapCoti.Location = new Point(18, 149);
            txtCodigoSapCoti.Name = "txtCodigoSapCoti";
            txtCodigoSapCoti.Size = new Size(110, 23);
            txtCodigoSapCoti.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 131);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 31;
            label10.Text = "Codigo Sap";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 94);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 30;
            label11.Text = "Ingrese codigo";
            // 
            // txtcoti
            // 
            txtcoti.Location = new Point(97, 91);
            txtcoti.Name = "txtcoti";
            txtcoti.Size = new Size(135, 23);
            txtcoti.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(236, 90);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(415, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // ST
            // 
            ST.Controls.Add(button4);
            ST.Location = new Point(4, 24);
            ST.Name = "ST";
            ST.Padding = new Padding(3);
            ST.Size = new Size(446, 532);
            ST.TabIndex = 2;
            ST.Text = "ST";
            ST.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 31);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "Ir a ST";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(494, 30);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(432, 529);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(761, 562);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 2;
            label4.Text = "Total =";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(820, 562);
            label13.Name = "label13";
            label13.Size = new Size(23, 25);
            label13.TabIndex = 3;
            label13.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 590);
            Controls.Add(label13);
            Controls.Add(label4);
            Controls.Add(dataGridView3);
            Controls.Add(Articulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Articulo.ResumeLayout(false);
            Articulos.ResumeLayout(false);
            Articulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Coti.ResumeLayout(false);
            Coti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ST.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl Articulo;
        private TabPage Articulos;
        private TabPage Coti;
        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private TextBox txtdes;
        private Label label5;
        private TextBox txttadicional;
        private Label label3;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private TextBox textPrecio;
        private Label label6;
        private TextBox txtdescoti;
        private Label label8;
        private TextBox txtadicionalcoti;
        private Label label9;
        private TextBox txtCodigoSapCoti;
        private Label label10;
        private Label label11;
        private TextBox txtcoti;
        private Button button2;
        private DataGridView dataGridView2;
        private TextBox txtcostocoti;
        private Label label7;
        private Label label12;
        private DataGridView dataGridView3;
        private NumericUpDown numericUpDown1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button3;
        private Label label4;
        private Label label13;
        private TabPage ST;
        private Button button4;
    }
}
