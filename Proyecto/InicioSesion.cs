using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

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
            this.Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            DataRow dr;
            Procedimientos Procedimientos = new Procedimientos();
            OracleParameter[] parámetros = new OracleParameter[2];
            Principal Acción = new Principal();
            this.Hide();
            Acción.ShowDialog();
            this.Show();
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
    }
}
