namespace MedicalManagement.Modulos.Patient
{
    partial class Frm_Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Patient));
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.dTPickerFchNac = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastN = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.PicNewPromo = new System.Windows.Forms.PictureBox();
            this.PicCreateUser = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLog = new System.Windows.Forms.PictureBox();
            this.lblSegMed = new System.Windows.Forms.Label();
            this.txtSegMed = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.data_gv_showitem = new System.Windows.Forms.DataGridView();
            this.Id_Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medical_Record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCreateUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_showitem)).BeginInit();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Location = new System.Drawing.Point(727, 8);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(0, 662);
            // 
            // PicBack
            // 
            this.PicBack.Location = new System.Drawing.Point(12, 8);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Enabled = true;
            this.ExportToExcel.Location = new System.Drawing.Point(745, 608);
            this.ExportToExcel.Visible = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(219, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(219, 104);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(158, 22);
            this.txtDni.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(219, 133);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(158, 22);
            this.TxtName.TabIndex = 3;
            // 
            // txtLastN
            // 
            this.txtLastN.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastN.Location = new System.Drawing.Point(219, 161);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(158, 22);
            this.txtLastN.TabIndex = 4;
            // 
            // dTPickerFchNac
            // 
            this.dTPickerFchNac.CausesValidation = false;
            this.dTPickerFchNac.CustomFormat = "yyyy-MM-dd";
            this.dTPickerFchNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerFchNac.Location = new System.Drawing.Point(219, 256);
            this.dTPickerFchNac.Name = "dTPickerFchNac";
            this.dTPickerFchNac.Size = new System.Drawing.Size(158, 20);
            this.dTPickerFchNac.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(219, 223);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(219, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtRecord
            // 
            this.txtRecord.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecord.Location = new System.Drawing.Point(398, 73);
            this.txtRecord.Multiline = true;
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(336, 245);
            this.txtRecord.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(43, 73);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 19);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Codigo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(43, 103);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(58, 19);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "Cedula";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(43, 226);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 19);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Telefono";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 132);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 19);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(43, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 19);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblLastN
            // 
            this.lblLastN.AutoSize = true;
            this.lblLastN.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastN.Location = new System.Drawing.Point(43, 163);
            this.lblLastN.Name = "lblLastN";
            this.lblLastN.Size = new System.Drawing.Size(67, 19);
            this.lblLastN.TabIndex = 14;
            this.lblLastN.Text = "Apellido";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Bell MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRecord.Location = new System.Drawing.Point(627, 80);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(99, 14);
            this.lblRecord.TabIndex = 15;
            this.lblRecord.Text = "Historial Clinico";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(43, 259);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(159, 19);
            this.lblBirth.TabIndex = 16;
            this.lblBirth.Text = "Fecha de Nacimeinto";
            // 
            // PicNewPromo
            // 
            this.PicNewPromo.BackColor = System.Drawing.Color.Aquamarine;
            this.PicNewPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicNewPromo.Image = ((System.Drawing.Image)(resources.GetObject("PicNewPromo.Image")));
            this.PicNewPromo.Location = new System.Drawing.Point(101, 280);
            this.PicNewPromo.Name = "PicNewPromo";
            this.PicNewPromo.Size = new System.Drawing.Size(40, 39);
            this.PicNewPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicNewPromo.TabIndex = 123;
            this.PicNewPromo.TabStop = false;
            this.toolTip1.SetToolTip(this.PicNewPromo, "Nuevo pacientes");
            this.PicNewPromo.Click += new System.EventHandler(this.PicNewPromo_Click);
            // 
            // PicCreateUser
            // 
            this.PicCreateUser.BackColor = System.Drawing.Color.Aquamarine;
            this.PicCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("PicCreateUser.Image")));
            this.PicCreateUser.Location = new System.Drawing.Point(298, 284);
            this.PicCreateUser.Name = "PicCreateUser";
            this.PicCreateUser.Size = new System.Drawing.Size(41, 35);
            this.PicCreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCreateUser.TabIndex = 122;
            this.PicCreateUser.TabStop = false;
            this.toolTip1.SetToolTip(this.PicCreateUser, "Crear o \r\nActualizar");
            this.PicCreateUser.Click += new System.EventHandler(this.PicCreateUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picLog);
            this.groupBox1.Controls.Add(this.PicCreateUser);
            this.groupBox1.Controls.Add(this.PicNewPromo);
            this.groupBox1.Controls.Add(this.lblSegMed);
            this.groupBox1.Controls.Add(this.txtSegMed);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(25, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 327);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // picLog
            // 
            this.picLog.BackColor = System.Drawing.Color.Aquamarine;
            this.picLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLog.Image = ((System.Drawing.Image)(resources.GetObject("picLog.Image")));
            this.picLog.Location = new System.Drawing.Point(200, 281);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(39, 38);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLog.TabIndex = 124;
            this.picLog.TabStop = false;
            this.toolTip1.SetToolTip(this.picLog, "Log de modificaciones");
            this.picLog.Click += new System.EventHandler(this.PicLog_Click);
            // 
            // lblSegMed
            // 
            this.lblSegMed.AutoSize = true;
            this.lblSegMed.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegMed.Location = new System.Drawing.Point(18, 240);
            this.lblSegMed.Name = "lblSegMed";
            this.lblSegMed.Size = new System.Drawing.Size(117, 19);
            this.lblSegMed.TabIndex = 16;
            this.lblSegMed.Text = "Seguro Médico";
            // 
            // txtSegMed
            // 
            this.txtSegMed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegMed.Location = new System.Drawing.Point(194, 237);
            this.txtSegMed.Name = "txtSegMed";
            this.txtSegMed.Size = new System.Drawing.Size(158, 22);
            this.txtSegMed.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Location = new System.Drawing.Point(25, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 213);
            this.groupBox2.TabIndex = 159;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEdit.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(6, 46);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 23);
            this.BtnEdit.TabIndex = 165;
            this.BtnEdit.Text = "Editar";
            this.toolTip1.SetToolTip(this.BtnEdit, "Presione para editar");
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // data_gv_showitem
            // 
            this.data_gv_showitem.AllowUserToAddRows = false;
            this.data_gv_showitem.AllowUserToDeleteRows = false;
            this.data_gv_showitem.AllowUserToResizeRows = false;
            this.data_gv_showitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_gv_showitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_gv_showitem.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.data_gv_showitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv_showitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Patient,
            this.cedula,
            this.nombre,
            this.Email,
            this.Medical_Record});
            this.data_gv_showitem.Location = new System.Drawing.Point(160, 403);
            this.data_gv_showitem.Name = "data_gv_showitem";
            this.data_gv_showitem.ReadOnly = true;
            this.data_gv_showitem.RowHeadersVisible = false;
            this.data_gv_showitem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_gv_showitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_gv_showitem.Size = new System.Drawing.Size(574, 263);
            this.data_gv_showitem.TabIndex = 158;
            // 
            // Id_Patient
            // 
            this.Id_Patient.DataPropertyName = "Id_Patient";
            this.Id_Patient.HeaderText = "No. Paciente";
            this.Id_Patient.Name = "Id_Patient";
            this.Id_Patient.ReadOnly = true;
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula";
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Correo";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Medical_Record
            // 
            this.Medical_Record.DataPropertyName = "Medical_Record";
            this.Medical_Record.HeaderText = "Registro Med.";
            this.Medical_Record.Name = "Medical_Record";
            this.Medical_Record.ReadOnly = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Frm_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(801, 675);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.txtRecord);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtLastN);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLastN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dTPickerFchNac);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.data_gv_showitem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Patient";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Frm_Patient_Load);
            this.Controls.SetChildIndex(this.ExportToExcel, 0);
            this.Controls.SetChildIndex(this.PicBack, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.data_gv_showitem, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.dTPickerFchNac, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblLastN, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtLastN, 0);
            this.Controls.SetChildIndex(this.lblPhone, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            this.Controls.SetChildIndex(this.lblBirth, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.txtRecord, 0);
            this.Controls.SetChildIndex(this.lblRecord, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.picMainLogo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCreateUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_showitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.DateTimePicker dTPickerFchNac;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastN;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.PictureBox PicNewPromo;
        private System.Windows.Forms.PictureBox PicCreateUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.DataGridView data_gv_showitem;
        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medical_Record;
        private System.Windows.Forms.Label lblSegMed;
        private System.Windows.Forms.TextBox txtSegMed;
    }
}