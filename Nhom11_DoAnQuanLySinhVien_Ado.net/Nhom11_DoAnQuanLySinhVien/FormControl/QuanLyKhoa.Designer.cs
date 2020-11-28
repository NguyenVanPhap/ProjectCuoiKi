namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    partial class QuanLyKhoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.epvMaKhoa = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.grbLuaChon = new System.Windows.Forms.GroupBox();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblXoa = new System.Windows.Forms.Label();
            this.lblLuu = new System.Windows.Forms.Label();
            this.lblHuyBo = new System.Windows.Forms.Label();
            this.lblSua = new System.Windows.Forms.Label();
            this.lblThem = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epvMaKhoa)).BeginInit();
            this.grbLuaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.grbDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // epvMaKhoa
            // 
            this.epvMaKhoa.ContainerControl = this;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Location = new System.Drawing.Point(115, 83);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(137, 29);
            this.txtTenKhoa.TabIndex = 33;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(115, 35);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(106, 29);
            this.txtMaKhoa.TabIndex = 32;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Location = new System.Drawing.Point(4, 84);
            this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(84, 21);
            this.lblTenKhoa.TabIndex = 4;
            this.lblTenKhoa.Text = "Tên khoa:";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoa.Location = new System.Drawing.Point(4, 38);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(79, 21);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã khoa:";
            // 
            // grbLuaChon
            // 
            this.grbLuaChon.Controls.Add(this.txtTenKhoa);
            this.grbLuaChon.Controls.Add(this.txtMaKhoa);
            this.grbLuaChon.Controls.Add(this.lblTenKhoa);
            this.grbLuaChon.Controls.Add(this.lblMaKhoa);
            this.grbLuaChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbLuaChon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLuaChon.Location = new System.Drawing.Point(45, 112);
            this.grbLuaChon.Margin = new System.Windows.Forms.Padding(2);
            this.grbLuaChon.Name = "grbLuaChon";
            this.grbLuaChon.Padding = new System.Windows.Forms.Padding(2);
            this.grbLuaChon.Size = new System.Drawing.Size(264, 307);
            this.grbLuaChon.TabIndex = 51;
            this.grbLuaChon.TabStop = false;
            this.grbLuaChon.Text = "Lựa chọn";
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Width = 150;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Width = 150;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKhoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoa.EnableHeadersVisualStyles = false;
            this.dgvKhoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhoa.Location = new System.Drawing.Point(2, 24);
            this.dgvKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhoa.Name = "dgvKhoa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.Size = new System.Drawing.Size(377, 281);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgvKhoa);
            this.grbDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbDanhSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSach.Location = new System.Drawing.Point(323, 112);
            this.grbDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Padding = new System.Windows.Forms.Padding(2);
            this.grbDanhSach.Size = new System.Drawing.Size(381, 307);
            this.grbDanhSach.TabIndex = 52;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.ForeColor = System.Drawing.Color.Red;
            this.lblKhoa.Location = new System.Drawing.Point(356, 23);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(243, 32);
            this.lblKhoa.TabIndex = 50;
            this.lblKhoa.Text = "QUẢN LÝ KHOA";
            // 
            // lblXoa
            // 
            this.lblXoa.AutoSize = true;
            this.lblXoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXoa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXoa.Location = new System.Drawing.Point(852, 420);
            this.lblXoa.Name = "lblXoa";
            this.lblXoa.Size = new System.Drawing.Size(58, 26);
            this.lblXoa.TabIndex = 60;
            this.lblXoa.Text = " Xóa";
            // 
            // lblLuu
            // 
            this.lblLuu.AutoSize = true;
            this.lblLuu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLuu.Location = new System.Drawing.Point(855, 344);
            this.lblLuu.Name = "lblLuu";
            this.lblLuu.Size = new System.Drawing.Size(55, 26);
            this.lblLuu.TabIndex = 61;
            this.lblLuu.Text = "Lưu";
            // 
            // lblHuyBo
            // 
            this.lblHuyBo.AutoSize = true;
            this.lblHuyBo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuyBo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHuyBo.Location = new System.Drawing.Point(840, 265);
            this.lblHuyBo.Name = "lblHuyBo";
            this.lblHuyBo.Size = new System.Drawing.Size(87, 26);
            this.lblHuyBo.TabIndex = 62;
            this.lblHuyBo.Text = "Hủy bỏ";
            // 
            // lblSua
            // 
            this.lblSua.AutoSize = true;
            this.lblSua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSua.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSua.Location = new System.Drawing.Point(857, 188);
            this.lblSua.Name = "lblSua";
            this.lblSua.Size = new System.Drawing.Size(51, 26);
            this.lblSua.TabIndex = 63;
            this.lblSua.Text = "Sửa";
            // 
            // lblThem
            // 
            this.lblThem.AutoSize = true;
            this.lblThem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThem.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblThem.Location = new System.Drawing.Point(844, 111);
            this.lblThem.Name = "lblThem";
            this.lblThem.Size = new System.Drawing.Size(70, 26);
            this.lblThem.TabIndex = 64;
            this.lblThem.Text = "Thêm";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyBo.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_cancel;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(757, 244);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(72, 73);
            this.btnHuyBo.TabIndex = 58;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_delete;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(757, 398);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 73);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_save;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(757, 323);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 73);
            this.btnLuu.TabIndex = 57;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_update;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(757, 167);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 73);
            this.btnSua.TabIndex = 55;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::Nhom11_DoAnQuanLySinhVien.Properties.Resources.image_add;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(757, 90);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 73);
            this.btnThem.TabIndex = 56;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblXoa);
            this.Controls.Add(this.lblLuu);
            this.Controls.Add(this.lblHuyBo);
            this.Controls.Add(this.lblSua);
            this.Controls.Add(this.lblThem);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbLuaChon);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.lblKhoa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyKhoa";
            this.Size = new System.Drawing.Size(959, 514);
            this.Load += new System.EventHandler(this.QuanLyKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epvMaKhoa)).EndInit();
            this.grbLuaChon.ResumeLayout(false);
            this.grbLuaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.grbDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epvMaKhoa;
        private System.Windows.Forms.GroupBox grbLuaChon;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblXoa;
        private System.Windows.Forms.Label lblLuu;
        private System.Windows.Forms.Label lblHuyBo;
        private System.Windows.Forms.Label lblSua;
        private System.Windows.Forms.Label lblThem;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
