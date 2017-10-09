using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {

        }
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

        private void bttAtrás_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbRespaldo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Asistente_de_Respaldo Asistir = new Asistente_de_Respaldo();
            Hide();
            Asistir.ShowDialog();
            Show();
        }
    }
}
