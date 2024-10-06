namespace SistematicoAED
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCola = new System.Windows.Forms.ListBox();
            this.lbCopia = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.lbImprimir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento";
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.Location = new System.Drawing.Point(108, 30);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(381, 26);
            this.txtElemento.TabIndex = 1;
            this.txtElemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElemento_KeyPress);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnqueue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.ForeColor = System.Drawing.Color.Maroon;
            this.btnEnqueue.Location = new System.Drawing.Point(525, 16);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(144, 52);
            this.btnEnqueue.TabIndex = 2;
            this.btnEnqueue.Text = "Enqueue / Encolar";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            this.btnEnqueue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnEnqueue_KeyPress);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCopiar.Location = new System.Drawing.Point(694, 28);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(88, 28);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cola Original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cola Copia";
            // 
            // lbCola
            // 
            this.lbCola.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCola.ForeColor = System.Drawing.Color.Maroon;
            this.lbCola.FormattingEnabled = true;
            this.lbCola.ItemHeight = 18;
            this.lbCola.Location = new System.Drawing.Point(19, 173);
            this.lbCola.Name = "lbCola";
            this.lbCola.Size = new System.Drawing.Size(219, 364);
            this.lbCola.TabIndex = 6;
            // 
            // lbCopia
            // 
            this.lbCopia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopia.ForeColor = System.Drawing.Color.Maroon;
            this.lbCopia.FormattingEnabled = true;
            this.lbCopia.ItemHeight = 18;
            this.lbCopia.Location = new System.Drawing.Point(262, 173);
            this.lbCopia.Name = "lbCopia";
            this.lbCopia.Size = new System.Drawing.Size(219, 364);
            this.lbCopia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Maroon;
            this.txtBuscar.Location = new System.Drawing.Point(566, 88);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(216, 26);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnPeek
            // 
            this.btnPeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPeek.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.ForeColor = System.Drawing.Color.Maroon;
            this.btnPeek.Location = new System.Drawing.Point(566, 173);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(216, 35);
            this.btnPeek.TabIndex = 10;
            this.btnPeek.Text = "Peek / Primero cola";
            this.btnPeek.UseVisualStyleBackColor = false;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDequeue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.ForeColor = System.Drawing.Color.Maroon;
            this.btnDequeue.Location = new System.Drawing.Point(566, 130);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(216, 37);
            this.btnDequeue.TabIndex = 11;
            this.btnDequeue.Text = "Dequeue / Desencolar";
            this.btnDequeue.UseVisualStyleBackColor = false;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // lbImprimir
            // 
            this.lbImprimir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimir.ForeColor = System.Drawing.Color.Maroon;
            this.lbImprimir.FormattingEnabled = true;
            this.lbImprimir.ItemHeight = 18;
            this.lbImprimir.Location = new System.Drawing.Point(505, 227);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(277, 310);
            this.lbImprimir.TabIndex = 12;
            this.lbImprimir.SelectedIndexChanged += new System.EventHandler(this.lbImprimir_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(815, 549);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCopia);
            this.Controls.Add(this.lbCola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCola;
        private System.Windows.Forms.ListBox lbCopia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.ListBox lbImprimir;
    }
}

