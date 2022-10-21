namespace MedicalManagement.Compartidos
{
    partial class Frm_Root
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Root));
            this.picMainLogo = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.ExportToExcel = new System.Windows.Forms.PictureBox();
            this.SaveExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMainLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("picMainLogo.Image")));
            this.picMainLogo.Location = new System.Drawing.Point(90, 95);
            this.picMainLogo.Name = "picMainLogo";
            this.picMainLogo.Size = new System.Drawing.Size(158, 90);
            this.picMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainLogo.TabIndex = 0;
            this.picMainLogo.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensaje.Location = new System.Drawing.Point(0, 437);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(10, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "-";
            // 
            // PicBack
            // 
            this.PicBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBack.Image = ((System.Drawing.Image)(resources.GetObject("PicBack.Image")));
            this.PicBack.Location = new System.Drawing.Point(135, 210);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(71, 30);
            this.PicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBack.TabIndex = 2;
            this.PicBack.TabStop = false;
            this.PicBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.BackColor = System.Drawing.Color.Aquamarine;
            this.ExportToExcel.Enabled = false;
            this.ExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcel.Image")));
            this.ExportToExcel.Location = new System.Drawing.Point(277, 12);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(50, 50);
            this.ExportToExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExportToExcel.TabIndex = 4;
            this.ExportToExcel.TabStop = false;
            this.ExportToExcel.Visible = false;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // Frm_Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.ExportToExcel);
            this.Controls.Add(this.PicBack);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.picMainLogo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frm_Root";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Root_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportToExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picMainLogo;
        public System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.PictureBox PicBack;
        public System.Windows.Forms.PictureBox ExportToExcel;
        private System.Windows.Forms.SaveFileDialog SaveExcel;
    }
}