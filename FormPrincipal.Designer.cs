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
            this.button1 = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.trackLuz = new System.Windows.Forms.TrackBar();
            this.labelLuz = new System.Windows.Forms.Label();
            this.trackHue = new System.Windows.Forms.TrackBar();
            this.labelHue = new System.Windows.Forms.Label();
            this.btnCanny3 = new System.Windows.Forms.Button();
            this.numericL1 = new System.Windows.Forms.NumericUpDown();
            this.numericU1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUArea = new System.Windows.Forms.NumericUpDown();
            this.btnCanny2 = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnImportarVideo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericDilatar = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericErode = new System.Windows.Forms.NumericUpDown();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.labelFps = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPlayDetect = new System.Windows.Forms.Button();
            this.btnTransformar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDilatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericErode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.BackColor = System.Drawing.Color.DimGray;
            this.pictureOriginal.Location = new System.Drawing.Point(32, 93);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(505, 318);
            this.pictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // pictureArea
            // 
            this.pictureArea.BackColor = System.Drawing.Color.DimGray;
            this.pictureArea.Location = new System.Drawing.Point(552, 93);
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
            this.btnImportar.Location = new System.Drawing.Point(41, 561);
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
            this.btnAcotar.Location = new System.Drawing.Point(565, 561);
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
            this.btnDetectar.Location = new System.Drawing.Point(727, 590);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(75, 23);
            this.btnDetectar.TabIndex = 6;
            this.btnDetectar.Text = "Detectar 3";
            this.btnDetectar.UseVisualStyleBackColor = true;
            this.btnDetectar.Click += new System.EventHandler(this.btnDetectar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Location = new System.Drawing.Point(284, 561);
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
            this.btnAcotar2.Location = new System.Drawing.Point(646, 561);
            this.btnAcotar2.Name = "btnAcotar2";
            this.btnAcotar2.Size = new System.Drawing.Size(75, 23);
            this.btnAcotar2.TabIndex = 8;
            this.btnAcotar2.Text = "Acotar 2";
            this.btnAcotar2.UseVisualStyleBackColor = true;
            this.btnAcotar2.Click += new System.EventHandler(this.btnAcotar2_Click);
            // 
            // btnAcotar3
            // 
            this.btnAcotar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcotar3.Location = new System.Drawing.Point(727, 561);
            this.btnAcotar3.Name = "btnAcotar3";
            this.btnAcotar3.Size = new System.Drawing.Size(75, 23);
            this.btnAcotar3.TabIndex = 9;
            this.btnAcotar3.Text = "Acotar 3";
            this.btnAcotar3.UseVisualStyleBackColor = true;
            this.btnAcotar3.Click += new System.EventHandler(this.btnAcotar3_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(122, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Detectar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Location = new System.Drawing.Point(203, 561);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 11;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // trackLuz
            // 
            this.trackLuz.Location = new System.Drawing.Point(807, 590);
            this.trackLuz.Margin = new System.Windows.Forms.Padding(2);
            this.trackLuz.Maximum = 255;
            this.trackLuz.Name = "trackLuz";
            this.trackLuz.Size = new System.Drawing.Size(158, 45);
            this.trackLuz.TabIndex = 12;
            this.trackLuz.Value = 195;
            this.trackLuz.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // labelLuz
            // 
            this.labelLuz.AutoSize = true;
            this.labelLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLuz.Location = new System.Drawing.Point(814, 582);
            this.labelLuz.Name = "labelLuz";
            this.labelLuz.Size = new System.Drawing.Size(32, 17);
            this.labelLuz.TabIndex = 13;
            this.labelLuz.Text = "195";
            // 
            // trackHue
            // 
            this.trackHue.Location = new System.Drawing.Point(981, 590);
            this.trackHue.Margin = new System.Windows.Forms.Padding(2);
            this.trackHue.Maximum = 45;
            this.trackHue.Name = "trackHue";
            this.trackHue.Size = new System.Drawing.Size(88, 45);
            this.trackHue.TabIndex = 14;
            this.trackHue.Value = 28;
            this.trackHue.ValueChanged += new System.EventHandler(this.trackHue_ValueChanged);
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHue.Location = new System.Drawing.Point(989, 582);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(24, 17);
            this.labelHue.TabIndex = 15;
            this.labelHue.Text = "28";
            // 
            // btnCanny3
            // 
            this.btnCanny3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanny3.Location = new System.Drawing.Point(727, 619);
            this.btnCanny3.Name = "btnCanny3";
            this.btnCanny3.Size = new System.Drawing.Size(75, 23);
            this.btnCanny3.TabIndex = 16;
            this.btnCanny3.Text = "Canny 3";
            this.btnCanny3.UseVisualStyleBackColor = true;
            this.btnCanny3.Click += new System.EventHandler(this.btnCanny3_Click);
            // 
            // numericL1
            // 
            this.numericL1.Location = new System.Drawing.Point(838, 622);
            this.numericL1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericL1.Name = "numericL1";
            this.numericL1.Size = new System.Drawing.Size(55, 20);
            this.numericL1.TabIndex = 17;
            this.numericL1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericU1
            // 
            this.numericU1.Location = new System.Drawing.Point(934, 622);
            this.numericU1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericU1.Name = "numericU1";
            this.numericU1.Size = new System.Drawing.Size(55, 20);
            this.numericU1.TabIndex = 18;
            this.numericU1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(808, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "L1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(910, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "U";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(365, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Area";
            // 
            // numericUArea
            // 
            this.numericUArea.Location = new System.Drawing.Point(409, 564);
            this.numericUArea.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUArea.Name = "numericUArea";
            this.numericUArea.Size = new System.Drawing.Size(55, 20);
            this.numericUArea.TabIndex = 22;
            // 
            // btnCanny2
            // 
            this.btnCanny2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanny2.Location = new System.Drawing.Point(646, 619);
            this.btnCanny2.Name = "btnCanny2";
            this.btnCanny2.Size = new System.Drawing.Size(75, 23);
            this.btnCanny2.TabIndex = 23;
            this.btnCanny2.Text = "Canny 2";
            this.btnCanny2.UseVisualStyleBackColor = true;
            this.btnCanny2.Click += new System.EventHandler(this.btnCanny2_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausa.Location = new System.Drawing.Point(338, 439);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(75, 23);
            this.btnPausa.TabIndex = 24;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(176, 439);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 25;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnImportarVideo
            // 
            this.btnImportarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImportarVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarVideo.Location = new System.Drawing.Point(41, 439);
            this.btnImportarVideo.Name = "btnImportarVideo";
            this.btnImportarVideo.Size = new System.Drawing.Size(117, 23);
            this.btnImportarVideo.TabIndex = 26;
            this.btnImportarVideo.Text = "Importar Video";
            this.btnImportarVideo.UseVisualStyleBackColor = false;
            this.btnImportarVideo.Click += new System.EventHandler(this.btnImportarVideo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(38, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Imagen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(38, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Video";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(43, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Dilatar";
            // 
            // numericDilatar
            // 
            this.numericDilatar.Location = new System.Drawing.Point(97, 475);
            this.numericDilatar.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericDilatar.Name = "numericDilatar";
            this.numericDilatar.Size = new System.Drawing.Size(55, 20);
            this.numericDilatar.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(43, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Erode";
            // 
            // numericErode
            // 
            this.numericErode.Location = new System.Drawing.Point(97, 501);
            this.numericErode.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericErode.Name = "numericErode";
            this.numericErode.Size = new System.Drawing.Size(55, 20);
            this.numericErode.TabIndex = 31;
            // 
            // trackBarTime
            // 
            this.trackBarTime.Location = new System.Drawing.Point(306, 501);
            this.trackBarTime.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarTime.Maximum = 100;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(158, 45);
            this.trackBarTime.TabIndex = 33;
            this.trackBarTime.Value = 30;
            this.trackBarTime.ValueChanged += new System.EventHandler(this.trackBarTime_ValueChanged);
            // 
            // labelFps
            // 
            this.labelFps.AutoSize = true;
            this.labelFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFps.Location = new System.Drawing.Point(347, 482);
            this.labelFps.Name = "labelFps";
            this.labelFps.Size = new System.Drawing.Size(24, 17);
            this.labelFps.TabIndex = 34;
            this.labelFps.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(310, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Fps";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(94, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1512, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________________________";
            // 
            // btnPlayDetect
            // 
            this.btnPlayDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlayDetect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayDetect.Location = new System.Drawing.Point(257, 439);
            this.btnPlayDetect.Name = "btnPlayDetect";
            this.btnPlayDetect.Size = new System.Drawing.Size(75, 23);
            this.btnPlayDetect.TabIndex = 37;
            this.btnPlayDetect.Text = "Play/Detect";
            this.btnPlayDetect.UseVisualStyleBackColor = false;
            this.btnPlayDetect.Click += new System.EventHandler(this.btnPlayDetect_Click);
            // 
            // btnTransformar
            // 
            this.btnTransformar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransformar.Location = new System.Drawing.Point(727, 648);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(75, 23);
            this.btnTransformar.TabIndex = 38;
            this.btnTransformar.Text = "Transformar";
            this.btnTransformar.UseVisualStyleBackColor = true;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1085, 677);
            this.Controls.Add(this.btnTransformar);
            this.Controls.Add(this.btnPlayDetect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelFps);
            this.Controls.Add(this.trackBarTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericErode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericDilatar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnImportarVideo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnCanny2);
            this.Controls.Add(this.numericUArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericU1);
            this.Controls.Add(this.numericL1);
            this.Controls.Add(this.btnCanny3);
            this.Controls.Add(this.labelHue);
            this.Controls.Add(this.trackHue);
            this.Controls.Add(this.labelLuz);
            this.Controls.Add(this.trackLuz);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.button1);
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
            this.Name = "FormPrincipal";
            this.Text = "Detector de carril";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDilatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericErode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.TrackBar trackLuz;
        private System.Windows.Forms.Label labelLuz;
        private System.Windows.Forms.TrackBar trackHue;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Button btnCanny3;
        private System.Windows.Forms.NumericUpDown numericL1;
        private System.Windows.Forms.NumericUpDown numericU1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUArea;
        private System.Windows.Forms.Button btnCanny2;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnImportarVideo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericDilatar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericErode;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Label labelFps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPlayDetect;
        private System.Windows.Forms.Button btnTransformar;
    }
}

