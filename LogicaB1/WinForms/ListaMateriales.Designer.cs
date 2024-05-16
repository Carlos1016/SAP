namespace B1S
{
    partial class ListaMaterial
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
            label1 = new Label();
            txtCodigo = new TextBox();
            Buscar = new Button();
            lbcodigo = new Label();
            lbdescripcion = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 33;
            label1.Text = "Ingrese codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(96, 29);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 32;
            txtCodigo.Text = "REP-025-001-0001";
            // 
            // Buscar
            // 
            Buscar.Location = new Point(302, 24);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(75, 23);
            Buscar.TabIndex = 31;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            // 
            // lbcodigo
            // 
            lbcodigo.AutoSize = true;
            lbcodigo.Location = new Point(17, 69);
            lbcodigo.Name = "lbcodigo";
            lbcodigo.Size = new Size(0, 15);
            lbcodigo.TabIndex = 34;
            // 
            // lbdescripcion
            // 
            lbdescripcion.AutoSize = true;
            lbdescripcion.Location = new Point(17, 84);
            lbdescripcion.Name = "lbdescripcion";
            lbdescripcion.Size = new Size(0, 15);
            lbdescripcion.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(508, 475);
            dataGridView1.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(373, 50);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 38;
            label4.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(302, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 39;
            label2.Text = "Total =";
            // 
            // ListaMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 579);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(lbdescripcion);
            Controls.Add(lbcodigo);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(Buscar);
            Name = "ListaMaterial";
            Text = "ListaMateriales";
            FormClosed += ListaMaterial_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Button Buscar;
        private Label lbcodigo;
        private Label lbdescripcion;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label2;
    }
}