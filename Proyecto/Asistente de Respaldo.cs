using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
//using Oracle.ManagedDataAccess.Client;

namespace Proyecto
{
    public partial class Asistente_de_Respaldo : Form
    {
        DialogResult dialog = DialogResult.Cancel;
        public Asistente_de_Respaldo()
        {
            InitializeComponent();
        }
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

        private void pbDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Guardar = new FolderBrowserDialog();
            dialog = Guardar.ShowDialog();
            if(dialog==DialogResult.OK)
                txtDirectorio.Text = Guardar.SelectedPath;
        }

        private void bttRespaldar_Click(object sender, EventArgs e)
        {
            if (dialog == DialogResult.OK)
            {
                string dump = (txtDumpfile.Text.Trim(' ') == "" ? "prueba" : txtDumpfile.Text);
                string log = (txtLogfile.Text.Trim(' ') == "" ? "prueba" : txtLogfile.Text);
                String cadena1 = "@echo off ";
                String cadena2 = "title Respaldo de base de dato Oracle ";
                String cadena3 = "echo Iniciando respaldo ";
                String cadena4 = "expdp system/654321"/* + Globales.gbServidor */+ " dumpfile=" + dump + ".dmp" + " logfile=" + log + ".log" + " directory=EXPORT_COMPLETO full=y ";
                String cadena5 = "echo Respaldo finalizado";
                String cadena6 = "pause ";
                String cadena7 = "exit";
                if (Directory.Exists(txtDirectorio.Text + @"\RespaldoBD"))
                    try
                    {
                        Directory.Delete(txtDirectorio.Text + @"\RespaldoBD");
                    }
                    catch
                    {

                    }
                        Directory.CreateDirectory(txtDirectorio.Text+ @"\RespaldoBD");
                String nombre = @"\Respaldo.bat";
                MessageBox.Show(txtDirectorio.Text + nombre);
                StreamWriter escribir = new StreamWriter(txtDirectorio.Text+ @"\RespaldoBD" + nombre);
                escribir.WriteLine(cadena1);
                escribir.WriteLine(cadena2);
                escribir.WriteLine(cadena3);
                escribir.WriteLine(cadena4);
                escribir.WriteLine(cadena5);
                escribir.WriteLine(cadena6);
                escribir.WriteLine(cadena7);
                escribir.Close();
                Process.Start(txtDirectorio.Text + @"\RespaldoBD" + nombre);
            }
        }

