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

namespace MedicalManagement.Modulos.Facturas
{
    public partial class FrmFact : Frm_Root
    {
        public FrmFact()
        {
            InitializeComponent();
        }

        public string docentrys = "";

        public static int id_patients = 0;
        public static int id_medicals = 0;

        public PictureBox obj = null;

        FrmAudit frmPartner = null;

        FrmAudit frmAudit = null;

        /// <summary>
        /// Metodo para ingresar o actualizar un paciente
        /// </summary>
        public void InsertFac(string Docentry, string id_pacient, string Id_Medico, string @Id_user, string @Note, string @Docdate)
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
                cmd.CommandText = "Pr_FacAddOrUpdate";

                cmd.Parameters.AddWithValue("@Docentry", Docentry);
                cmd.Parameters.AddWithValue("@Id_Pacient", id_patients);
                cmd.Parameters.AddWithValue("@Id_Medico", id_medicals);
                cmd.Parameters.AddWithValue("@Id_user", Id_user);
                cmd.Parameters.AddWithValue("@Note", Note);
                cmd.Parameters.AddWithValue("@Docdate", Docdate);


                cmd.Parameters.Add("@Docnum", SqlDbType.Int);
                cmd.Parameters.Add("@Internal", SqlDbType.Int);
                cmd.Parameters["@Internal"].Direction = ParameterDirection.Output;
                cmd.Parameters["@Docnum"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();


                string InternalDoc = (cmd.Parameters["@Internal"].Value.ToString());
                docentrys = (cmd.Parameters["@Docnum"].Value.ToString());

                var sqlQuery = "";

                foreach (DataGridViewRow item in data_gv.Rows)
                {
                    /// si es distinct de la ultima fila
                    if (item.Cells[0].RowIndex != data_gv.Rows.Count - 1)
                    {

                        sqlQuery = String.Format("Exec Pr_FacDetailsAdd   @Docentry = {0},  @Concep = '{1}',@quantity = {2}, @Price = {3} ",
                            docentrys,
                            item.Cells["colConcept"].Value.ToString(),
                            item.Cells["colQty_"].Value.ToString(),
                            item.Cells["colPric"].Value.ToString());


                        Compartidos.Bd_Context.Fun_ejecutarScript(sqlQuery, false);
                    }
                }

                /// Guardar los cambio si todo sale bien
                Bd_Context.procCommitTran();

                this.Menssage = "Medico Creado / Actualizado";
                lblMensaje.ForeColor = System.Drawing.Color.Black;
                this.ColorError = false;

                newDoc();



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

        /// <summary>
        /// muestra los pacientes
        /// </summary>
        public void proRefreshDgv()
        {
            string scrip = "exec Pr_FActGetAll";
            dataFac.DataSource = Compartidos.Bd_Context.Fun_ejecutarScript(scrip, false);
        }

        public bool validationData()
        {
            bool success = true; ;



            try
            {
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtMedi.Text))
                {
                    success = false;
                    this.Menssage = "Complete los campos ";
                    this.lblMensaje.Text = Menssage.ToString();
                }


                foreach (DataGridViewRow fila in data_gv.Rows)
                {
                    fila.Cells["colConcept"].Value = (fila.Cells["colConcept"].Value == null || fila.Cells["colConcept"].Value.ToString() == "") ? "Consulta" : fila.Cells["colConcept"].Value;
                    fila.Cells["colQty_"].Value = (fila.Cells["colQty_"].Value == null) ? "1" : fila.Cells["colQty_"].Value;
                    fila.Cells["colPric"].Value = (fila.Cells["colPric"].Value == null) ? "1000" : fila.Cells["colPric"].Value;
                }



            }
            catch (Exception)
            {

              
            }
         


            return success;
        }




        private void data_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PicCreateUser_Click(object sender, EventArgs e)
        {
            if (validationData())
                InsertFac(txtDocnum.Text, txtId.Text, txtMedi.Text, Frm_Lgin.id_User.ToString(), txtNote.Text, dateTimePicker1.Text);
        }

        private void FrmFact_Load(object sender, EventArgs e)
        {
            proRefreshDgv();
        }

        public void newDoc()
        {
            C_Utility.FunClearControls(this);
            data_gv.Rows.Clear();


            proRefreshDgv();
            dateTimePicker1.Text = DateTime.Now.ToString();

            id_medicals = 0;
            id_patients = 0;
            lblTotal.Text = "00.00";
        }

        private void PicNewPromo_Click(object sender, EventArgs e)
        {
            newDoc();


        }


