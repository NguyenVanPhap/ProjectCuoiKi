namespace Nhom11_DoAnQuanLySinhVien
{
    partial class frmTest
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
            this.btnLayKhoa_Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLayKhoa_Test
            // 
            this.btnLayKhoa_Test.Location = new System.Drawing.Point(61, 55);
            this.btnLayKhoa_Test.Name = "btnLayKhoa_Test";
            this.btnLayKhoa_Test.Size = new System.Drawing.Size(131, 53);
            this.btnLayKhoa_Test.TabIndex = 0;
            this.btnLayKhoa_Test.Text = "LayKhoa";
            this.btnLayKhoa_Test.UseVisualStyleBackColor = true;
            this.btnLayKhoa_Test.Click += new System.EventHandler(this.btnLayKhoa_Test_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLayKhoa_Test);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLayKhoa_Test;
    }
}