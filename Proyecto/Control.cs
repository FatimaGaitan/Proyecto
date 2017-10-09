using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Control : Form
    {
        public Control()
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

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void bttAtrás2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            //Cargar aqui los datos de control
            try
            {
                DataSet dt = new DataSet();
                DataView mostrar = new DataView();
                Procedimientos procedimientos = new Procedimientos();
                dgvControl.DataSource = null;
                OracleParameter[] parámetros = new OracleParameter[1];
                parámetros[0] = new OracleParameter("CursorDatos", OracleDbType.RefCursor);
                dt = procedimientos.Llenar_DataSet("Administrador.Recursos.MostrarCantantes", parámetros, "Cantantes");
                mostrar = ((DataTable)dt.Tables["Cantantes"]).DefaultView;
                dgvControl.DataSource = mostrar;
            }
            catch { }
        }
    }
}
