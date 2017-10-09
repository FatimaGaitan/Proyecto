using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proyecto
{
    public partial class Procedimientos
    {
        Conexión cn;
        OracleCommand Comando;
        public int LlenarTabla(String procedimiento, OracleParameter[] param)
        {
            int resultado = 0;
            cn = new Conexión();
            try
            {
                OracleConnection con = new OracleConnection(cn.cadena);
                con.InfoMessage += new OracleInfoMessageEventHandler(con_InfoMessage);
                con.Open();
                Comando = new OracleCommand(procedimiento, con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = procedimiento;
                OracleDataAdapter oda = new OracleDataAdapter(Comando);
                for(int x =0; x < (param.Length);x++)
                {
                    Comando.Parameters.Add(param[x]);
                    resultado = Comando.ExecuteNonQuery();
                }
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
        public DataTable Llenar_DataTable(String procedimiento)
        {
            cn = new Conexión();
            DataTable dt = new DataTable();
            try
            {
                OracleConnection con = new OracleConnection(cn.cadena);
                con.Open();
                Comando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter oda = new OracleDataAdapter(Comando);
                oda.Fill(dt);
                oda.Dispose();
                con.Close();
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable Llenar_DataTable(String procedimiento, OracleParameter[] param)
        {
            cn = new Conexión();
            DataTable dt = new DataTable();
            try
            {
                OracleConnection con = new OracleConnection(cn.cadena);
                con.Open();
                Comando = new OracleCommand();
                Comando.Connection = con;
                Comando.CommandText = procedimiento;
                for(int x = 0; x < (param.Length); x++)
                {
                    Comando.Parameters.Add(param[x]).Direction = ParameterDirection.Output;
                    OracleDataAdapter oda = new OracleDataAdapter(Comando);
                    oda.SelectCommand = Comando;
                    oda.Fill(dt);
                    oda.Dispose();
                    con.Clone();
                }
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataSet Llenar_DataSet(String procedimiento, OracleParameter[] param, String tabla)
        {
            cn = new Conexión();
            DataSet ds = new DataSet();
            try
            {
                OracleConnection con = new OracleConnection(cn.cadena);
                con.InfoMessage += new OracleInfoMessageEventHandler(con_InfoMessage);
                con.Open();
                Comando = new OracleCommand();
                Comando.Connection = con;
                Comando.CommandText = procedimiento;
                Comando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter oda = new OracleDataAdapter(Comando);
                for(int x =0; x < (param.Length); x++)
                {
                    Comando.Parameters.Add(param[x]);
                }
                Comando.Parameters.Add(param[param.Length - 1]).Direction = ParameterDirection.Output;
                int registtro = oda.Fill(ds, tabla);
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }
       
        public void con_InfoMessage(object sender, OracleInfoMessageEventArgs e)
        {
            String mensaje = "";
            if(e.Errors.Count > 0)
            {
                mensaje = e.Errors[0].Message;
            }
            Globales.gbError = mensaje;
        }
    }
}
