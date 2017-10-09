namespace Proyecto
{
    partial class Configuraciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuraciones));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llbRespaldo = new System.Windows.Forms.LinkLabel();
            this.llbCargar = new System.Windows.Forms.LinkLabel();
            this.llbGuardar = new System.Windows.Forms.LinkLabel();
            this.txtTítulo = new System.Windows.Forms.TextBox();
            this.bttAtrás = new System.Windows.Forms.PictureBox();
            this.PicConfiguración = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfiguración)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Music - Configuraciones";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.llbRespaldo);
            this.groupBox1.Controls.Add(this.llbCargar);
            this.groupBox1.Controls.Add(this.llbGuardar);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 294);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Avanzadas";
            // 
            // llbRespaldo
            // 
            this.llbRespaldo.AutoSize = true;
            this.llbRespaldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRespaldo.LinkColor = System.Drawing.Color.White;
            this.llbRespaldo.Location = new System.Drawing.Point(89, 235);
            this.llbRespaldo.Name = "llbRespaldo";
            this.llbRespaldo.Size = new System.Drawing.Size(176, 19);
            this.llbRespaldo.TabIndex = 42;
            this.llbRespaldo.TabStop = true;
            this.llbRespaldo.Text = "Respaldo Automático\r\n";
            this.llbRespaldo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRespaldo_LinkClicked);
            // 
            // llbCargar
            // 
            this.llbCargar.AutoSize = true;
            this.llbCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCargar.LinkColor = System.Drawing.Color.White;
            this.llbCargar.Location = new System.Drawing.Point(89, 148);
            this.llbCargar.Name = "llbCargar";
            this.llbCargar.Size = new System.Drawing.Size(367, 38);
            this.llbCargar.TabIndex = 41;
            this.llbCargar.TabStop = true;
            this.llbCargar.Text = "Cargar la información en un archivo plano .txt\r\nde una tabla.\r\n";
            // 
            // llbGuardar
            // 
            this.llbGuardar.AutoSize = true;
            this.llbGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGuardar.LinkColor = System.Drawing.Color.White;
            this.llbGuardar.Location = new System.Drawing.Point(89, 52);
            this.llbGuardar.Name = "llbGuardar";
            this.llbGuardar.Size = new System.Drawing.Size(378, 38);
            this.llbGuardar.TabIndex = 40;
            this.llbGuardar.TabStop = true;
            this.llbGuardar.Text = "Guardar la información en un archivo plano .txt\r\nde una tabla.\r\n";
            // 
            // txtTítulo
            // 
            this.txtTítulo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTítulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTítulo.CausesValidation = false;
            this.txtTítulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTítulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTítulo.Location = new System.Drawing.Point(0, 0);
            this.txtTítulo.Multiline = true;
            this.txtTítulo.Name = "txtTítulo";
            this.txtTítulo.ReadOnly = true;
            this.txtTítulo.Size = new System.Drawing.Size(644, 28);
            this.txtTítulo.TabIndex = 36;
            this.txtTítulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTítulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseDown);
            this.txtTítulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseMove);
            this.txtTítulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseUp);
            // 
            // bttAtrás
            // 
            this.bttAtrás.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttAtrás.BackgroundImage")));
            this.bttAtrás.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAtrás.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttAtrás.Location = new System.Drawing.Point(580, 371);
            this.bttAtrás.Name = "bttAtrás";
            this.bttAtrás.Size = new System.Drawing.Size(49, 49);
            this.bttAtrás.TabIndex = 35;
            this.bttAtrás.TabStop = false;
            this.bttAtrás.Click += new System.EventHandler(this.bttAtrás_Click);
            // 
            // PicConfiguración
            // 
            this.PicConfiguración.BackColor = System.Drawing.Color.Transparent;
            this.PicConfiguración.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicConfiguración.BackgroundImage")));
            this.PicConfiguración.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicConfiguración.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicConfiguración.Location = new System.Drawing.Point(502, 42);
            this.PicConfiguración.Name = "PicConfiguración";
            this.PicConfiguración.Size = new System.Drawing.Size(127, 126);
            this.PicConfiguración.TabIndex = 2;
            this.PicConfiguración.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(22, 222);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(22, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(22, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(641, 435);
            this.Controls.Add(this.bttAtrás);
            this.Controls.Add(this.PicConfiguración);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTítulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.Configuraciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfiguración)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PicConfiguración;
        private System.Windows.Forms.LinkLabel llbRespaldo;
        private System.Windows.Forms.LinkLabel llbCargar;
        private System.Windows.Forms.LinkLabel llbGuardar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox bttAtrás;
        private System.Windows.Forms.TextBox txtTítulo;
    }
}