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
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }
        Procedimientos procedimientos = new Procedimientos();
        DataSet dt = new DataSet();
        DataView mostrar = new DataView();
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
            Close();
        }

        private void PicAgregar_Click(object sender, EventArgs e)
        {
            PicNueva_Click(sender, e);
        }

        private void PicNueva_Click(object sender, EventArgs e)
        {
            Mantenimiento nueva = new Mantenimiento(true);
            Hide();
            nueva.ShowDialog();
            Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PicActualizar_Click(sender,e);
        }

        private void PicActualizar_Click(object sender, EventArgs e)
        {
            if (Dato())
            {
                Mantenimiento nueva = new Mantenimiento(false);
                Hide();
                nueva.ShowDialog();
                Show();
            }
            else
                MessageBox.Show("No ha seleccionado ningún registro", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PicEliminar_Click(object sender, EventArgs e)
        {
            if (Dato())
            {
                if (MessageBox.Show("¿Seguro que desea eliminar este registro?","Confirmar eliminación",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    OracleParameter[] Parámetros = new OracleParameter[1];
                    Parámetros[0] = new OracleParameter("P_Codigo", Globales.gbDato.Código1);
                    if (procedimientos.LlenarTabla("Administrador.Recursos.Eliminar", Parámetros) == 1)
                    {
                        MessageBox.Show("Ocurrió un error al eliminar " + Globales.gbError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("¡Datos eliminados correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            else
                MessageBox.Show("No ha seleccionado un registro a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PicEliminar_Click(sender, e);
        }

        private void PicBuscar_Click(object sender, EventArgs e)
        {
            dgvBúsqueda.DataSource = null;
            OracleParameter[] Parámetros = new OracleParameter[1];
            Parámetros[0] = new OracleParameter("P_Codigo", Globales.gbDato.Código1);
            dt=procedimientos.Llenar_DataSet("Administrador.Recursos.Eliminar", Parámetros,"Cantantes");
            mostrar = ((DataTable)dt.Tables["Cantantes"]).DefaultView;
            dgvBúsqueda.DataSource = mostrar;
        }
        private void Biblioteca_Load(object sender, EventArgs e)
        {
            try
            {
                dgvBúsqueda.DataSource = null;
                OracleParameter[] parámetros = new OracleParameter[1];
                parámetros[0] = new OracleParameter("CursorDatos", OracleDbType.RefCursor);
                dt = procedimientos.Llenar_DataSet("Administrador.Recursos.MostrarCantantes", parámetros, "Cantantes");
                mostrar = ((DataTable)dt.Tables["Cantantes"]).DefaultView;
                dgvBúsqueda.DataSource = mostrar;
            }
            catch { }
        }

        private bool Dato()
        {
#warning Faltan: cantante y genero
            if (dgvBúsqueda.SelectedRows.Count == 1)
            {
                try
                {
                    DataGridViewRow dgvv = null;
                    int i = dgvBúsqueda.CurrentCell.RowIndex;
                    dgvv = dgvBúsqueda.Rows[i];
                    Globales.gbDato.Código1 = int.Parse(dgvv.Cells[0].Value.ToString());
                    Globales.gbDato.Titulo1 = dgvv.Cells[0].Value.ToString();
                    Globales.gbDato.Album1 = dgvv.Cells[0].Value.ToString();
                    Globales.gbDato.Año1 = int.Parse(dgvv.Cells[0].Value.ToString());
                    Globales.gbDato.Duración = dgvv.Cells[0].Value.ToString();
                    if (!String.IsNullOrEmpty(Globales.gbDato.Código1.ToString()))
                        return true;
                }
                catch
                {
                   
                }
            }
            return false;
        }
    }
}
