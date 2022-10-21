using MedicalManagement.Compartidos;
using MedicalManagement.Compartidos.Form_;
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

namespace MedicalManagement.Modulos.Medicos
{
    public partial class FrmMedicos : Frm_Root
    {
        public FrmMedicos()
        {
            InitializeComponent();
            this.GoToFrmClosing = true;
        }
        FrmAudit frmAudit = null;

        /// <summary>
        /// muestra los pacientes
        /// </summary>
        public void ProRefreshDgv()
        {
            string scrip = "exec Pr_MedicaltGetAll";
            /// No permite que se agregen columnas automaticamente
            data_gv.AutoGenerateColumns = false;
            data_gv.DataSource = Bd_Context.Fun_ejecutarScript(scrip, false);

            /// actualiza la var global para cuando se exporte a excel
            this.dtGridView = data_gv;
        }

        public bool ValidationData()
        {
            bool success = true; ;

            if (string.IsNullOrEmpty(txtSpecia.Text) || string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(TxtName.Text))
            {
                success = false;
                this.Menssage = "Complete los campos ";
                this.lblMensaje.Text = Menssage.ToString();
            }
            return success;
        }

        private void PicLog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                frmAudit = new FrmAudit();
                {
                    frmAudit.query = string.Format("EXEC	[Pr_MedicalGetAllAuditById]		@Id_Medico ='{0}' ", txtId.Text.Trim());
                    frmAudit.BtnVer.Click += BtnVer_Click;
                    frmAudit.ShowDialog();
                }
            }
            else
                MessageBox.Show("Debe Editar el paciente  para mostrar");
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (frmAudit.dgvAuditoria.Rows.Count >= 1)
            {
                string sqlQuery = string.Format("Pr_MedicalGetAuditById {0} ",
                frmAudit.dgvAuditoria.CurrentRow.Cells["InternalId"].Value.ToString());
                EditMedico(sqlQuery);
                frmAudit.Close();
            }
        }

        private void PicNewPromo_Click(object sender, EventArgs e)
        {
            Compartidos.C_Utility.FunClearControls(this);
            txtId.Enabled = false;
            this.lblMensaje.Text = "";
            ProRefreshDgv();
        }

        public void EditMedico(string quertys)
        {

            // limpia los controels 
            Compartidos.C_Utility.FunClearControls(this);

            // creando el query para consultar 
            DataTable dt = Compartidos.Bd_Context.Fun_ejecutarScript(quertys);

            /// asigancio de datos a controles
            txtId.Text = dt.Rows[0]["Id"].ToString();
            txtDni.Text = dt.Rows[0]["Cedula"].ToString();
            TxtName.Text = dt.Rows[0]["nameComplete"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtSpecia.Text = dt.Rows[0]["NameSpecialite"].ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (data_gv.Rows.Count >= 1)
            {
                string sqlQuery = string.Format("Pr_MedicalGetDataById {0} ",
                data_gv.CurrentRow.Cells["Id"].Value.ToString());
                EditMedico(sqlQuery);
            }
        }

        /// <summary>
        /// Metodo para ingresar o actualizar un paciente
        /// </summary>
        public void InsertMedico(string id_patinet, string dni, string name, string specialite, string email, int userId)
        {
            try
            {
                ///Abre una transaction a base de datos
                Bd_Context.ProcBeginTrans();
                /// sqlComandos  query
                SqlCommand cmd = null;
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Bd_Context.conexion;
                cmd.CommandText = "Pr_MedicalAddOrUpdate";

                cmd.Parameters.AddWithValue("@Id_Medico", id_patinet);
                cmd.Parameters.AddWithValue("@nameComplete", name);
                cmd.Parameters.AddWithValue("@Cedula", dni);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@NameSpecialite", specialite);
                cmd.Parameters.AddWithValue("@id_user", userId);
                cmd.ExecuteNonQuery();

                /// Guardar los cambio si todo sale bien
                Bd_Context.ProcCommitTran();

                this.Menssage = "Medico Creado / Actualizado";
                lblMensaje.ForeColor = Color.Black;
                this.ColorError = false;

                Compartidos.C_Utility.FunClearControls(this);
                ProRefreshDgv();
            }
            catch (Exception ex)
            {
                lblMensaje.ForeColor = Color.Red;

                this.Menssage = ex.Message.ToString().Trim();
                this.ColorError = true;
            }
            finally
            {
                this.lblMensaje.Text = this.Menssage;
                ///Cierra la base de datos 
                Bd_Context.ProcCloseConex();
                // C_Utility.FunShowMessageContainer(this.Menssage, this.ColorError);
            }
        }

        private void PicCreateUser_Click(object sender, EventArgs e)
        {
            if (ValidationData())
                InsertMedico(txtId.Text, txtDni.Text, TxtName.Text, txtSpecia.Text, txtEmail.Text, Frm_Lgin.id_User);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            ProRefreshDgv();
        }
    }
}
