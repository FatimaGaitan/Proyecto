namespace Proyecto
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.bttInvitado = new System.Windows.Forms.Button();
            this.bttTecnico = new System.Windows.Forms.Button();
            this.bttAdministrador = new System.Windows.Forms.Button();
            this.bttIniciar = new System.Windows.Forms.Button();
            this.PnInicioSesion = new System.Windows.Forms.Panel();
            this.llbCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.bttAtrás1 = new System.Windows.Forms.PictureBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.PnRegistrar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttAtrás2 = new System.Windows.Forms.PictureBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttCrear = new System.Windows.Forms.Button();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bttCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás1)).BeginInit();
            this.PnRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inicio de Sesión";
            // 
            // bttInvitado
            // 
            this.bttInvitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(205)))), ((int)(((byte)(168)))));
            this.bttInvitado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttInvitado.Location = new System.Drawing.Point(485, 287);
            this.bttInvitado.Name = "bttInvitado";
            this.bttInvitado.Size = new System.Drawing.Size(183, 45);
            this.bttInvitado.TabIndex = 9;
            this.bttInvitado.Text = "Invitado";
            this.bttInvitado.UseVisualStyleBackColor = false;
            this.bttInvitado.Click += new System.EventHandler(this.bttInvitado_Click);
            // 
            // bttTecnico
            // 
            this.bttTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(202)))), ((int)(((byte)(106)))));
            this.bttTecnico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTecnico.Location = new System.Drawing.Point(261, 287);
            this.bttTecnico.Name = "bttTecnico";
            this.bttTecnico.Size = new System.Drawing.Size(183, 45);
            this.bttTecnico.TabIndex = 10;
            this.bttTecnico.Text = "Técnico";
            this.bttTecnico.UseVisualStyleBackColor = false;
            this.bttTecnico.Click += new System.EventHandler(this.bttTecnico_Click);
            // 
            // bttAdministrador
            // 
            this.bttAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(136)))), ((int)(((byte)(169)))));
            this.bttAdministrador.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdministrador.Location = new System.Drawing.Point(41, 287);
            this.bttAdministrador.Name = "bttAdministrador";
            this.bttAdministrador.Size = new System.Drawing.Size(183, 45);
            this.bttAdministrador.TabIndex = 11;
            this.bttAdministrador.Text = "Administrador";
            this.bttAdministrador.UseVisualStyleBackColor = false;
            this.bttAdministrador.Click += new System.EventHandler(this.bttAdministrador_Click);
            // 
            // bttIniciar
            // 
            this.bttIniciar.BackColor = System.Drawing.Color.Gray;
            this.bttIniciar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttIniciar.Location = new System.Drawing.Point(161, 265);
            this.bttIniciar.Name = "bttIniciar";
            this.bttIniciar.Size = new System.Drawing.Size(106, 32);
            this.bttIniciar.TabIndex = 23;
            this.bttIniciar.Text = "Iniciar";
            this.bttIniciar.UseVisualStyleBackColor = false;
            this.bttIniciar.Click += new System.EventHandler(this.bttIniciar_Click);
            // 
            // PnInicioSesion
            // 
            this.PnInicioSesion.Controls.Add(this.llbCrearCuenta);
            this.PnInicioSesion.Controls.Add(this.bttAtrás1);
            this.PnInicioSesion.Controls.Add(this.lbContraseña);
            this.PnInicioSesion.Controls.Add(this.bttIniciar);
            this.PnInicioSesion.Controls.Add(this.lbCorreo);
            this.PnInicioSesion.Controls.Add(this.txtContraseña);
            this.PnInicioSesion.Controls.Add(this.txtCorreo);
            this.PnInicioSesion.Location = new System.Drawing.Point(242, 61);
            this.PnInicioSesion.Name = "PnInicioSesion";
            this.PnInicioSesion.Size = new System.Drawing.Size(486, 328);
            this.PnInicioSesion.TabIndex = 26;
            // 
            // llbCrearCuenta
            // 
            this.llbCrearCuenta.AutoSize = true;
            this.llbCrearCuenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCrearCuenta.LinkColor = System.Drawing.Color.Gray;
            this.llbCrearCuenta.Location = new System.Drawing.Point(157, 203);
            this.llbCrearCuenta.Name = "llbCrearCuenta";
            this.llbCrearCuenta.Size = new System.Drawing.Size(110, 20);
            this.llbCrearCuenta.TabIndex = 28;
            this.llbCrearCuenta.TabStop = true;
            this.llbCrearCuenta.Text = "Crear Cuenta";
            this.llbCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCrearCuenta_LinkClicked);
            // 
            // bttAtrás1
            // 
            this.bttAtrás1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttAtrás1.BackgroundImage")));
            this.bttAtrás1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAtrás1.Location = new System.Drawing.Point(424, 267);
            this.bttAtrás1.Name = "bttAtrás1";
            this.bttAtrás1.Size = new System.Drawing.Size(49, 49);
            this.bttAtrás1.TabIndex = 24;
            this.bttAtrás1.TabStop = false;
            this.bttAtrás1.Click += new System.EventHandler(this.bttAtrás1_Click);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.ForeColor = System.Drawing.Color.White;
            this.lbContraseña.Location = new System.Drawing.Point(156, 104);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(111, 21);
            this.lbContraseña.TabIndex = 26;
            this.lbContraseña.Text = "Contraseña: ";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.Color.White;
            this.lbCorreo.Location = new System.Drawing.Point(180, 20);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(71, 21);
            this.lbCorreo.TabIndex = 25;
            this.lbCorreo.Text = "Correo: ";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(72, 146);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(295, 27);
            this.txtContraseña.TabIndex = 24;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(72, 62);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(295, 27);
            this.txtCorreo.TabIndex = 23;
            // 
            // PnRegistrar
            // 
            this.PnRegistrar.Controls.Add(this.label4);
            this.PnRegistrar.Controls.Add(this.label2);
            this.PnRegistrar.Controls.Add(this.label3);
            this.PnRegistrar.Controls.Add(this.bttAtrás2);
            this.PnRegistrar.Controls.Add(this.txtPass2);
            this.PnRegistrar.Controls.Add(this.txtPass1);
            this.PnRegistrar.Controls.Add(this.textBox2);
            this.PnRegistrar.Controls.Add(this.bttCrear);
            this.PnRegistrar.Controls.Add(this.lbApellidos);
            this.PnRegistrar.Controls.Add(this.lbNombre);
            this.PnRegistrar.Controls.Add(this.txtApellidos);
            this.PnRegistrar.Controls.Add(this.txtNombres);
            this.PnRegistrar.Location = new System.Drawing.Point(230, 53);
            this.PnRegistrar.Name = "PnRegistrar";
            this.PnRegistrar.Size = new System.Drawing.Size(498, 333);
            this.PnRegistrar.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Confirmar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Contraseña: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Correo: ";
            // 
            // bttAtrás2
            // 
            this.bttAtrás2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttAtrás2.BackgroundImage")));
            this.bttAtrás2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAtrás2.Location = new System.Drawing.Point(436, 267);
            this.bttAtrás2.Name = "bttAtrás2";
            this.bttAtrás2.Size = new System.Drawing.Size(49, 49);
            this.bttAtrás2.TabIndex = 34;
            this.bttAtrás2.TabStop = false;
            this.bttAtrás2.Click += new System.EventHandler(this.bttAtrás2_Click);
            // 
            // txtPass2
            // 
            this.txtPass2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.Location = new System.Drawing.Point(143, 221);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(295, 27);
            this.txtPass2.TabIndex = 33;
            this.txtPass2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass2_KeyUp);
            // 
            // txtPass1
            // 
            this.txtPass1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass1.Location = new System.Drawing.Point(143, 171);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(295, 27);
            this.txtPass1.TabIndex = 32;
            this.txtPass1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass1_KeyUp);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(143, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 27);
            this.textBox2.TabIndex = 31;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // bttCrear
            // 
            this.bttCrear.BackColor = System.Drawing.Color.Gray;
            this.bttCrear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCrear.Location = new System.Drawing.Point(196, 275);
            this.bttCrear.Name = "bttCrear";
            this.bttCrear.Size = new System.Drawing.Size(106, 32);
            this.bttCrear.TabIndex = 30;
            this.bttCrear.Text = "Crear";
            this.bttCrear.UseVisualStyleBackColor = false;
            this.bttCrear.Click += new System.EventHandler(this.bttCrear_Click);
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.ForeColor = System.Drawing.Color.White;
            this.lbApellidos.Location = new System.Drawing.Point(35, 77);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(88, 21);
            this.lbApellidos.TabIndex = 29;
            this.lbApellidos.Text = "Apellidos: ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(35, 24);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(79, 21);
            this.lbNombre.TabIndex = 28;
            this.lbNombre.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(143, 71);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(295, 27);
            this.txtApellidos.TabIndex = 27;
            this.txtApellidos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApellidos_KeyUp);
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(143, 21);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(295, 27);
            this.txtNombres.TabIndex = 26;
            this.txtNombres.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombres_KeyUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // bttCerrar
            // 
            this.bttCerrar.BackColor = System.Drawing.Color.White;
            this.bttCerrar.BackgroundImage = global::Proyecto.Properties.Resources.Close_button_;
            this.bttCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttCerrar.Location = new System.Drawing.Point(700, -1);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(28, 26);
            this.bttCerrar.TabIndex = 7;
            this.bttCerrar.TabStop = false;
            this.bttCerrar.Click += new System.EventHandler(this.bttCerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Proyecto.Properties.Resources.user_4;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(485, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 193);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proyecto.Properties.Resources.user_7;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(261, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 193);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto.Properties.Resources.user_6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 193);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(728, 25);
            this.label5.TabIndex = 64;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseMove);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTítulo_MouseUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(727, 392);
            this.Controls.Add(this.PnRegistrar);
            this.Controls.Add(this.PnInicioSesion);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bttAdministrador);
            this.Controls.Add(this.bttTecnico);
            this.Controls.Add(this.bttInvitado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttCerrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSesion_FormClosing);
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.PnInicioSesion.ResumeLayout(false);
            this.PnInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás1)).EndInit();
            this.PnRegistrar.ResumeLayout(false);
            this.PnRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttAtrás2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox bttCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttInvitado;
        private System.Windows.Forms.Button bttTecnico;
        private System.Windows.Forms.Button bttAdministrador;
        private System.Windows.Forms.Button bttIniciar;
        private System.Windows.Forms.PictureBox bttAtrás1;
        private System.Windows.Forms.Panel PnInicioSesion;
        private System.Windows.Forms.LinkLabel llbCrearCuenta;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Panel PnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox bttAtrás2;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttCrear;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

