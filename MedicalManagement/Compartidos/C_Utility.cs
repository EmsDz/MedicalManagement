using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Compartidos
{
    public static class C_Utility
    {
        /// <summary>
        /// Recibe un formulario y devuelve la lista de controles que lo conforman
        /// </summary>
        /// <param name="Frm"></param>
        /// <returns></returns>
        private static List<Control> FunGetAllControl(Control Frm)
        {
            List<Control> controls = new List<Control>();
            foreach (Control item in Frm.Controls)
            {
                if (item is Panel)
                {
                    Panel Obj = (Panel)item;
                    foreach (Control Children in Obj.Controls)
                    {
                        controls.Add(Children);
                    }
                }
                // Tab control
                else if (item is TabControl)
                {
                    TabControl Obj = (TabControl)item;
                    foreach (Control TbpControl in Obj.Controls)
                    {
                        TabPage tabPage = (TabPage)TbpControl;
                        foreach (Control Childrend in tabPage.Controls)
                        {
                            controls.Add(Childrend);
                        }
                    }
                }
                else
                {
                    controls.Add(item);
                }
            }
            return controls;
        }

        internal static void Fun_ShowFrmMain(Frm_Root frm_Root)
        {
            Bd_Context.procCloseConex();
            Program.FrmMain.Show();
            frm_Root.Close();
        }

        /// <summary>
        /// Cierra la aplicacion si esta en true
        /// </summary>
        public static void Fun_ExitApp()
        {
            try
            {
                    Application.Exit();
                    Application.ExitThread();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Limpia los controles del formulario
        /// </summary>
        /// <param name="Frm">Control que contienes los controles para resetear </param>
        public static void FunClearControls(Control Frm, bool blocDocentry = true, bool DefaulValues = false)
        {
            foreach (Control item in FunGetAllControl(Frm))
            {
                if (item is TextBox)
                {
                    TextBox Obj = (TextBox)item;
                    Obj.Clear();

                    if (blocDocentry == true)
                    {
                        if (Obj.Tag != null && (Obj.Tag.ToString() == "Docentry" || Obj.Tag.ToString() == "Itemcode"))
                            Obj.Enabled = false;
                    }
                    else
                    {
                        if (Obj.Tag != null && (Obj.Tag.ToString() == "Docentry" || Obj.Tag.ToString() == "Itemcode"))
                            Obj.Enabled = true;

                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox Obj = (ComboBox)item;
                    Obj.SelectedIndex = -1;


                    /// DEfault values
                    /// 
                    if (DefaulValues)
                    {
                        if (Obj.Name == "CmbItemClasification" || Obj.Name == "CmbItemSeries")
                        {
                            if (Obj.Items.Count > 0)
                                Obj.SelectedIndex = 0;
                        }
                    }
                }
                else if (item is CheckBox)
                {
                    CheckBox Obj = (CheckBox)item;
                    Obj.Checked = false;


                    if (DefaulValues)
                    {
                        /// DEfault values
                        if (Obj.Name == "chkBuyItem" || Obj.Name == "chkIventItem" || Obj.Name == "chkSellItem" || Obj.Name == "ChkValidfor")
                            Obj.Checked = true;
                    }

                }
                else if (item is RadioButton)
                {
                    RadioButton Obj = (RadioButton)item;
                    Obj.Checked = false;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown Obj = (NumericUpDown)item;
                    Obj.Value = Obj.Minimum;
                }
                else if (item is PictureBox)
                {
                    //PictureBox Obj = (PictureBox)item;
                    //Obj.Image = null;// QuickPoint.Properties.Resources.camera_png;
                }
                else if (item is DataGridView)
                {
                    //DataGridView Obj = (DataGridView)item;
                    //Obj.Rows.Clear();


                    DataGridView Obj = (DataGridView)item;
                  
                }
            }
        }

        /// <summary>
        /// Asigna cada valor de la Base de datos al control adecuado
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="SqlComand"></param>
        public static void FunLoadDatesControl(Control frm, string SqlComand, DataTable Dt = null)
        {
            DataTable dt;

            if (Dt == null)
                dt = Bd_Context.Fun_ejecutarScript(SqlComand, true);           // Ejecutando el query
            else
                dt = Dt;

            //Obteniendo la lista de controles
            List<Control> ListControls = FunGetAllControl(frm);

            foreach (DataColumn item in dt.Columns)
            {
                foreach (DataRow filas in dt.Rows)
                {

                    var controls = from Control Ctrl in ListControls
                                   where Ctrl.Tag != null && Ctrl.Tag.ToString() == item.ToString()
                                   select Ctrl;

                    foreach (Control Contr in controls)
                    {
                        ///TextBox
                        if (Contr is TextBox)
                        {
                            Contr.Text = filas[item].ToString();
                        }
                        ///ComboBox
                        else if (Contr is ComboBox)
                        {
                            ComboBox Cmb = (ComboBox)Contr;
                            Cmb.SelectedIndex = int.Parse(filas[item].ToString());
                        }
                        //CheckBox
                        else if (Contr is CheckBox)
                        {
                            CheckBox Ck = (CheckBox)Contr;
                            Ck.Checked = bool.Parse(filas[item].ToString());
                        }
                        //RadioButton
                        else if (Contr is RadioButton)
                        {
                            RadioButton Rdo = (RadioButton)Contr;
                            Rdo.Checked = bool.Parse(filas[item].ToString());
                        }
                        //Imagen
                        else if (Contr is PictureBox)
                        {
                            PictureBox Pic = (PictureBox)Contr;
                            //Evitar error cuando la imagen sea null
                            if (filas[item] != null && filas[item].ToString() != "")
                            {
                                byte[] datos = new byte[0];
                                datos = (byte[])filas[item];
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                                Pic.Image = System.Drawing.Image.FromStream(ms);
                                Pic.Refresh();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// /Da un click personalizado en un botton
        /// </summary>
        /// <param name="Frm"></param>
        /// <param name="Tagcontrol"></param>
        public static void FunPerfomClick(Control Frm, string Tagcontrol)
        {
            var controls = from Control Ctrl in Frm.Controls
                           where Ctrl.Tag != null && Ctrl.Tag.ToString() == Tagcontrol
                           select Ctrl;

            foreach (Control Contr in controls)
            {
                ///Button
                if (Contr.GetType().Name.ToString().Equals("Button"))
                {
                    Button Btn = (Button)Contr;
                    Btn.PerformClick();
                }
            }
        }


        /// <summary>
        /// Remueve fila del Dgv
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="showMessaje"></param>
        public static void Fun_RemoveRowsSelect(DataGridView gridView, bool showMessaje = true)
        {
            if (showMessaje)
            {
                if (MessageBox.Show("Se Eliminaran ,Desea continuar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
            }

            foreach (DataGridViewRow fila in gridView.SelectedRows)
            {
                try
                {
                    gridView.Rows.RemoveAt(fila.Index);
                }
                catch //(Exception ex)
                {
                }
            }
        }

        /// <summary>
        /// /Anade una foto a un picture box
        /// </summary>
        /// <param name="picture"></param>
        public static void FunAddImgInPictureBx(PictureBox picture)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.FileName = "";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != null || openFileDialog.FileName.Equals("") == false)
                    picture.ImageLocation = openFileDialog.FileName;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
            }
        }

    }
}
