namespace Nhom11_DoAnQuanLySinhVien
{
    partial class ReportDanhSachKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDanhSachKhoa));
            this.KHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvDSK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlTittlebar = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.KHOABindingSource)).BeginInit();
            this.pnlTittlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // KHOABindingSource
            // 
            this.KHOABindingSource.DataMember = "KHOA";
            // 
            // BangDiem
            // 
            // 
            // rpvDSK
            // 
            reportDataSource1.Name = "DataSetKhoa";
            reportDataSource1.Value = this.KHOABindingSource;
            this.rpvDSK.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDSK.LocalReport.ReportEmbeddedResource = "Nhom11_DoAnQuanLySinhVien.ReportDanhSachKhoa.rdlc";
            this.rpvDSK.Location = new System.Drawing.Point(0, 50);
            this.rpvDSK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvDSK.Name = "rpvDSK";
            this.rpvDSK.ServerReport.BearerToken = null;
            this.rpvDSK.Size = new System.Drawing.Size(986, 696);
            this.rpvDSK.TabIndex = 0;
            // 
            // pnlTittlebar
            // 
            this.pnlTittlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlTittlebar.Controls.Add(this.btnexit);
            this.pnlTittlebar.Location = new System.Drawing.Point(0, -1);
            this.pnlTittlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTittlebar.Name = "pnlTittlebar";
            this.pnlTittlebar.Size = new System.Drawing.Size(987, 53);
            this.pnlTittlebar.TabIndex = 4;
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
            this.btnexit.Location = new System.Drawing.Point(935, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(40, 39);
            this.btnexit.TabIndex = 1;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(871, 102);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 64);
            this.btnTimKiem.TabIndex = 54;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.BackColor = System.Drawing.Color.White;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(600, 118);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(89, 22);
            this.lblKhoa.TabIndex = 52;
            this.lblKhoa.Text = "Mã Khoa:";
            // 
            // KHOATableAdapter
            // 
            
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Items.AddRange(new object[] {
            "ALL"});
            this.cbbMaKhoa.Location = new System.Drawing.Point(699, 114);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(148, 30);
            this.cbbMaKhoa.TabIndex = 55;
            // 
            // ReportDanhSachKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 745);
            this.Controls.Add(this.cbbMaKhoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.pnlTittlebar);
            this.Controls.Add(this.rpvDSK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportDanhSachKhoa";
            this.Text = "ReportDanhSachKhoa";
            this.Load += new System.EventHandler(this.ReportDanhSachKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KHOABindingSource)).EndInit();
            this.pnlTittlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDSK;
        private System.Windows.Forms.Panel pnlTittlebar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.BindingSource KHOABindingSource;

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
    }
}