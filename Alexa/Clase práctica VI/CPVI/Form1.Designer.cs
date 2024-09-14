namespace CPVI
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
            txtCantidad = new TextBox();
            btnEstablecer = new Button();
            lbImprimir = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            btnMostrar = new Button();
            btnActualizar = new Button();
            btnBorrar = new Button();
            btnIngresar = new Button();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(262, 18);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de elementos a ingresar:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.ForeColor = Color.Purple;
            txtCantidad.Location = new Point(289, 38);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(60, 26);
            txtCantidad.TabIndex = 1;
            // 
            // btnEstablecer
            // 
            btnEstablecer.BackColor = Color.FromArgb(192, 192, 255);
            btnEstablecer.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstablecer.ForeColor = Color.Purple;
            btnEstablecer.Location = new Point(405, 35);
            btnEstablecer.Margin = new Padding(3, 4, 3, 4);
            btnEstablecer.Name = "btnEstablecer";
            btnEstablecer.Size = new Size(106, 31);
            btnEstablecer.TabIndex = 2;
            btnEstablecer.Text = "Establecer";
            btnEstablecer.UseVisualStyleBackColor = false;
            btnEstablecer.Click += btnEstablecer_Click;
            // 
            // lbImprimir
            // 
            lbImprimir.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbImprimir.ForeColor = Color.Purple;
            lbImprimir.FormattingEnabled = true;
            lbImprimir.ItemHeight = 18;
            lbImprimir.Location = new Point(21, 355);
            lbImprimir.Margin = new Padding(3, 4, 3, 4);
            lbImprimir.Name = "lbImprimir";
            lbImprimir.Size = new Size(549, 166);
            lbImprimir.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(351, 153);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 4;
            label2.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(189, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(38, 153);
            label4.Name = "label4";
            label4.Size = new Size(29, 18);
            label4.TabIndex = 6;
            label4.Text = "Id:";
            label4.Click += label4_Click;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtEdad.ForeColor = Color.Purple;
            txtEdad.Location = new Point(351, 191);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(114, 26);
            txtEdad.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtNombre.ForeColor = Color.Purple;
            txtNombre.Location = new Point(189, 191);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 26);
            txtNombre.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txtId.ForeColor = Color.Purple;
            txtId.Location = new Point(38, 192);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 26);
            txtId.TabIndex = 9;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.FromArgb(192, 192, 255);
            btnMostrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = Color.Purple;
            btnMostrar.Location = new Point(484, 532);
            btnMostrar.Margin = new Padding(3, 4, 3, 4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(86, 31);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 192, 255);
            btnActualizar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.Purple;
            btnActualizar.Location = new Point(405, 281);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(104, 31);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(192, 192, 255);
            btnBorrar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.Purple;
            btnBorrar.Location = new Point(228, 281);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(86, 31);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(192, 192, 255);
            btnIngresar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.Purple;
            btnIngresar.Location = new Point(66, 281);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(192, 192, 255);
            btnBuscar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Purple;
            btnBuscar.Location = new Point(496, 189);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(594, 600);
            Controls.Add(btnBuscar);
            Controls.Add(btnIngresar);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrar);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbImprimir);
            Controls.Add(btnEstablecer);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCantidad;
        private Button btnEstablecer;
        private ListBox lbImprimir;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private TextBox txtId;
        private Button btnMostrar;
        private Button btnActualizar;
        private Button btnBorrar;
        private Button btnIngresar;
        private Button btnBuscar;
    }
}
