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
            this.btnAcotar3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.BackColor = System.Drawing.Color.DimGray;
            this.pictureOriginal.Location = new System.Drawing.Point(31, 127);
            this.pictureOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(673, 391);
            this.pictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // pictureArea
            // 
            this.pictureArea.BackColor = System.Drawing.Color.DimGray;
            this.pictureArea.Location = new System.Drawing.Point(737, 127);
            this.pictureArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(673, 391);
            this.pictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArea.TabIndex = 1;
            this.pictureArea.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORIGINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(732, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÁREA DE INTERÉS";
            // 
            // btnImportar
            // 
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.Location = new System.Drawing.Point(31, 561);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(100, 28);
            this.btnImportar.TabIndex = 4;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAcotar
            // 
            this.btnAcotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcotar.Location = new System.Drawing.Point(737, 561);
            this.btnAcotar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcotar.Name = "btnAcotar";
            this.btnAcotar.Size = new System.Drawing.Size(100, 28);
            this.btnAcotar.TabIndex = 5;
            this.btnAcotar.Text = "Acotar 1";
            this.btnAcotar.UseVisualStyleBackColor = true;
            this.btnAcotar.Click += new System.EventHandler(this.btnAcotar_Click);
            // 
            // btnDetectar
            // 
            this.btnDetectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetectar.Location = new System.Drawing.Point(139, 561);
            this.btnDetectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(100, 28);
            this.btnDetectar.TabIndex = 6;
            this.btnDetectar.Text = "Detectar";
            this.btnDetectar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Location = new System.Drawing.Point(604, 561);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 28);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAcotar2
            // 
            this.btnAcotar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcotar2.Location = new System.Drawing.Point(845, 561);
            this.btnAcotar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcotar2.Name = "btnAcotar2";
            this.btnAcotar2.Size = new System.Drawing.Size(100, 28);
            this.btnAcotar2.TabIndex = 8;
            this.btnAcotar2.Text = "Acotar 2";
            this.btnAcotar2.UseVisualStyleBackColor = true;
            this.btnAcotar2.Click += new System.EventHandler(this.btnAcotar2_Click);
            // 
            // btnAcotar3
            // 
            this.btnAcotar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcotar3.Location = new System.Drawing.Point(953, 561);
            this.btnAcotar3.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcotar3.Name = "btnAcotar3";
            this.btnAcotar3.Size = new System.Drawing.Size(100, 28);
            this.btnAcotar3.TabIndex = 9;
            this.btnAcotar3.Text = "Acotar 3";
            this.btnAcotar3.UseVisualStyleBackColor = true;
            this.btnAcotar3.Click += new System.EventHandler(this.btnAcotar3_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1447, 646);
            this.Controls.Add(this.btnAcotar3);
            this.Controls.Add(this.btnAcotar2);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDetectar);
            this.Controls.Add(this.btnAcotar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureArea);
            this.Controls.Add(this.pictureOriginal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnAcotar3;
    }
}

