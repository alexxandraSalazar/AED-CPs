namespace CP_IV_Redim
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnImprimir = new Button();
            tbNombres = new TextBox();
            tbApellidos = new TextBox();
            tbTelefono = new TextBox();
            tbAño = new TextBox();
            dgvImprimir = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvImprimir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(29, 31);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(29, 74);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(29, 118);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(29, 163);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 4;
            label5.Text = "Año";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 192, 192);
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Maroon;
            btnAgregar.Location = new Point(334, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(255, 192, 192);
            btnImprimir.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.Maroon;
            btnImprimir.Location = new Point(334, 74);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // tbNombres
            // 
            tbNombres.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            tbNombres.ForeColor = Color.Maroon;
            tbNombres.Location = new Point(119, 32);
            tbNombres.Name = "tbNombres";
            tbNombres.Size = new Size(180, 28);
            tbNombres.TabIndex = 7;
            // 
            // tbApellidos
            // 
            tbApellidos.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            tbApellidos.ForeColor = Color.Maroon;
            tbApellidos.Location = new Point(119, 71);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(180, 28);
            tbApellidos.TabIndex = 8;
            // 
            // tbTelefono
            // 
            tbTelefono.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            tbTelefono.ForeColor = Color.Maroon;
            tbTelefono.Location = new Point(119, 109);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(180, 28);
            tbTelefono.TabIndex = 9;
            // 
            // tbAño
            // 
            tbAño.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            tbAño.ForeColor = Color.Maroon;
            tbAño.Location = new Point(119, 154);
            tbAño.Name = "tbAño";
            tbAño.Size = new Size(180, 28);
            tbAño.TabIndex = 10;
            tbAño.KeyPress += tbAño_KeyPress;
            // 
            // dgvImprimir
            // 
            dgvImprimir.BackgroundColor = SystemColors.Control;
            dgvImprimir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImprimir.Location = new Point(334, 128);
            dgvImprimir.Name = "dgvImprimir";
            dgvImprimir.RowHeadersWidth = 51;
            dgvImprimir.Size = new Size(600, 190);
            dgvImprimir.TabIndex = 11;
            dgvImprimir.CellContentClick += dgvImprimir_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(984, 377);
            Controls.Add(dgvImprimir);
            Controls.Add(tbAño);
            Controls.Add(tbTelefono);
            Controls.Add(tbApellidos);
            Controls.Add(tbNombres);
            Controls.Add(btnImprimir);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImprimir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button btnImprimir;
        private TextBox tbNombres;
        private TextBox tbApellidos;
        private TextBox tbTelefono;
        private TextBox tbAño;
        private DataGridView dgvImprimir;
    }
}
