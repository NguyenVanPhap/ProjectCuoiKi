namespace Nhom11_DoAnQuanLySinhVien
{
    partial class ReportDanhSachMon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDanhSachMon));
            this.MONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTittlebar = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.rpvDSM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbMaMon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MONBindingSource)).BeginInit();
            this.pnlTittlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MONBindingSource
            // 
            this.MONBindingSource.DataMember = "MON";
            // 
            // BangDiem
            // 
            // 
            // pnlTittlebar
            // 
            this.pnlTittlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlTittlebar.Controls.Add(this.btnexit);
            this.pnlTittlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTittlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTittlebar.Name = "pnlTittlebar";
            this.pnlTittlebar.Size = new System.Drawing.Size(952, 53);
            this.pnlTittlebar.TabIndex = 3;
            this.pnlTittlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTittlebar_MouseDown);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnexit.Location = new System.Drawing.Point(901, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(40, 39);
            this.btnexit.TabIndex = 1;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // rpvDSM
            // 
            reportDataSource1.Name = "DataSetMon";
            reportDataSource1.Value = this.MONBindingSource;
            this.rpvDSM.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDSM.LocalReport.ReportEmbeddedResource = "Nhom11_DoAnQuanLySinhVien.ReportDanhSachMon.rdlc";
            this.rpvDSM.Location = new System.Drawing.Point(0, 52);
            this.rpvDSM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvDSM.Name = "rpvDSM";
            this.rpvDSM.ServerReport.BearerToken = null;
            this.rpvDSM.Size = new System.Drawing.Size(951, 707);
            this.rpvDSM.TabIndex = 4;
            // 
            // MONTableAdapter
            // 
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.BackColor = System.Drawing.Color.White;
            this.lblMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.Location = new System.Drawing.Point(492, 124);
            this.lblMaMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(83, 22);
            this.lblMaMon.TabIndex = 5;
            this.lblMaMon.Text = "Mã Môn:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(768, 111);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 64);
            this.btnTimKiem.TabIndex = 51;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbMaMon
            // 
            this.cbbMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaMon.FormattingEnabled = true;
            this.cbbMaMon.Items.AddRange(new object[] {
            "ALL"});
            this.cbbMaMon.Location = new System.Drawing.Point(589, 121);
            this.cbbMaMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaMon.Name = "cbbMaMon";
            this.cbbMaMon.Size = new System.Drawing.Size(148, 30);
            this.cbbMaMon.TabIndex = 53;
            // 
            // ReportDanhSachMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 758);
            this.Controls.Add(this.cbbMaMon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.rpvDSM);
            this.Controls.Add(this.pnlTittlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportDanhSachMon";
            this.Text = "ReportDanhSachMon";
            this.Load += new System.EventHandler(this.ReportDanhSachMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MONBindingSource)).EndInit();
            this.pnlTittlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTittlebar;
        private System.Windows.Forms.Button btnexit;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDSM;
        private System.Windows.Forms.BindingSource MONBindingSource;
      private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbMaMon;
    }
}