        private void bttAtrás_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    #region ED
    /*
    public partial class OpcionesFinal : Form
    {
        public static int valor;

        public OpcionesFinal()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Procedimientos procedimientos = new Procedimientos();
        private void OpcionesFinal_Load(object sender, EventArgs e)
        {
            OracleParameter[] parámetros = new OracleParameter[1];
            parámetros[0] = new OracleParameter("cursorTabla", OracleDbType.RefCursor);
            dt = procedimientos.llenar_DataTable("packselect.Cargar_Tablas", parámetros);
            txtTabla.DataSource = dt;
            txtTabla.DisplayMember = "Tablas";
            txtTabla.ValueMember = "Tablas";
            if (valor == 1)
            {
                txtEsquema.ReadOnly = true;
                txtEsquema.Enabled = false;
                txtTabla.Enabled = false;
            }
            if (valor == 2)
            {
                txtTabla.Enabled = false;
            }
            if (valor == 3)
            {
                txtEsquema.ReadOnly = true;
                txtEsquema.Enabled = false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            //FmExportOpc frm1 = new FmExportOpc();
            //creacion de .bat
            if (valor == 1)
            {

                String cadena1 = "@echo off ";
                String cadena2 = "title Respaldo de base de dato Oracle ";
                String cadena3 = "echo Iniciando respaldo ";
                String cadena4 = "expdp system/2Stratosphere@" + Globales.gbServidor + " dumpfile=" + txtDumpfile.Text + ".dmp" + " logfile=" + txtLogfile.Text + ".log" + " directory=EXPORT_COMPLETO full=y ";
                String cadena5 = "echo Respaldo finalizado";
                String cadena6 = "pause ";
                String cadena7 = "exit";

                //creacion de ruta para la carpeta que contendra el respaldo
                Directory.CreateDirectory("C:\\RespaldoBD");
                //creacion de .bat
                //MessageBox.Show(cadena);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "bat file|*.bat";
                save.Title = "Save ";
                save.FileName = "respaldo";
                var res = save.ShowDialog();
                String dirección = Path.GetDirectoryName(save.FileName);
                String nombre = Path.GetFileName(save.FileName);
                StreamWriter escribir = new StreamWriter(save.FileName);
                escribir.WriteLine(cadena1);
                escribir.WriteLine(cadena2);
                escribir.WriteLine(cadena3);
                escribir.WriteLine(cadena4);
                escribir.WriteLine(cadena5);
                escribir.WriteLine(cadena6);
                escribir.WriteLine(cadena7);
                escribir.Close();
                Process.Start(dirección + @"/" + nombre);
            }
            if (valor == 2)
            {
                String cadena1 = "@echo off ";
                String cadena2 = "title Respaldo de base de dato Oracle ";
                String cadena3 = "echo Iniciando respaldo ";
                String cadena4 = "expdp system/2Stratosphere@" + Globales.gbServidor + " schemas=" + Globales.gbORacle_Usuario + " directory=EXPORT_ESQUEMA dumpfile=" + txtDumpfile.Text + ".dmp" + " logfile=" + txtLogfile.Text + ".log";
                String cadena5 = "echo Respaldo finalizado";
                String cadena6 = "pause ";
                String cadena7 = "exit";
                //creacion de ruta para la carpeta que contendra el respaldo
                Directory.CreateDirectory("C:\\RespaldoBD");
                //creacion de .bat
                //MessageBox.Show(cadena);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "bat file|*.bat";
                save.Title = "Save ";
                save.FileName = "respaldo";
                var res = save.ShowDialog();
                String dirección = Path.GetDirectoryName(save.FileName);
                String nombre = Path.GetFileName(save.FileName);
                StreamWriter escribir = new StreamWriter(save.FileName);
                escribir.WriteLine(cadena1);
                escribir.WriteLine(cadena2);
                escribir.WriteLine(cadena3);
                escribir.WriteLine(cadena4);
                escribir.WriteLine(cadena5);
                escribir.WriteLine(cadena6);
                escribir.WriteLine(cadena7);
                escribir.Close();
                Process.Start(dirección + @"/" + nombre);
            }
            if (valor == 3)
            {
                String cadena1 = "@echo off ";
                String cadena2 = "title Respaldo de base de dato Oracle ";
                String cadena3 = "echo Iniciando respaldo ";
                String cadena4 = "expdp system/2Stratosphere@" + Globales.gbServidor + " tables=" + txtTabla.Text + " directory=EXPORT_TABLAS dumpfile=" + txtDumpfile.Text + ".dmp" + " logfile=" + txtLogfile.Text + ".log";
                String cadena5 = "echo Respaldo finalizado";
                String cadena6 = "pause ";
                String cadena7 = "exit";
                //creacion de ruta para la carpeta que contendra el respaldo
                Directory.CreateDirectory("C:\\RespaldoBD");
                //creacion de .bat
                //MessageBox.Show(cadena);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "bat file|*.bat";
                save.Title = "Save ";
                save.FileName = "respaldo";
                var res = save.ShowDialog();
                String dirección = Path.GetDirectoryName(save.FileName);
                String nombre = Path.GetFileName(save.FileName);
                StreamWriter escribir = new StreamWriter(save.FileName);
                escribir.WriteLine(cadena1);
                escribir.WriteLine(cadena2);
                escribir.WriteLine(cadena3);
                escribir.WriteLine(cadena4);
                escribir.WriteLine(cadena5);
                escribir.WriteLine(cadena6);
                escribir.WriteLine(cadena7);
                escribir.Close();
                Process.Start(dirección + @"/" + nombre);
            }
            this.Close();

            //MessageBox.Show("La Exportacion ha sido finalizada con éxito");
        }

    }
    */
    #endregion
}
