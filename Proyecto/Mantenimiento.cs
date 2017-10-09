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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento(bool nuevo)
        {
            InitializeComponent();
            PicNueva.Visible = nuevo;
        }
        DataTable dt = new DataTable();
        Procedimientos procedimientos = new Procedimientos();

        #region MoverForm 
        bool Empezarmover = false;
        int PosX;
        int PosY;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Empezarmover = true;
                PosX = e.X;
                PosY = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Empezarmover = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Empezarmover)
            {
                Point temp = new Point();
                temp.X = Location.X + (e.X - PosX);
                temp.Y = Location.Y + (e.Y - PosY);
                Location = temp;
            }
        }
        #endregion

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones.IsNotNullOrEmty(ref txtTítulo, ref errorProvider1) &&
                 Validaciones.IsNotNullOrEmty(ref txtÁlbum, ref errorProvider1) &&
                 Validaciones.validar_Duración(ref txtDuración, ref errorProvider1) &&
                 Validaciones.validar_Año(ref txtAño, ref errorProvider1))
            {
                string mensaje = (PicNueva.Visible ? "Se añadirá la canción a la base de datos ¿Desea continuar?" : "Se actualizará la canción seleccionada ¿Desea continuar?");
                string procedimiento = (PicNueva.Visible ? "Administrador.Registro.Insertar" : "Administrador.Registro.Actualizar");
                if (MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    OracleParameter[] Parámetros = new OracleParameter[6];
                    if (!PicNueva.Visible)
                    {
                        Parámetros = new OracleParameter[7];
                        Parámetros[6] = new OracleParameter("P_Codigo", 10000/*Globales.gbDato.Código1*/);
                    }
                    Parámetros[0] = new OracleParameter("P_Titulo", "sjdhka"/*txtTítulo.Text*/);
                    Parámetros[1] = new OracleParameter("P_Año", 2000/*txtAño.Text*/);
                    Parámetros[2] = new OracleParameter("P_Duracion", "30:59"/*txtDuración.Text*/);
                    Parámetros[3] = new OracleParameter("P_Album", "ajsjasshd"/*txtÁlbum.Text*/);
                    Parámetros[4] = new OracleParameter("P_Id_Cantante", 10000/*cbCantante.ValueMember*/);
                    Parámetros[5] = new OracleParameter("P_Id_Genero", 10000/*cbGénero.ValueMember*/);
                    if (procedimientos.LlenarTabla(procedimiento, Parámetros) == 1)
                    {
                        MessageBox.Show("Ocurrió un error al insertar" + Globales.gbError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("¡Datos insertados correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
        }

        private void bttAtrás_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir sin guardar cambios?", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        private void txtTítulo_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.IsNotNullOrEmty(ref txtTítulo, ref errorProvider1);
        }

        private void txtÁlbum_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.IsNotNullOrEmty(ref txtÁlbum, ref errorProvider1);
        }

        private void txtAño_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.validar_Año(ref txtAño, ref errorProvider1);
        }

        private void txtDuración_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones.validar_Duración(ref txtDuración,ref errorProvider1);
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                OracleParameter[] parámetros = new OracleParameter[1];
            //Género
            parámetros[0] = new OracleParameter("CursorDatos", OracleDbType.RefCursor);
            dt = procedimientos.Llenar_DataTable("Administrador.Registro.Mostrar_Generos", parámetros);
            cbGénero.DataSource = dt;
            cbGénero.DisplayMember = "Genero";
            cbGénero.ValueMember = "Id_Genero";
            //Cantante
            parámetros[0] = new OracleParameter("CursorDatos", OracleDbType.RefCursor);
            dt = procedimientos.Llenar_DataTable("Administrador.Registro.Mostrar_Cantantes", parámetros);
            cbCantante.DataSource = dt;
            cbCantante.DisplayMember = "Nombre";
            cbCantante.ValueMember = "Id_Cantante";
            txtTítulo.Focus();
            
                cbGénero.SelectedIndex = 0;
                cbCantante.SelectedIndex = 0;
                txtTítulo.Text = Globales.gbDato.Titulo1;
                txtAño.Text = Globales.gbDato.Año1.ToString();
                txtDuración.Text=Globales.gbDato.Duración;
                txtÁlbum.Text = Globales.gbDato.Album1;
                cbCantante.SelectedIndex = cbCantante.FindString(Globales.gbDato.Id_Cantante1);
                cbGénero.SelectedIndex = cbGénero.FindString(Globales.gbDato.Id_Genero1);
            }
            catch { }
        }
    }
}
