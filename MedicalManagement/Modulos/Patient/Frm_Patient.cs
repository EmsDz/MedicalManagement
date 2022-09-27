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

namespace MedicalManagement.Modulos.Patient
{
    public partial class Frm_Patient : Compartidos.Frm_Root
    {
        public Frm_Patient()
        {
            InitializeComponent();
        }


        FrmAudit frmAudit = null;

        /// <summary>
        /// Metodo para ingresar o actualizar un paciente
        /// </summary>
        public void insertPatient(string id_patinet, string dni, string name, string lastName, string date_birth, string email, string phone, string record, int userId)
        {
            try
            {

                ///Abre una transaction a base de datos
                Bd_Context.procBeginTrans();
                /// sqlComandos  query
                SqlCommand cmd = null;
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Bd_Context.conexion;
                cmd.CommandText = "Pr_PatientAddOrUpdate";

                cmd.Parameters.AddWithValue("@id_Patient", id_patinet);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@date_birth", date_birth);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Medical_Record", record);
                cmd.Parameters.AddWithValue("@Id_User", userId);
                cmd.ExecuteNonQuery();

                /// Guardar los cambio si todo sale bien
                Bd_Context.procCommitTran();

                this.Menssage = "Patiente Creado / Actualizado";
                lblMensaje.ForeColor = System.Drawing.Color.Black;
                this.ColorError = false;

                Compartidos.C_Utility.FunClearControls(this);
                proRefreshDgv();



            }
            catch (Exception ex)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;

                this.Menssage = ex.Message.ToString().Trim();
                this.ColorError = true;

            }
            finally
            {
                this.lblMensaje.Text = this.Menssage;
                ///Cierra la base de datos 
                Bd_Context.procCloseConex();
                // C_Utility.FunShowMessageContainer(this.Menssage, this.ColorError);
            }
        }


        public bool validationData()
        {
            bool success = true; ;

            if (string.IsNullOrEmpty(txtLastN.Text) || string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(TxtName.Text))
            {
                success = false;
                this.Menssage = "Complete los campos ";
                this.lblMensaje.Text = Menssage.ToString();
            }






            return success;

        }

        /// <summary>
        /// muestra los pacientes
        /// </summary>
        public void proRefreshDgv()
        {
            string scrip = "exec Pr_PatientGetAll";
            data_gv_showitem.DataSource = Compartidos.Bd_Context.Fun_ejecutarScript(scrip, false);
        }
        private void PicCreateUser_Click(object sender, EventArgs e)
        {

            if (validationData())
                insertPatient(txtId.Text, txtDni.Text, TxtName.Text, txtLastN.Text, dateTimePicker1.Text,
                    txtEmail.Text, txtPhone.Text,
                    txtRecord.Text, Frm_Lgin.id_User);
        }

        private void PicNewPromo_Click(object sender, EventArgs e)
        {


            Compartidos.C_Utility.FunClearControls(this);
            txtId.Enabled = false;
            this.lblMensaje.Text = "";
            proRefreshDgv();
        }

        private void Frm_Patient_Load(object sender, EventArgs e)
        {
            proRefreshDgv();
        }

        public void EditPatientId(string quertys)
        {

            // limpia los controels 
            Compartidos.C_Utility.FunClearControls(this);



            // creando el query para consultar 
            DataTable dt = Compartidos.Bd_Context.Fun_ejecutarScript(quertys);

            /// asigancio de datos a controles
            txtId.Text = dt.Rows[0]["Id_Patient"].ToString();
            txtDni.Text = dt.Rows[0]["Dni"].ToString();
            TxtName.Text = dt.Rows[0]["Name"].ToString();
            txtLastN.Text = dt.Rows[0]["LastName"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtRecord.Text = dt.Rows[0]["Medical_Record"].ToString();
            dateTimePicker1.Text = dt.Rows[0]["date_birth"].ToString();


        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (data_gv_showitem.Rows.Count >= 1)
            {
                string sqlQuery = string.Format("Pr_PatientGetDataById {0} ",
                data_gv_showitem.CurrentRow.Cells["Id_Patient"].Value.ToString());
                EditPatientId(sqlQuery);

            }
        }

        private void picLog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                frmAudit = new FrmAudit();
                {
                    frmAudit.query = string.Format("EXEC	[Pr_PatientGetAllAuditById]		@Id_Patient ='{0}' ", txtId.Text.Trim());
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


                string sqlQuery = string.Format("Pr_PatientGetAuditById {0} ",
                frmAudit.dgvAuditoria.CurrentRow.Cells["InternalId"].Value.ToString());
                EditPatientId(sqlQuery);
                frmAudit.Close();

            }
        }
    }
}
