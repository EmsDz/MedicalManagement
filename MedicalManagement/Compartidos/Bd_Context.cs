using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Compartidos
{
    public static class Bd_Context
    {

        public static SqlConnection conexion = null;

        public static string TransacName = "";

        /// <summary>
        /// Conexion a base de datos
        /// </summary>
        /// <param name="cmd">comando a ejecutar</param>
        /// <param name="conClose">true o false para cerrar la conexion a base de tatos </param>
        /// <returns></returns>
        public static DataTable Fun_ejecutarScript(string cmd, bool conClose = true)
        {
            cmd = cmd.Replace("delete", "").Replace("truncate", "").Replace("drop", "").Replace("update", "");
            // si la conexion es null la inicia
            if (conexion == null)
                conexion = new SqlConnection(Properties.Settings.Default.BdConex.ToString());

            // si la conexion esta cerrada la abre
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();/// Abre la conexion a la bd

            DataTable data = new DataTable(); /// Tabla que contiene lo que devuelva la base de datos 
            SqlCommand sqCmd = new SqlCommand(cmd, conexion);
            sqCmd.CommandType = CommandType.Text;  // nueva linea ojo
            sqCmd.CommandTimeout = 5000;
            SqlDataAdapter ader = new SqlDataAdapter(sqCmd);/// Adaptador de datos
            ader.Fill(data);

            // si se ordena cerrara la conexion  a
            if (conClose == true)
                conexion.Close();

            return data;
        }

        /// <summary>
        /// Inicia una transaccion en base de datos
        /// </summary>
        public static void procBeginTrans() => Fun_ejecutarScript("Begin Tran trx", false);

        /// <summary>
        /// Inicia una transaccion en base de datos
        /// </summary>
        public static void procCommitTran() => Fun_ejecutarScript("Commit Tran trx", true);

        /// <summary>
        /// Inicia una transaccion en base de datos
        /// </summary>
        public static void procRollbackTrans() => Fun_ejecutarScript("rollback Tran Trx", true);
        /// <summary>
        /// Cierra la conexion a base de datos
        /// </summary>
        public static void procCloseConex()
        {
            // si la conexion esta cerrada la abre
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
        }
    }
}
