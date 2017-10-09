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
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }
        #region Personalización Barra Título
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

        private void bttAtrás_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicAgregar_Click(object sender, EventArgs e)
        {
            Mantenimiento nueva = new Mantenimiento(true);
            this.Hide();
            nueva.Show();
            this.Show();
        }

        private void PicNueva_Click(object sender, EventArgs e)
        {
            Mantenimiento nueva = new Mantenimiento(true);
            this.Hide();
            nueva.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Mantenimiento nueva = new Mantenimiento(false);
            this.Hide();
            nueva.ShowDialog();
            this.Show();
        }

        private void PicActualizar_Click(object sender, EventArgs e)
        {
            Mantenimiento nueva = new Mantenimiento(false);
            this.Hide();
            nueva.ShowDialog();
            this.Show();
        }

        private void PicEliminar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
