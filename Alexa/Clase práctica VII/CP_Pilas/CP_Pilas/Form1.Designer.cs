namespace CP_Pilas
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbElementoAApilar = new System.Windows.Forms.TextBox();
            this.btnApilar = new System.Windows.Forms.Button();
            this.lbPilaOriginal = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnPrimeroEnFila = new System.Windows.Forms.Button();
            this.lbCopiaPila = new System.Windows.Forms.ListBox();
            this.lbImprimir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(903, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento";
            // 
            // tbElementoAApilar
            // 
            this.tbElementoAApilar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbElementoAApilar.ForeColor = System.Drawing.Color.Purple;
            this.tbElementoAApilar.Location = new System.Drawing.Point(128, 20);
            this.tbElementoAApilar.Name = "tbElementoAApilar";
            this.tbElementoAApilar.Size = new System.Drawing.Size(400, 29);
            this.tbElementoAApilar.TabIndex = 2;
            this.tbElementoAApilar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbElementoAApilar_KeyPress);
            // 
            // btnApilar
            // 
            this.btnApilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnApilar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApilar.ForeColor = System.Drawing.Color.Purple;
            this.btnApilar.Location = new System.Drawing.Point(560, 18);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(188, 33);
            this.btnApilar.TabIndex = 3;
            this.btnApilar.Text = "Push / Apilar";
            this.btnApilar.UseVisualStyleBackColor = false;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // lbPilaOriginal
            // 
            this.lbPilaOriginal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPilaOriginal.ForeColor = System.Drawing.Color.Purple;
            this.lbPilaOriginal.FormattingEnabled = true;
            this.lbPilaOriginal.ItemHeight = 22;
            this.lbPilaOriginal.Location = new System.Drawing.Point(16, 151);
            this.lbPilaOriginal.Name = "lbPilaOriginal";
            this.lbPilaOriginal.Size = new System.Drawing.Size(159, 400);
            this.lbPilaOriginal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pila Original";
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopiar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.Color.Purple;
            this.btnCopiar.Location = new System.Drawing.Point(223, 97);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(139, 33);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDesapilar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesapilar.ForeColor = System.Drawing.Color.Purple;
            this.btnDesapilar.Location = new System.Drawing.Point(404, 96);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(197, 33);
            this.btnDesapilar.TabIndex = 7;
            this.btnDesapilar.Text = "Pop / Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = false;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnPrimeroEnFila
            // 
            this.btnPrimeroEnFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrimeroEnFila.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroEnFila.ForeColor = System.Drawing.Color.Purple;
            this.btnPrimeroEnFila.Location = new System.Drawing.Point(687, 96);
            this.btnPrimeroEnFila.Name = "btnPrimeroEnFila";
            this.btnPrimeroEnFila.Size = new System.Drawing.Size(254, 33);
            this.btnPrimeroEnFila.TabIndex = 8;
            this.btnPrimeroEnFila.Text = "Peek / Primero en Fila";
            this.btnPrimeroEnFila.UseVisualStyleBackColor = false;
            this.btnPrimeroEnFila.Click += new System.EventHandler(this.btnPrimeroEnFila_Click);
            // 
            // lbCopiaPila
            // 
            this.lbCopiaPila.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopiaPila.ForeColor = System.Drawing.Color.Purple;
            this.lbCopiaPila.FormattingEnabled = true;
            this.lbCopiaPila.ItemHeight = 22;
            this.lbCopiaPila.Location = new System.Drawing.Point(214, 151);
            this.lbCopiaPila.Name = "lbCopiaPila";
            this.lbCopiaPila.Size = new System.Drawing.Size(159, 400);
            this.lbCopiaPila.TabIndex = 9;
            // 
            // lbImprimir
            // 
            this.lbImprimir.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimir.ForeColor = System.Drawing.Color.Purple;
            this.lbImprimir.FormattingEnabled = true;
            this.lbImprimir.ItemHeight = 22;
            this.lbImprimir.Location = new System.Drawing.Point(404, 151);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(537, 400);
            this.lbImprimir.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(958, 583);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.lbCopiaPila);
            this.Controls.Add(this.btnPrimeroEnFila);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPilaOriginal);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.tbElementoAApilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElementoAApilar;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.ListBox lbPilaOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnPrimeroEnFila;
        private System.Windows.Forms.ListBox lbCopiaPila;
        private System.Windows.Forms.ListBox lbImprimir;
    }
}

