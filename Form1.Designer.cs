namespace Taller_2_promedio_notas
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPromedio = new System.Windows.Forms.Label();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(242, 312);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(171, 37);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROMEDIO NOTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOTA 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOTA 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOTA 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PROMEDIO";
            // 
            // LblPromedio
            // 
            this.LblPromedio.AutoSize = true;
            this.LblPromedio.Location = new System.Drawing.Point(239, 217);
            this.LblPromedio.Name = "LblPromedio";
            this.LblPromedio.Size = new System.Drawing.Size(13, 13);
            this.LblPromedio.TabIndex = 3;
            this.LblPromedio.Text = "0";
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(211, 85);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(83, 20);
            this.TxtNota1.TabIndex = 0;
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(211, 125);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(83, 20);
            this.TxtNota2.TabIndex = 1;
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(211, 164);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(84, 20);
            this.TxtNota3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taller_2_promedio_notas.Properties.Resources.notas;
            this.pictureBox1.Location = new System.Drawing.Point(420, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 236);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(52, 312);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(168, 37);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 372);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.LblPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Name = "Form1";
            this.Text = "NOTAS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPromedio;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

