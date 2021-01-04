namespace Detector_de_Carril
{
    partial class FormPrincipal
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
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.pictureArea = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAcotar = new System.Windows.Forms.Button();
            this.btnDetectar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnAcotar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.BackColor = System.Drawing.Color.DimGray;
            this.pictureOriginal.Location = new System.Drawing.Point(23, 103);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(505, 318);
            this.pictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // pictureArea
            // 
            this.pictureArea.BackColor = System.Drawing.Color.DimGray;
            this.pictureArea.Location = new System.Drawing.Point(553, 103);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(505, 318);
            this.pictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArea.TabIndex = 1;
            this.pictureArea.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORIGINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(549, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÁREA DE INTERÉS";
            // 
            // btnImportar
            // 
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.Location = new System.Drawing.Point(23, 456);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 4;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAcotar
            // 
            this.btnAcotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcotar.Location = new System.Drawing.Point(553, 456);
            this.btnAcotar.Name = "btnAcotar";
            this.btnAcotar.Size = new System.Drawing.Size(75, 23);
            this.btnAcotar.TabIndex = 5;
            this.btnAcotar.Text = "Acotar 1";
            this.btnAcotar.UseVisualStyleBackColor = true;
            this.btnAcotar.Click += new System.EventHandler(this.btnAcotar_Click);
            // 
            // btnDetectar
            // 
            this.btnDetectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetectar.Location = new System.Drawing.Point(104, 456);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(75, 23);
            this.btnDetectar.TabIndex = 6;
            this.btnDetectar.Text = "Detectar";
            this.btnDetectar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Location = new System.Drawing.Point(453, 456);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAcotar2
            // 
            this.btnAcotar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcotar2.Location = new System.Drawing.Point(634, 456);
            this.btnAcotar2.Name = "btnAcotar2";
            this.btnAcotar2.Size = new System.Drawing.Size(75, 23);
            this.btnAcotar2.TabIndex = 8;
            this.btnAcotar2.Text = "Acotar 2";
            this.btnAcotar2.UseVisualStyleBackColor = true;
            this.btnAcotar2.Click += new System.EventHandler(this.btnAcotar2_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1085, 525);
            this.Controls.Add(this.btnAcotar2);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDetectar);
            this.Controls.Add(this.btnAcotar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureArea);
            this.Controls.Add(this.pictureOriginal);
            this.Name = "FormPrincipal";
            this.Text = "Detector de carril";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.PictureBox pictureArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAcotar;
        private System.Windows.Forms.Button btnDetectar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnAcotar2;
    }
}

