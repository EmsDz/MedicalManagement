namespace MedicalManagement.Modulos.Facturas
{
    partial class FrmFact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFact));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picFacturas = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMedi = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDocNun = new System.Windows.Forms.Label();
            this.txtDocnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFac = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.picLog = new System.Windows.Forms.PictureBox();
            this.PicCreateUser = new System.Windows.Forms.PictureBox();
            this.PicNewPromo = new System.Windows.Forms.PictureBox();
            this.data_gv = new System.Windows.Forms.DataGridView();
            this.colConcept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic_buscar_promo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Docentry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Pacient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFac)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_buscar_promo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Location = new System.Drawing.Point(351, 244);
            this.picMainLogo.Size = new System.Drawing.Size(59, 29);
            this.picMainLogo.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(0, 583);
            // 
            // PicBack
            // 
            this.PicBack.Location = new System.Drawing.Point(39, 12);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportToExcel.Location = new System.Drawing.Point(671, 529);
            // 
            // picFacturas
            // 
            this.picFacturas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picFacturas.BackColor = System.Drawing.Color.Transparent;
            this.picFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacturas.Image = ((System.Drawing.Image)(resources.GetObject("picFacturas.Image")));
            this.picFacturas.Location = new System.Drawing.Point(507, 79);
            this.picFacturas.Name = "picFacturas";
            this.picFacturas.Size = new System.Drawing.Size(93, 89);
            this.picFacturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFacturas.TabIndex = 116;
            this.picFacturas.TabStop = false;
            this.picFacturas.Tag = "6";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(59, 84);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(70, 19);
            this.lblId.TabIndex = 163;
            this.lblId.Text = "Paciente";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(173, 83);
            this.txtId.MaxLength = 0;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(207, 22);
            this.txtId.TabIndex = 2;
            // 
            // txtMedi
            // 
            this.txtMedi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedi.Location = new System.Drawing.Point(173, 115);
            this.txtMedi.MaxLength = 1;
            this.txtMedi.Name = "txtMedi";
            this.txtMedi.ReadOnly = true;
            this.txtMedi.Size = new System.Drawing.Size(207, 22);
            this.txtMedi.TabIndex = 3;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(59, 115);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(62, 19);
            this.lblDni.TabIndex = 164;
            this.lblDni.Text = "Medico";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(173, 151);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(207, 22);
            this.txtNote.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 168;
            this.label2.Text = "Nota";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 170;
            this.label3.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(558, 366);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 24);
            this.lblTotal.TabIndex = 171;
            this.lblTotal.Text = "$ 00.00";
            // 
            // lblDocNun
            // 
            this.lblDocNun.AutoSize = true;
            this.lblDocNun.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocNun.Location = new System.Drawing.Point(59, 56);
            this.lblDocNun.Name = "lblDocNun";
            this.lblDocNun.Size = new System.Drawing.Size(74, 19);
            this.lblDocNun.TabIndex = 173;
            this.lblDocNun.Text = "DocNum";
            // 
            // txtDocnum
            // 
            this.txtDocnum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocnum.Location = new System.Drawing.Point(173, 55);
            this.txtDocnum.MaxLength = 1;
            this.txtDocnum.Name = "txtDocnum";
            this.txtDocnum.ReadOnly = true;
            this.txtDocnum.Size = new System.Drawing.Size(207, 22);
            this.txtDocnum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 174;
            this.label1.Text = "Fecha";
            // 
            // dataFac
            // 
            this.dataFac.AllowUserToAddRows = false;
            this.dataFac.AllowUserToDeleteRows = false;
            this.dataFac.AllowUserToResizeRows = false;
            this.dataFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFac.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Docentry,
            this.Id_Pacient,
            this.Id_Medico,
            this.Id_user,
            this.Note,
            this.Docdate,
            this.CreateDate});
            this.dataFac.Location = new System.Drawing.Point(173, 422);
            this.dataFac.Name = "dataFac";
            this.dataFac.ReadOnly = true;
            this.dataFac.RowHeadersVisible = false;
            this.dataFac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataFac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFac.Size = new System.Drawing.Size(492, 157);
            this.dataFac.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(61, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 176;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Location = new System.Drawing.Point(53, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 126);
            this.groupBox2.TabIndex = 177;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEdit.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(6, 17);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 23);
            this.BtnEdit.TabIndex = 165;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // picLog
            // 
            this.picLog.BackColor = System.Drawing.Color.Aquamarine;
            this.picLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLog.Image = ((System.Drawing.Image)(resources.GetObject("picLog.Image")));
            this.picLog.Location = new System.Drawing.Point(205, 363);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(37, 34);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLog.TabIndex = 180;
            this.picLog.TabStop = false;
            this.toolTip1.SetToolTip(this.picLog, "Log de modificaciones");
            this.picLog.Click += new System.EventHandler(this.PicLog_Click);
            // 
            // PicCreateUser
            // 
            this.PicCreateUser.BackColor = System.Drawing.Color.Aquamarine;
            this.PicCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("PicCreateUser.Image")));
            this.PicCreateUser.Location = new System.Drawing.Point(343, 364);
            this.PicCreateUser.Name = "PicCreateUser";
            this.PicCreateUser.Size = new System.Drawing.Size(39, 31);
            this.PicCreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCreateUser.TabIndex = 178;
            this.PicCreateUser.TabStop = false;
            this.toolTip1.SetToolTip(this.PicCreateUser, "Crear o Actualizar");
            this.PicCreateUser.Click += new System.EventHandler(this.PicCreateUser_Click);
            // 
            // PicNewPromo
            // 
            this.PicNewPromo.BackColor = System.Drawing.Color.Aquamarine;
            this.PicNewPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicNewPromo.Image = ((System.Drawing.Image)(resources.GetObject("PicNewPromo.Image")));
            this.PicNewPromo.Location = new System.Drawing.Point(61, 363);
            this.PicNewPromo.Name = "PicNewPromo";
            this.PicNewPromo.Size = new System.Drawing.Size(38, 35);
            this.PicNewPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicNewPromo.TabIndex = 179;
            this.PicNewPromo.TabStop = false;
            this.toolTip1.SetToolTip(this.PicNewPromo, "Nuevo factura");
            this.PicNewPromo.Click += new System.EventHandler(this.PicNewPromo_Click);
            // 
            // data_gv
            // 
            this.data_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_gv.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.data_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConcept,
            this.colQty_,
            this.colPric,
            this.colTotal});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_gv.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_gv.Location = new System.Drawing.Point(63, 189);
            this.data_gv.Name = "data_gv";
            this.data_gv.RowHeadersVisible = false;
            this.data_gv.Size = new System.Drawing.Size(602, 158);
            this.data_gv.TabIndex = 6;
            this.data_gv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_gv_CellEndEdit);
            // 
            // colConcept
            // 
            this.colConcept.FillWeight = 36.16071F;
            this.colConcept.HeaderText = "Concepto";
            this.colConcept.Name = "colConcept";
            // 
            // colQty_
            // 
            this.colQty_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQty_.HeaderText = "Cantidad";
            this.colQty_.Name = "colQty_";
            this.colQty_.Width = 85;
            // 
            // colPric
            // 
            this.colPric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPric.FillWeight = 227.6786F;
            this.colPric.HeaderText = "Precio";
            this.colPric.Name = "colPric";
            this.colPric.Width = 85;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotal.FillWeight = 36.16071F;
            this.colTotal.HeaderText = "Importe";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 95;
            // 
            // pic_buscar_promo
            // 
            this.pic_buscar_promo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pic_buscar_promo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_buscar_promo.Image = ((System.Drawing.Image)(resources.GetObject("pic_buscar_promo.Image")));
            this.pic_buscar_promo.Location = new System.Drawing.Point(343, 86);
            this.pic_buscar_promo.Name = "pic_buscar_promo";
            this.pic_buscar_promo.Size = new System.Drawing.Size(34, 17);
            this.pic_buscar_promo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_buscar_promo.TabIndex = 181;
            this.pic_buscar_promo.TabStop = false;
            this.pic_buscar_promo.Tag = "0";
            this.pic_buscar_promo.Click += new System.EventHandler(this.Pic_buscar_promo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 182;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.Pic_buscar_promo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 183;
            this.label5.Text = "Lista Facturas";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Docentry
            // 
            this.Docentry.DataPropertyName = "Docentry";
            this.Docentry.HeaderText = "No. Registro";
            this.Docentry.Name = "Docentry";
            this.Docentry.ReadOnly = true;
            // 
            // Id_Pacient
            // 
            this.Id_Pacient.DataPropertyName = "Id_Pacient";
            this.Id_Pacient.HeaderText = "N. Paciente";
            this.Id_Pacient.Name = "Id_Pacient";
            this.Id_Pacient.ReadOnly = true;
            // 
            // Id_Medico
            // 
            this.Id_Medico.DataPropertyName = "Id_Medico";
            this.Id_Medico.HeaderText = "No. Medico";
            this.Id_Medico.Name = "Id_Medico";
            this.Id_Medico.ReadOnly = true;
            // 
            // Id_user
            // 
            this.Id_user.DataPropertyName = "Id_user";
            this.Id_user.HeaderText = "No. Usuario";
            this.Id_user.Name = "Id_user";
            this.Id_user.ReadOnly = true;
            this.Id_user.Visible = false;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Notas";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Docdate
            // 
            this.Docdate.DataPropertyName = "Docdate";
            this.Docdate.HeaderText = "Fecha";
            this.Docdate.Name = "Docdate";
            this.Docdate.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Fecha Reg.";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // FrmFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 596);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_buscar_promo);
            this.Controls.Add(this.data_gv);
            this.Controls.Add(this.picLog);
            this.Controls.Add(this.PicCreateUser);
            this.Controls.Add(this.PicNewPromo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDocNun);
            this.Controls.Add(this.txtDocnum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtMedi);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.picFacturas);
            this.Name = "FrmFact";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmFact_Load);
            this.Controls.SetChildIndex(this.ExportToExcel, 0);
            this.Controls.SetChildIndex(this.picFacturas, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.txtMedi, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.txtDocnum, 0);
            this.Controls.SetChildIndex(this.lblDocNun, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dataFac, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.PicNewPromo, 0);
            this.Controls.SetChildIndex(this.PicCreateUser, 0);
            this.Controls.SetChildIndex(this.picLog, 0);
            this.Controls.SetChildIndex(this.picMainLogo, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.PicBack, 0);
            this.Controls.SetChildIndex(this.data_gv, 0);
            this.Controls.SetChildIndex(this.pic_buscar_promo, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFac)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNewPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_buscar_promo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFacturas;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMedi;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDocNun;
        private System.Windows.Forms.TextBox txtDocnum;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataFac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.PictureBox PicCreateUser;
        private System.Windows.Forms.PictureBox PicNewPromo;
        private System.Windows.Forms.DataGridView data_gv;
        private System.Windows.Forms.PictureBox pic_buscar_promo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty_;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPric;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docentry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Pacient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}