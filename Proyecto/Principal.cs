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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
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
        #endregion
        #region Botones
        private void bttCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PicConfiguración_Click(object sender, EventArgs e)
        {
            Configuraciones Acción = new Configuraciones();
            this.Hide();
            Acción.ShowDialog();
            this.Show();
        }
        private void PicBiblioteca_Click(object sender, EventArgs e)
        {
            Biblioteca Acción = new Biblioteca();
            this.Hide();
            Acción.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
