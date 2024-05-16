namespace WinForms
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
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
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textPrecio
            // 
            textPrecio.Enabled = false;
            textPrecio.Location = new Point(310, 150);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(62, 23);
            textPrecio.TabIndex = 39;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 221);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(442, 288);
            dataGridView.TabIndex = 38;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(13, 192);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(379, 23);
            txtDescripcion.TabIndex = 36;
            txtDescripcion.KeyUp += txtDescripcion_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 174);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 35;
            label5.Text = "Descripcion";
            // 
            // txtAdicional
            // 
            txtAdicional.Location = new Point(152, 150);
            txtAdicional.Name = "txtAdicional";
            txtAdicional.Size = new Size(114, 23);
            txtAdicional.TabIndex = 34;
            txtAdicional.KeyUp += txtAdicional_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 132);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 33;
            label3.Text = "Adicional";
            // 
            // txtCodigoSap
            // 
            txtCodigoSap.Enabled = false;
            txtCodigoSap.Location = new Point(18, 150);
            txtCodigoSap.Name = "txtCodigoSap";
            txtCodigoSap.Size = new Size(110, 23);
            txtCodigoSap.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 132);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 31;
            label2.Text = "Codigo Sap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 95);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 30;
            label1.Text = "Ingrese codigo";
            label1.Click += label1_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(104, 92);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 29;
            txtCodigo.Text = "REP-025-001-0001";
            //txtCodigo.TextChanged += this.txtCodigo_TextChanged;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(310, 87);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(75, 23);
            Buscar.TabIndex = 28;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 132);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 40;
            label4.Text = "Precio";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 554);
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
            Name = "Stock";
            Text = "Stock";
            FormClosing += Stock_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label4;
    }
}