        public void EditFac(string quertys)
        {

            // limpia los controels 
            Compartidos.C_Utility.FunClearControls(this);



            // creando el query para consultar 
            DataTable dt = Compartidos.Bd_Context.Fun_ejecutarScript(quertys);
            data_gv.Rows.Clear();

            /// asigancio de datos a controles
            /// 
            txtMedi.Text = dt.Rows[0]["NameMedico"].ToString();
            txtDocnum.Text = dt.Rows[0]["Docentry"].ToString();
            txtId.Text = dt.Rows[0]["namePatient"].ToString();
            txtNote.Text = dt.Rows[0]["Note"].ToString();
            dateTimePicker1.Text = dt.Rows[0]["Docdate"].ToString();

            id_patients = int.Parse(dt.Rows[0]["Id_Pacient"].ToString());
            id_medicals = int.Parse(dt.Rows[0]["Id_Medico"].ToString());

            foreach (DataRow item in dt.Rows)
                data_gv.Rows.Add(item["Concept"],
                                 item["quantity"],
                                 item["Price"]);



            Fun_ComputePrice();



        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataFac.Rows.Count >= 1)
                {
                    string sqlQuery = string.Format("Pr_FacGetDataByDocentry {0} ",
                    dataFac.CurrentRow.Cells["Docentry"].Value.ToString());
                    EditFac(sqlQuery);

                }
            }
            catch (Exception)
            {

           
            }
          
        }

        private void pic_buscar_promo_Click(object sender, EventArgs e)
        {
            obj = (PictureBox)sender;

            frmPartner = new FrmAudit();

            frmPartner.label1.Text = "Seleccion";
            frmPartner.BtnVer.Text = "Seleccionar";

            frmPartner.query = String.Format("EXEC	[Pr_PartnerShow] 		@IsMedical = {0}", obj.Tag.ToString());
            frmPartner.BtnVer.Click += BtnVer_Click;
            frmPartner.ShowDialog();


        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (frmPartner.dgvAuditoria.Rows.Count >= 1)
            {

                if (obj.Tag.ToString() == "0") // paciente
                {
                    txtId.Text = frmPartner.dgvAuditoria.CurrentRow.Cells["Name"].Value.ToString();
                    id_patients = int.Parse(frmPartner.dgvAuditoria.CurrentRow.Cells["Id"].Value.ToString());

                }
                else
                {
                    txtMedi.Text = frmPartner.dgvAuditoria.CurrentRow.Cells["Name"].Value.ToString();
                    id_medicals = int.Parse(frmPartner.dgvAuditoria.CurrentRow.Cells["Id"].Value.ToString());
                }
            }

            frmPartner.Close();
        }

        private void picLog_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtDocnum.Text.Trim()))
                {
                    frmAudit = new FrmAudit();
                    {
                        frmAudit.query = string.Format("EXEC	[Pr_FacGetDataAuditAll]		@Docentry ='{0}' ", txtDocnum.Text.Trim());
                        frmAudit.BtnVer.Click += BtnVer_Click1;
                        frmAudit.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Debe editar facturas  para mostrar");

            }
            catch (Exception)
            {

             
            }

           
        }

        private void BtnVer_Click1(object sender, EventArgs e)
        {
            if (frmAudit.dgvAuditoria.Rows.Count >= 1)
            {


                string sqlQuery = string.Format("Pr_FacGetDataAuditByDocentry {0} ",
                frmAudit.dgvAuditoria.CurrentRow.Cells["Intenal_Id"].Value.ToString());
                EditFac(sqlQuery);
                frmAudit.Close();

            }
        }

        private void data_gv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            Fun_ComputePrice();

        }

        /// <summary>
        /// Calcula el precio de qty * precio y lo muestra en label
        /// </summary>
        public void Fun_ComputePrice()
        {
            decimal
                   Total = 0,
                   Calc = 0,
                   Qty = 0,
                   Price = 0;
            try
            {
                foreach (DataGridViewRow item in data_gv.Rows)
                {
                    // Si no es null o vacio procede
                    if (item.Cells[1].Value != null && !string.IsNullOrEmpty(item.Cells[1].Value.ToString()))
                    {

                        if (item.Cells[2].Value != null && !string.IsNullOrEmpty(item.Cells[2].Value.ToString()))
                        {
                            Qty = item.Cells["colQty_"].Value.ToDecObj(1);
                            Price = item.Cells["colPric"].Value.ToDecObj(1);
                            Calc = Qty * Price;

                            item.Cells["colTotal"].Value = Calc;
                            Total += Calc;

                        }

                    }
                }
            }
            catch { }

            lblTotal.Text = Total.ToString("00.00");
        }



    }
}
