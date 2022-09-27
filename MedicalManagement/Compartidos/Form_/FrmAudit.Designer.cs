namespace MedicalManagement.Compartidos.Form_
{
    partial class FrmAudit
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
            this.BtnVer = new System.Windows.Forms.Button();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Location = new System.Drawing.Point(719, 12);
            this.picMainLogo.Size = new System.Drawing.Size(78, 48);
            // 
            // PicBack
            // 
            this.PicBack.Location = new System.Drawing.Point(557, 23);
            this.PicBack.Visible = false;
            // 
            // BtnVer
            // 
            this.BtnVer.Location = new System.Drawing.Point(37, 403);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(75, 23);
            this.BtnVer.TabIndex = 2;
            this.BtnVer.Text = "Visualizar";
            this.BtnVer.UseVisualStyleBackColor = true;
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AllowUserToAddRows = false;
            this.dgvAuditoria.AllowUserToDeleteRows = false;
            this.dgvAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvAuditoria.Location = new System.Drawing.Point(37, 80);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersVisible = false;
            this.dgvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditoria.Size = new System.Drawing.Size(760, 317);
            this.dgvAuditoria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Historial  Modificacion";
            // 
            // FrmAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAuditoria);
            this.Controls.Add(this.BtnVer);
            this.MinimizeBox = false;
            this.Name = "FrmAudit";
            this.Text = "FrmAudit";
            this.Load += new System.EventHandler(this.FrmAudit_Load);
            this.Controls.SetChildIndex(this.PicBack, 0);
            this.Controls.SetChildIndex(this.picMainLogo, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.BtnVer, 0);
            this.Controls.SetChildIndex(this.dgvAuditoria, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnVer;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvAuditoria;
    }
}