namespace Proyecto
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PicConfiguración = new System.Windows.Forms.PictureBox();
            this.PicBiblioteca = new System.Windows.Forms.PictureBox();
            this.bttCerrarSesión = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfiguración)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBiblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Music - Página Principal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PicConfiguración);
            this.panel1.Controls.Add(this.PicBiblioteca);
            this.panel1.Location = new System.Drawing.Point(84, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 318);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(403, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Configuraciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(127, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Biblioteca";
            // 
            // PicConfiguración
            // 
            this.PicConfiguración.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicConfiguración.BackgroundImage")));
            this.PicConfiguración.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicConfiguración.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicConfiguración.Location = new System.Drawing.Point(398, 30);
            this.PicConfiguración.Name = "PicConfiguración";
            this.PicConfiguración.Size = new System.Drawing.Size(208, 208);
            this.PicConfiguración.TabIndex = 1;
            this.PicConfiguración.TabStop = false;
            this.PicConfiguración.Click += new System.EventHandler(this.PicConfiguración_Click);
            // 
            // PicBiblioteca
            // 
            this.PicBiblioteca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBiblioteca.BackgroundImage")));
            this.PicBiblioteca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBiblioteca.Location = new System.Drawing.Point(91, 30);
            this.PicBiblioteca.Name = "PicBiblioteca";
            this.PicBiblioteca.Size = new System.Drawing.Size(208, 208);
            this.PicBiblioteca.TabIndex = 0;
            this.PicBiblioteca.TabStop = false;
            this.PicBiblioteca.Click += new System.EventHandler(this.PicBiblioteca_Click);
            // 
            // bttCerrarSesión
            // 
            this.bttCerrarSesión.BackColor = System.Drawing.Color.Gray;
            this.bttCerrarSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttCerrarSesión.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCerrarSesión.Location = new System.Drawing.Point(732, 458);
            this.bttCerrarSesión.Name = "bttCerrarSesión";
            this.bttCerrarSesión.Size = new System.Drawing.Size(129, 40);
            this.bttCerrarSesión.TabIndex = 24;
            this.bttCerrarSesión.Text = "Cerrar Sesión";
            this.bttCerrarSesión.UseVisualStyleBackColor = false;
            this.bttCerrarSesión.Click += new System.EventHandler(this.bttCerrarSesión_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(872, 25);
            this.label4.TabIndex = 64;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseUp);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(873, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttCerrarSesión);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfiguración)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBiblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicConfiguración;
        private System.Windows.Forms.PictureBox PicBiblioteca;
        private System.Windows.Forms.Button bttCerrarSesión;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}