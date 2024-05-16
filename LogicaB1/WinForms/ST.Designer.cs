namespace WinForms
{
    partial class ST
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
            btnBuscar = new Button();
            label15 = new Label();
            label14 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dataGridViewST = new DataGridView();
            dataGridViewSTInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewST).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSTInfo).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(13, 63);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(78, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(245, 13);
            label15.Name = "label15";
            label15.Size = new Size(23, 15);
            label15.TabIndex = 10;
            label15.Text = "Fin";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 9);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 9;
            label14.Text = "Inicio";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(245, 31);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(166, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(11, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dataGridViewST
            // 
            dataGridViewST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewST.Location = new Point(13, 94);
            dataGridViewST.Name = "dataGridViewST";
            dataGridViewST.Size = new Size(763, 226);
            dataGridViewST.TabIndex = 6;
            dataGridViewST.CellContentDoubleClick += dataGridViewST_CellContentDoubleClick;
            // 
            // dataGridViewSTInfo
            // 
            dataGridViewSTInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSTInfo.Location = new Point(13, 372);
            dataGridViewSTInfo.Name = "dataGridViewSTInfo";
            dataGridViewSTInfo.Size = new Size(775, 250);
            dataGridViewSTInfo.TabIndex = 12;
            // 
            // ST
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 692);
            Controls.Add(dataGridViewSTInfo);
            Controls.Add(btnBuscar);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridViewST);
            Name = "ST";
            Text = "ST";
            FormClosed += ST_FormClosed;
            Load += ST_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewST).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSTInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label label15;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridViewST;
        private DataGridView dataGridViewSTInfo;
    }
}