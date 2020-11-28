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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KETQUAHOCTAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BangDiem = new Nhom11_DoAnQuanLySinhVien.BangDiem();
            this.pnlTittlebar = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rpvBDCN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.KETQUAHOCTAPTableAdapter = new Nhom11_DoAnQuanLySinhVien.BangDiemTableAdapters.KETQUAHOCTAPTableAdapter();
            this.lblTBnam = new System.Windows.Forms.Label();
            this.btnSendtoALL = new System.Windows.Forms.Button();
            this.lblLoad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KETQUAHOCTAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiem)).BeginInit();
            this.pnlTittlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // KETQUAHOCTAPBindingSource
            // 
            this.KETQUAHOCTAPBindingSource.DataMember = "KETQUAHOCTAP";
            this.KETQUAHOCTAPBindingSource.DataSource = this.BangDiem;
            // 
            // BangDiem
            // 
            this.BangDiem.DataSetName = "BangDiem";
            this.BangDiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlTittlebar
            // 
            this.pnlTittlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlTittlebar.Controls.Add(this.btnexit);
            this.pnlTittlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTittlebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTittlebar.Name = "pnlTittlebar";
            this.pnlTittlebar.Size = new System.Drawing.Size(861, 45);
            this.pnlTittlebar.TabIndex = 2;
            this.pnlTittlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTittlebar_Paint);
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
            this.btnexit.Location = new System.Drawing.Point(818, 6);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(30, 32);
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
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbbNamHoc.Location = new System.Drawing.Point(521, 100);
            this.cbbNamHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(92, 27);
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
            this.btnTimKiem.Location = new System.Drawing.Point(628, 94);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(40, 43);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rpvBDCN
            // 
            this.rpvBDCN.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KETQUAHOCTAPBindingSource;
            this.rpvBDCN.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBDCN.LocalReport.ReportEmbeddedResource = "Nhom11_DoAnQuanLySinhVien.ReportDiemCaNhan.rdlc";
            this.rpvBDCN.Location = new System.Drawing.Point(0, 41);
            this.rpvBDCN.Margin = new System.Windows.Forms.Padding(2);
            this.rpvBDCN.Name = "rpvBDCN";
            this.rpvBDCN.ServerReport.BearerToken = null;
            this.rpvBDCN.Size = new System.Drawing.Size(861, 603);
            this.rpvBDCN.TabIndex = 51;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(389, 101);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 26);
            this.txtMaSV.TabIndex = 52;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.BackColor = System.Drawing.Color.White;
            this.lblMaSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(385, 79);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(91, 19);
            this.lblMaSV.TabIndex = 53;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.BackColor = System.Drawing.Color.White;
            this.lblNamHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(517, 78);
            this.lblNamHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(69, 19);
            this.lblNamHoc.TabIndex = 54;
            this.lblNamHoc.Text = "Năm Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(450, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 55;
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.BackColor = System.Drawing.Color.White;
            this.lblTB.Location = new System.Drawing.Point(528, 133);
            this.lblTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(19, 13);
            this.lblTB.TabIndex = 56;
            this.lblTB.Text = "----";
            // 
            // KETQUAHOCTAPTableAdapter
            // 
            this.KETQUAHOCTAPTableAdapter.ClearBeforeFill = true;
            // 
            // lblTBnam
            // 
            this.lblTBnam.AutoSize = true;
            this.lblTBnam.BackColor = System.Drawing.Color.White;
            this.lblTBnam.Location = new System.Drawing.Point(336, 133);
            this.lblTBnam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTBnam.Name = "lblTBnam";
            this.lblTBnam.Size = new System.Drawing.Size(19, 13);
            this.lblTBnam.TabIndex = 57;
            this.lblTBnam.Text = "----";
            // 
            // btnSendtoALL
            // 
            this.btnSendtoALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSendtoALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendtoALL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendtoALL.ForeColor = System.Drawing.Color.White;
            this.btnSendtoALL.Location = new System.Drawing.Point(712, 97);
            this.btnSendtoALL.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendtoALL.Name = "btnSendtoALL";
            this.btnSendtoALL.Size = new System.Drawing.Size(113, 30);
            this.btnSendtoALL.TabIndex = 60;
            this.btnSendtoALL.Text = "Gửi Điểm";
            this.btnSendtoALL.UseVisualStyleBackColor = false;
            this.btnSendtoALL.Click += new System.EventHandler(this.btnSendtoALL_Click);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(362, 116);
            this.lblLoad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(0, 13);
            this.lblLoad.TabIndex = 61;
            // 
            // BangDiemCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 644);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.btnSendtoALL);
            this.Controls.Add(this.lblTBnam);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbNamHoc);
            this.Controls.Add(this.pnlTittlebar);
            this.Controls.Add(this.rpvBDCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BangDiemCaNhan";
            this.Text = "BangDiemCaNhan";
            this.Load += new System.EventHandler(this.BangDiemCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KETQUAHOCTAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiem)).EndInit();
            this.pnlTittlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTittlebar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cbbNamHoc;
        private System.Windows.Forms.Button btnTimKiem;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBDCN;
        private System.Windows.Forms.BindingSource KETQUAHOCTAPBindingSource;
        private BangDiem BangDiem;
        private BangDiemTableAdapters.KETQUAHOCTAPTableAdapter KETQUAHOCTAPTableAdapter;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblTBnam;
        private System.Windows.Forms.Button btnSendtoALL;
        private System.Windows.Forms.Label lblLoad;
    }
}