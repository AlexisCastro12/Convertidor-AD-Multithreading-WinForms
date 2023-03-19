
namespace Practica3_Threads_9CM11
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credencialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PctBxXls = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxBxV1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rbtn1_16 = new System.Windows.Forms.RadioButton();
            this.Rbtn1_10 = new System.Windows.Forms.RadioButton();
            this.Rbtn1_8 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxBxV2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rbtn2_16 = new System.Windows.Forms.RadioButton();
            this.Rbtn2_10 = new System.Windows.Forms.RadioButton();
            this.Rbtn2_8 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxBxV3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Rbtn3_16 = new System.Windows.Forms.RadioButton();
            this.Rbtn3_10 = new System.Windows.Forms.RadioButton();
            this.Rbtn3_8 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.error = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxXls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxBxV1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxBxV2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxBxV3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.credencialesToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // credencialesToolStripMenuItem
            // 
            this.credencialesToolStripMenuItem.Name = "credencialesToolStripMenuItem";
            this.credencialesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.credencialesToolStripMenuItem.Text = "Credenciales";
            this.credencialesToolStripMenuItem.Click += new System.EventHandler(this.credencialesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PctBxXls
            // 
            this.PctBxXls.Enabled = false;
            this.PctBxXls.Image = global::Practica3_Threads_9CM11.Properties.Resources.Logo_Excel;
            this.PctBxXls.Location = new System.Drawing.Point(519, 182);
            this.PctBxXls.Name = "PctBxXls";
            this.PctBxXls.Size = new System.Drawing.Size(195, 166);
            this.PctBxXls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBxXls.TabIndex = 2;
            this.PctBxXls.TabStop = false;
            this.PctBxXls.Click += new System.EventHandler(this.PctBxXls_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica3_Threads_9CM11.Properties.Resources.LogoADC;
            this.pictureBox1.Location = new System.Drawing.Point(221, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Practica3_Threads_9CM11.Properties.Resources.LogoADC;
            this.pictureBox3.Location = new System.Drawing.Point(221, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(292, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Practica3_Threads_9CM11.Properties.Resources.LogoADC;
            this.pictureBox4.Location = new System.Drawing.Point(221, 385);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(292, 113);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.TxBxV1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Rbtn1_16);
            this.groupBox1.Controls.Add(this.Rbtn1_10);
            this.groupBox1.Controls.Add(this.Rbtn1_8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración ADC1";
            // 
            // TxBxV1
            // 
            this.TxBxV1.DecimalPlaces = 3;
            this.TxBxV1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TxBxV1.Location = new System.Drawing.Point(77, 79);
            this.TxBxV1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TxBxV1.Name = "TxBxV1";
            this.TxBxV1.Size = new System.Drawing.Size(82, 24);
            this.TxBxV1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(165, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "[V]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Voltaje:";
            // 
            // Rbtn1_16
            // 
            this.Rbtn1_16.AutoSize = true;
            this.Rbtn1_16.Location = new System.Drawing.Point(140, 40);
            this.Rbtn1_16.Name = "Rbtn1_16";
            this.Rbtn1_16.Size = new System.Drawing.Size(42, 21);
            this.Rbtn1_16.TabIndex = 8;
            this.Rbtn1_16.Text = "16";
            this.Rbtn1_16.UseVisualStyleBackColor = true;
            // 
            // Rbtn1_10
            // 
            this.Rbtn1_10.AutoSize = true;
            this.Rbtn1_10.Location = new System.Drawing.Point(72, 40);
            this.Rbtn1_10.Name = "Rbtn1_10";
            this.Rbtn1_10.Size = new System.Drawing.Size(42, 21);
            this.Rbtn1_10.TabIndex = 7;
            this.Rbtn1_10.Text = "10";
            this.Rbtn1_10.UseVisualStyleBackColor = true;
            // 
            // Rbtn1_8
            // 
            this.Rbtn1_8.AutoSize = true;
            this.Rbtn1_8.Checked = true;
            this.Rbtn1_8.Location = new System.Drawing.Point(9, 40);
            this.Rbtn1_8.Name = "Rbtn1_8";
            this.Rbtn1_8.Size = new System.Drawing.Size(34, 21);
            this.Rbtn1_8.TabIndex = 6;
            this.Rbtn1_8.TabStop = true;
            this.Rbtn1_8.Text = "8";
            this.Rbtn1_8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bits:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.TxBxV2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Rbtn2_16);
            this.groupBox2.Controls.Add(this.Rbtn2_10);
            this.groupBox2.Controls.Add(this.Rbtn2_8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 113);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración ADC1";
            // 
            // TxBxV2
            // 
            this.TxBxV2.DecimalPlaces = 3;
            this.TxBxV2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TxBxV2.Location = new System.Drawing.Point(77, 77);
            this.TxBxV2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TxBxV2.Name = "TxBxV2";
            this.TxBxV2.Size = new System.Drawing.Size(82, 24);
            this.TxBxV2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(165, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "[V]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Voltaje:";
            // 
            // Rbtn2_16
            // 
            this.Rbtn2_16.AutoSize = true;
            this.Rbtn2_16.Location = new System.Drawing.Point(140, 40);
            this.Rbtn2_16.Name = "Rbtn2_16";
            this.Rbtn2_16.Size = new System.Drawing.Size(42, 21);
            this.Rbtn2_16.TabIndex = 8;
            this.Rbtn2_16.Text = "16";
            this.Rbtn2_16.UseVisualStyleBackColor = true;
            // 
            // Rbtn2_10
            // 
            this.Rbtn2_10.AutoSize = true;
            this.Rbtn2_10.Location = new System.Drawing.Point(72, 40);
            this.Rbtn2_10.Name = "Rbtn2_10";
            this.Rbtn2_10.Size = new System.Drawing.Size(42, 21);
            this.Rbtn2_10.TabIndex = 7;
            this.Rbtn2_10.Text = "10";
            this.Rbtn2_10.UseVisualStyleBackColor = true;
            // 
            // Rbtn2_8
            // 
            this.Rbtn2_8.AutoSize = true;
            this.Rbtn2_8.Checked = true;
            this.Rbtn2_8.Location = new System.Drawing.Point(9, 40);
            this.Rbtn2_8.Name = "Rbtn2_8";
            this.Rbtn2_8.Size = new System.Drawing.Size(34, 21);
            this.Rbtn2_8.TabIndex = 6;
            this.Rbtn2_8.TabStop = true;
            this.Rbtn2_8.Text = "8";
            this.Rbtn2_8.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bits:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox3.Controls.Add(this.TxBxV3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Rbtn3_16);
            this.groupBox3.Controls.Add(this.Rbtn3_10);
            this.groupBox3.Controls.Add(this.Rbtn3_8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 113);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuración ADC1";
            // 
            // TxBxV3
            // 
            this.TxBxV3.DecimalPlaces = 3;
            this.TxBxV3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TxBxV3.Location = new System.Drawing.Point(77, 77);
            this.TxBxV3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TxBxV3.Name = "TxBxV3";
            this.TxBxV3.Size = new System.Drawing.Size(82, 24);
            this.TxBxV3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(165, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "[V]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Voltaje:";
            // 
            // Rbtn3_16
            // 
            this.Rbtn3_16.AutoSize = true;
            this.Rbtn3_16.Location = new System.Drawing.Point(140, 40);
            this.Rbtn3_16.Name = "Rbtn3_16";
            this.Rbtn3_16.Size = new System.Drawing.Size(42, 21);
            this.Rbtn3_16.TabIndex = 8;
            this.Rbtn3_16.Text = "16";
            this.Rbtn3_16.UseVisualStyleBackColor = true;
            // 
            // Rbtn3_10
            // 
            this.Rbtn3_10.AutoSize = true;
            this.Rbtn3_10.Location = new System.Drawing.Point(72, 40);
            this.Rbtn3_10.Name = "Rbtn3_10";
            this.Rbtn3_10.Size = new System.Drawing.Size(42, 21);
            this.Rbtn3_10.TabIndex = 7;
            this.Rbtn3_10.Text = "10";
            this.Rbtn3_10.UseVisualStyleBackColor = true;
            // 
            // Rbtn3_8
            // 
            this.Rbtn3_8.AutoSize = true;
            this.Rbtn3_8.Checked = true;
            this.Rbtn3_8.Location = new System.Drawing.Point(9, 40);
            this.Rbtn3_8.Name = "Rbtn3_8";
            this.Rbtn3_8.Size = new System.Drawing.Size(34, 21);
            this.Rbtn3_8.TabIndex = 6;
            this.Rbtn3_8.TabStop = true;
            this.Rbtn3_8.Text = "8";
            this.Rbtn3_8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bits:";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BtnIniciar.Location = new System.Drawing.Point(579, 464);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(92, 34);
            this.BtnIniciar.TabIndex = 12;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(519, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 113);
            this.label10.TabIndex = 13;
            this.label10.Text = "Práctica 3 Programación Multithread";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(524, 28);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(731, 518);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PctBxXls);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Programación Multithread";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxXls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxBxV1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxBxV2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxBxV3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credencialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PctBxXls;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Rbtn1_16;
        private System.Windows.Forms.RadioButton Rbtn1_10;
        private System.Windows.Forms.RadioButton Rbtn1_8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Rbtn2_16;
        private System.Windows.Forms.RadioButton Rbtn2_10;
        private System.Windows.Forms.RadioButton Rbtn2_8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Rbtn3_16;
        private System.Windows.Forms.RadioButton Rbtn3_10;
        private System.Windows.Forms.RadioButton Rbtn3_8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TxBxV1;
        private System.Windows.Forms.NumericUpDown TxBxV2;
        private System.Windows.Forms.NumericUpDown TxBxV3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label error;
    }
}

