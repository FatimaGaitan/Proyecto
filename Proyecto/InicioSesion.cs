using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proyecto
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            Ocultar();
        }
        DialogResult cerrar = DialogResult.Cancel;
        Procedimientos procedimientos = new Procedimientos();

        #region Botones
        public Point botones = new Point(41,287);
        public Point Pic = new Point(41,76);
        public void Ocultar()
        {
            PnInicioSesion.Visible = false;
            PnRegistrar.Visible = false;
        }
        public void Usuarios()
        {
            bttInvitado.Visible = false;
            bttTecnico.Visible = false;
            bttAdministrador.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void bttAdministrador_Click(object sender, EventArgs e)
        {
            Usuarios();
            bttAdministrador.Visible = true;
            bttAdministrador.Enabled = false;
            pictureBox1.Visible = true;
            PnInicioSesion.Visible = true;
        }

        private void bttTecnico_Click(object sender, EventArgs e)
        {
            Usuarios();
            bttTecnico.Location = botones;
            pictureBox2.Location= Pic;
            bttTecnico.Visible = true;
            pictureBox2.Visible = true;
            bttTecnico.Enabled = false;
            PnInicioSesion.Visible = true;
        }

        private void bttInvitado_Click(object sender, EventArgs e)
        {
            Usuarios();
            bttInvitado.Location = botones;
            pictureBox3.Location = Pic;
            bttInvitado.Visible = true;
            bttInvitado.Enabled = false;
            pictureBox3.Visible = true;
            PnInicioSesion.Visible = true;
        }

        private void bttAtrás1_Click(object sender, EventArgs e)
        {
            bttInvitado.Visible = true;
            bttTecnico.Visible = true;
            bttAdministrador.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            PnInicioSesion.Visible = false;
            bttTecnico.Location = new Point(259, 287) ;
            pictureBox2.Location = new Point(259, 76);
            bttInvitado.Location = new Point(485, 287);
            pictureBox3.Location = new Point(485, 76);
            bttAdministrador.Enabled = true;
            bttTecnico.Enabled = true;
            bttInvitado.Enabled = true;
        }

        private void bttAtrás2_Click(object sender, EventArgs e)
        {
            PnRegistrar.Visible = false;
            PnInicioSesion.Visible = true;
            
        }
        private void llbCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnRegistrar.Visible = true;
            PnInicioSesion.Visible = false;
        }
        #endregion
        #region Personalización Barra de Título
        private Point pos = new Point();
        private bool move = false;

        private void txtTítulo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void txtTítulo_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }
        private void txtTítulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X), (this.Top + e.Y - pos.Y));
        }

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void bttIniciar_Click(object sender, EventArgs e)
        {
#warning Adaptar a los de Fátima
            Cursor = Cursors.WaitCursor;
            //DataSet ds = new DataSet();
            //DataRow dro;
            //OracleParameter[] parámetros = new OracleParameter[3];
            //parámetros[0] = new OracleParameter("", txtCorreo.Text);
            //parámetros[1] = new OracleParameter("", Cifrado.encriptar(txtPass1.Text));
            //parámetros[2] = new OracleParameter("Cursor_Busqueda", OracleDbType.RefCursor);
            //ds = procedimientos.Llenar_DataSet("Administrador.Registro.Buscar_Usuario", parámetros, "usuario");
            //if (ds.Tables["usuario"] != null)
            //{
            //    dro = ds.Tables["usuario"].Rows[0];
            //    if (Cifrado.desencriptar(txtContraseña.Text, dro["Clave"].ToString()))
            //    {
            //        this.Cursor = Cursors.Default;
            //        Globales.Inicializar(dro["Código"].ToString(), dro["Nombre"].ToString(), dro["Tipo de Usuario"].ToString(), dro["Clave"].ToString());
            Principal Acción = new Principal();
            this.Hide();
            Acción.ShowDialog();
            this.Show();
            txtContraseña.Text = "";
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(txtContraseña, "Clave incorrecta");
            //    }
            //}
            Cursor = Cursors.Default;
        }
        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cerrar == DialogResult.Cancel)
            {
                DialogResult = MessageBox.Show("¿Está seguro que desea salir?", "Cerrando Programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = true;
            txtPass2.UseSystemPasswordChar = true;
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtNombres_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.validar_Nombre(ref txtNombres, ref errorProvider1);
        }

        private void txtApellidos_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.ValidarNomApe(ref txtApellidos, ref errorProvider1);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.validar_correo(ref textBox2, ref errorProvider1);
        }

        private void txtPass1_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.validar_contraseñas(ref txtPass1, ref errorProvider1);
        }

        private void txtPass2_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.Contraseñas_Iguales(ref txtPass1, ref txtPass1, ref errorProvider1);
        }

        private void bttCrear_Click(object sender, EventArgs e)
        {
            if (Validaciones.validar_Nombre(ref txtNombres, ref errorProvider1) &&
                Validaciones.ValidarNomApe(ref txtApellidos, ref errorProvider1) &&
                Validaciones.validar_correo(ref textBox2, ref errorProvider1) &&
                Validaciones.validar_contraseñas(ref txtPass1, ref errorProvider1) &&
                Validaciones.Contraseñas_Iguales(ref txtPass1, ref txtPass1, ref errorProvider1))
            {
#warning Adaptar a los procedimientos de Fati
                string TipoUsuario = "Cliente";
                if (bttAdministrador.Visible)
                    TipoUsuario = "Administrador";
                else if (bttTecnico.Visible)
                    TipoUsuario = "Tecnico";
                MessageBox.Show(TipoUsuario);
                //OracleParameter[] parámetros = new OracleParameter[5];
                //parámetros[0] = new OracleParameter("", txtNombres.Text);
                //parámetros[1] = new OracleParameter("", txtApellidos.Text);
                //parámetros[2] = new OracleParameter("", txtCorreo.Text);
                //parámetros[3] = new OracleParameter("", Cifrado.encriptar(txtPass1.Text));
                //parámetros[4] = new OracleParameter("", TipoUsuario);
                //if (procedimientos.LlenarTabla("packselect.insert_Usuario", parámetros) == 1)
                //{
                //    MessageBox.Show("Ocurrió un error al insertar" + Globales.gbError);
                //}
                //else
                //{
                //    DialogResult = DialogResult.OK;
                //    this.Close();
                //}
            }
        }
    }
}
