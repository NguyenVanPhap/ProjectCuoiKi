namespace Nhom11_DoAnQuanLySinhVien
{
    partial class BangDiemCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDiemCaNhan));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnlTittlebar = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rpvBDCN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblTBnam = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.KetQuaHocTapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyDiemSinhVien = new Nhom11_DoAnQuanLySinhVien.QuanLyDiemSinhVien();
            this.KetQuaHocTapTableAdapter = new Nhom11_DoAnQuanLySinhVien.QuanLyDiemSinhVienTableAdapters.KetQuaHocTapTableAdapter();
            this.pnlTittlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaHocTapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyDiemSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTittlebar
            // 
            this.pnlTittlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlTittlebar.Controls.Add(this.btnexit);
            this.pnlTittlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTittlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTittlebar.Name = "pnlTittlebar";
            this.pnlTittlebar.Size = new System.Drawing.Size(1347, 55);
            this.pnlTittlebar.TabIndex = 2;
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
            this.btnexit.Location = new System.Drawing.Point(1298, 2);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(40, 39);
            this.btnexit.TabIndex = 1;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNamHoc.FormattingEnabled = true;
            this.cbbNamHoc.Items.AddRange(new object[] {
            "ALL",
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021"});
            this.cbbNamHoc.Location = new System.Drawing.Point(815, 127);
            this.cbbNamHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(121, 30);
            this.cbbNamHoc.TabIndex = 49;
            this.cbbNamHoc.Text = "ALL";
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
            this.btnTimKiem.Location = new System.Drawing.Point(957, 120);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(53, 53);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rpvBDCN
            // 
            this.rpvBDCN.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataSetbangDiem";
            reportDataSource2.Value = this.KetQuaHocTapBindingSource;
            this.rpvBDCN.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvBDCN.LocalReport.ReportEmbeddedResource = "Nhom11_DoAnQuanLySinhVien.ReportDiemCaNhan.rdlc";
            this.rpvBDCN.Location = new System.Drawing.Point(0, 59);
            this.rpvBDCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rpvBDCN.Name = "rpvBDCN";
            this.rpvBDCN.ServerReport.BearerToken = null;
            this.rpvBDCN.Size = new System.Drawing.Size(1347, 734);
            this.rpvBDCN.TabIndex = 51;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.BackColor = System.Drawing.Color.White;
            this.lblNamHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(809, 100);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(85, 22);
            this.lblNamHoc.TabIndex = 54;
            this.lblNamHoc.Text = "Năm Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(720, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 55;
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.BackColor = System.Drawing.Color.White;
            this.lblTB.Location = new System.Drawing.Point(824, 168);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(28, 17);
            this.lblTB.TabIndex = 56;
            this.lblTB.Text = "----";
            // 
            // lblTBnam
            // 
            this.lblTBnam.AutoSize = true;
            this.lblTBnam.BackColor = System.Drawing.Color.White;
            this.lblTBnam.Location = new System.Drawing.Point(568, 168);
            this.lblTBnam.Name = "lblTBnam";
            this.lblTBnam.Size = new System.Drawing.Size(28, 17);
            this.lblTBnam.TabIndex = 57;
            this.lblTBnam.Text = "----";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(603, 147);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(0, 17);
            this.lblLoad.TabIndex = 61;
            // 
            // KetQuaHocTapBindingSource
            // 
            this.KetQuaHocTapBindingSource.DataMember = "KetQuaHocTap";
            this.KetQuaHocTapBindingSource.DataSource = this.QuanLyDiemSinhVien;
            // 
            // QuanLyDiemSinhVien
            // 
            this.QuanLyDiemSinhVien.DataSetName = "QuanLyDiemSinhVien";
            this.QuanLyDiemSinhVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KetQuaHocTapTableAdapter
            // 
            this.KetQuaHocTapTableAdapter.ClearBeforeFill = true;
            // 
            // BangDiemCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 793);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.lblTBnam);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbNamHoc);
            this.Controls.Add(this.pnlTittlebar);
            this.Controls.Add(this.rpvBDCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BangDiemCaNhan";
            this.Text = "BangDiemCaNhan";
            this.Load += new System.EventHandler(this.BangDiemCaNhan_Load);
            this.pnlTittlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaHocTapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyDiemSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTittlebar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cbbNamHoc;
        private System.Windows.Forms.Button btnTimKiem;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBDCN;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblTBnam;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.BindingSource KetQuaHocTapBindingSource;
        private QuanLyDiemSinhVien QuanLyDiemSinhVien;
        private QuanLyDiemSinhVienTableAdapters.KetQuaHocTapTableAdapter KetQuaHocTapTableAdapter;
    }
}