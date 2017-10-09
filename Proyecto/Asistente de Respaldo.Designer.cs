namespace Proyecto
{
    partial class Asistente_de_Respaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistente_de_Respaldo));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.pbDestino = new System.Windows.Forms.PictureBox();
            this.bttRespaldar = new System.Windows.Forms.Button();
            this.bttAtrás = new System.Windows.Forms.PictureBox();
            this.txtDumpfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogfile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(28, 3);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(228, 21);
            this.lbTitulo.TabIndex = 64;
            this.lbTitulo.Text = "Music - Biblioteca de Música";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.lbTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lbTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 25);
            this.label1.TabIndex = 66;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(172)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(28, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "Directorio: ";
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorio.Location = new System.Drawing.Point(151, 60);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.ReadOnly = true;
            this.txtDirectorio.Size = new System.Drawing.Size(297, 27);
            this.txtDirectorio.TabIndex = 0;
            // 
            // pbDestino
            // 
            this.pbDestino.BackColor = System.Drawing.Color.DimGray;
            this.pbDestino.Location = new System.Drawing.Point(454, 60);
            this.pbDestino.Name = "pbDestino";
            this.pbDestino.Size = new System.Drawing.Size(27, 27);
            this.pbDestino.TabIndex = 69;
            this.pbDestino.TabStop = false;
            this.pbDestino.Click += new System.EventHandler(this.pbDestino_Click);
            // 
            // bttRespaldar
            // 
            this.bttRespaldar.BackColor = System.Drawing.Color.Gray;
            this.bttRespaldar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttRespaldar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRespaldar.Location = new System.Drawing.Point(196, 243);
            this.bttRespaldar.Name = "bttRespaldar";
            this.bttRespaldar.Size = new System.Drawing.Size(129, 40);
            this.bttRespaldar.TabIndex = 3;
            this.bttRespaldar.Text = "Respaldar";
            this.bttRespaldar.UseVisualStyleBackColor = false;
            this.bttRespaldar.Click += new System.EventHandler(this.bttRespaldar_Click);
            // 
            // bttAtrás
            // 
            this.bttAtrás.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttAtrás.BackgroundImage")));
            this.bttAtrás.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAtrás.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttAtrás.Location = new System.Drawing.Point(432, 234);
            this.bttAtrás.Name = "bttAtrás";
            this.bttAtrás.Size = new System.Drawing.Size(49, 49);
            this.bttAtrás.TabIndex = 71;
            this.bttAtrás.TabStop = false;
            this.bttAtrás.Click += new System.EventHandler(this.bttAtrás_Click);
            // 
            // txtDumpfile
            // 
            this.txtDumpfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDumpfile.Location = new System.Drawing.Point(151, 120);
            this.txtDumpfile.Name = "txtDumpfile";
            this.txtDumpfile.Size = new System.Drawing.Size(224, 27);
            this.txtDumpfile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(172)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 38);
            this.label2.TabIndex = 72;
            this.label2.Text = "Nombre para \r\nel Dumpfile: ";
            // 
            // txtLogfile
            // 
            this.txtLogfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogfile.Location = new System.Drawing.Point(151, 179);
            this.txtLogfile.Name = "txtLogfile";
            this.txtLogfile.Size = new System.Drawing.Size(224, 27);
            this.txtLogfile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(172)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(28, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 38);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nombre para\r\nel Logfile: ";
            // 
            // Asistente_de_Respaldo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(493, 317);
            this.Controls.Add(this.txtLogfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDumpfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttAtrás);
            this.Controls.Add(this.bttRespaldar);
            this.Controls.Add(this.pbDestino);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistente_de_Respaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente_de_Respaldo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.PictureBox pbDestino;
        private System.Windows.Forms.Button bttRespaldar;
        private System.Windows.Forms.PictureBox bttAtrás;
        private System.Windows.Forms.TextBox txtDumpfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogfile;
        private System.Windows.Forms.Label label3;
    }
}