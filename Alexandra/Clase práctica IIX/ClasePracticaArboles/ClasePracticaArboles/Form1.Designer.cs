namespace ClasePracticaArboles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbInsertar = new System.Windows.Forms.TextBox();
            this.TbRemover = new System.Windows.Forms.TextBox();
            this.TbRecorrido = new System.Windows.Forms.TextBox();
            this.TbValores = new System.Windows.Forms.TextBox();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbRecorrido = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TbInsertar
            // 
            this.TbInsertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbInsertar.ForeColor = System.Drawing.Color.Maroon;
            this.TbInsertar.Location = new System.Drawing.Point(82, 91);
            this.TbInsertar.Name = "TbInsertar";
            this.TbInsertar.Size = new System.Drawing.Size(328, 32);
            this.TbInsertar.TabIndex = 0;
            // 
            // TbRemover
            // 
            this.TbRemover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRemover.ForeColor = System.Drawing.Color.Maroon;
            this.TbRemover.Location = new System.Drawing.Point(82, 160);
            this.TbRemover.Name = "TbRemover";
            this.TbRemover.Size = new System.Drawing.Size(328, 32);
            this.TbRemover.TabIndex = 1;
            // 
            // TbRecorrido
            // 
            this.TbRecorrido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRecorrido.ForeColor = System.Drawing.Color.Maroon;
            this.TbRecorrido.Location = new System.Drawing.Point(82, 494);
            this.TbRecorrido.Name = "TbRecorrido";
            this.TbRecorrido.Size = new System.Drawing.Size(486, 32);
            this.TbRecorrido.TabIndex = 3;
            // 
            // TbValores
            // 
            this.TbValores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbValores.ForeColor = System.Drawing.Color.Maroon;
            this.TbValores.Location = new System.Drawing.Point(82, 369);
            this.TbValores.Name = "TbValores";
            this.TbValores.Size = new System.Drawing.Size(486, 32);
            this.TbValores.TabIndex = 2;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnInsertar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.ForeColor = System.Drawing.Color.Maroon;
            this.BtnInsertar.Location = new System.Drawing.Point(493, 81);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(138, 48);
            this.BtnInsertar.TabIndex = 4;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRemover.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemover.ForeColor = System.Drawing.Color.Maroon;
            this.BtnRemover.Location = new System.Drawing.Point(493, 160);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(138, 42);
            this.BtnRemover.TabIndex = 5;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = false;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valores insertados";
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorrido.ForeColor = System.Drawing.Color.White;
            this.lblRecorrido.Location = new System.Drawing.Point(80, 449);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(198, 24);
            this.lblRecorrido.TabIndex = 7;
            this.lblRecorrido.Text = "Recorrido de arbol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(815, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valores insertados";
            // 
            // CbRecorrido
            // 
            this.CbRecorrido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRecorrido.ForeColor = System.Drawing.Color.Maroon;
            this.CbRecorrido.FormattingEnabled = true;
            this.CbRecorrido.Location = new System.Drawing.Point(738, 118);
            this.CbRecorrido.Name = "CbRecorrido";
            this.CbRecorrido.Size = new System.Drawing.Size(339, 31);
            this.CbRecorrido.TabIndex = 9;
            this.CbRecorrido.SelectedIndexChanged += new System.EventHandler(this.CbRecorrido_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1145, 590);
            this.Controls.Add(this.CbRecorrido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecorrido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.TbRecorrido);
            this.Controls.Add(this.TbValores);
            this.Controls.Add(this.TbRemover);
            this.Controls.Add(this.TbInsertar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbInsertar;
        private System.Windows.Forms.TextBox TbRemover;
        private System.Windows.Forms.TextBox TbRecorrido;
        private System.Windows.Forms.TextBox TbValores;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbRecorrido;
    }
}

