using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalManagement.Compartidos;

namespace MedicalManagement.Compartidos.Form_
{
    public partial class Frm_Lgin : Frm_Root
    {
        public Frm_Lgin()
        {
            InitializeComponent();

            this.GoToFrmClosing = true;
        }
        public static int id_User = 1;


        /// <summary>
        /// Consulta un usario y clave en bd 
        /// y devuelve true si esta logeado
        /// </summary>
        /// <param name="User"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        private bool LoginUser(string User, string pass)
        {
            id_User = 0;

            bool result = false;
            try
            {
                ///Abre una transaction a base de datos
                Bd_Context.procBeginTrans();

                /// sqlComandos  query
                SqlCommand cmd = null;
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Bd_Context.conexion;
                cmd.CommandText = "Pr_UserLogin";

                cmd.Parameters.AddWithValue("@Name", User);
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.Parameters.Add("@LogOn", SqlDbType.VarChar, 2);
                cmd.Parameters["@LogOn"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                id_User = int.Parse(cmd.Parameters["@LogOn"].Value.ToString());

                /// Guardar los cambio si todo sale bien
                Bd_Context.procCommitTran();

                this.Menssage = "Producto Creado / Actualizado";
                this.ColorError = false;
                result = (id_User > 0) ? true : false;


            }
            catch (Exception ex)
            {
                result = false;
                this.Menssage = ex.Message.ToString().Trim();
                this.ColorError = true;
            }
            finally
            {
                ///Cierra la base de datos 
                Bd_Context.procCloseConex();
                // C_Utility.FunShowMessageContainer(this.Menssage, this.ColorError);
            }

            return result;
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()) || string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Complete Todos los campos");
                return;
            }


            if (LoginUser(txtUser.Text.Trim(), txtPass.Text.Trim()))
            {
                FrmMenu frmMenu = new FrmMenu();

                Program.FrmMain = frmMenu;
                frmMenu.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Datos incorrectos");






        }

        private void Frm_Lgin_FormClosing(object sender, FormClosingEventArgs e) => Compartidos.C_Utility.Fun_ExitApp();

        private void Frm_Lgin_Load(object sender, EventArgs e)
        {

        }
    }
}
