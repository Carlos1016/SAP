namespace WinForms
{
    partial class Coti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coti));
            label4 = new Label();
            textPrecio = new TextBox();
            dataGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtAdicional = new TextBox();
            label3 = new Label();
            txtCodigoSap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            Buscar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 141);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 53;
            label4.Text = "Precio";
            // 
            // textPrecio
            // 
            textPrecio.Enabled = false;
            textPrecio.Location = new Point(295, 159);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(62, 23);
            textPrecio.TabIndex = 52;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(20, 230);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(442, 206);
            dataGridView.TabIndex = 51;
            dataGridView.CellContentDoubleClick += dataGridView_CellContentDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(20, 201);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(442, 23);
            txtDescripcion.TabIndex = 49;
            txtDescripcion.KeyUp += txtDescripcion_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 185);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 48;
            label5.Text = "Descripcion";
            // 
            // txtAdicional
            // 
            txtAdicional.Location = new Point(154, 159);
            txtAdicional.Name = "txtAdicional";
            txtAdicional.Size = new Size(114, 23);
            txtAdicional.TabIndex = 47;
            txtAdicional.KeyUp += txtAdicional_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 141);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 46;
            label3.Text = "Adicional";
            // 
            // txtCodigoSap
            // 
            txtCodigoSap.Enabled = false;
            txtCodigoSap.Location = new Point(25, 159);
            txtCodigoSap.Name = "txtCodigoSap";
            txtCodigoSap.Size = new Size(110, 23);
            txtCodigoSap.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 141);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 44;
            label2.Text = "Codigo Sap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 104);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 43;
            label1.Text = "Ingrese codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(111, 101);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 42;
            txtCodigo.Text = "REP-025-001-0001";
            // 
            // Buscar
            // 
            Buscar.Location = new Point(317, 96);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(75, 23);
            Buscar.TabIndex = 41;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(398, 96);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(64, 23);
            btnAgregar.TabIndex = 54;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 442);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 206);
            dataGridView1.TabIndex = 55;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(364, 160);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 23);
            numericUpDown1.TabIndex = 57;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(364, 141);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 56;
            label12.Text = "Cantidad";
            // 
            // Coti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 668);
            Controls.Add(numericUpDown1);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(textPrecio);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox1);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(txtAdicional);
            Controls.Add(label3);
            Controls.Add(txtCodigoSap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(Buscar);
            Name = "Coti";
            Text = "Coti";
            FormClosed += Coti_FormClosed;
            Load += Coti_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textPrecio;
        private DataGridView dataGridView;
        private PictureBox pictureBox1;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtAdicional;
        private Label label3;
        private TextBox txtCodigoSap;
        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private Button Buscar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Label label12;
    }
}