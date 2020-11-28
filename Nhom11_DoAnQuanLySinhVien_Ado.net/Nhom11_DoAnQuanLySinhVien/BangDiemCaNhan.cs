using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;
namespace Nhom11_DoAnQuanLySinhVien
{
    public partial class BangDiemCaNhan : Form
    {

        string Username = "nguyenvanphap013";
        string passwork = "@phap12345";
        string desEmail = "huynhtrongnghia1090@gmail.com";
        string subjectText = "Hello";

        string CCEmail = "nguyenvanphap013@gmail.com";
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        string smtptext = "smtp.gmail.com";
        string PortText = "587";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public BangDiemCaNhan()
        {
            InitializeComponent();
        }

        public void ChangelanguagetoEngLish()
        {
            lblMaSV.Text = "Student ID";
            lblNamHoc.Text = "Year";
            btnSendtoALL.Text = "Send Grades";
        }
        public void ChangeLanguageToVietNamese()
        {
            lblNamHoc.Text = "Năm Học";
            lblMaSV.Text = "Mã Sinh Viên";
            btnSendtoALL.Text = "Gửi điểm";
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_data()
        {
            if (txtMaSV.Text == "")
            {
                if (cbbNamHoc.Text == "ALL")
                    this.KETQUAHOCTAPTableAdapter.FillByALL(this.BangDiem.KETQUAHOCTAP);
                else
                    this.KETQUAHOCTAPTableAdapter.FillByNamHoc(this.BangDiem.KETQUAHOCTAP, int.Parse(cbbNamHoc.Text));

            }
            else
            {
                if (cbbNamHoc.Text == "ALL")
                {
                    this.KETQUAHOCTAPTableAdapter.FillByMSV(this.BangDiem.KETQUAHOCTAP, txtMaSV.Text);
                    lblTBnam.ResetText();
                }
                else
                {
                    this.KETQUAHOCTAPTableAdapter.FillByNamMSV(this.BangDiem.KETQUAHOCTAP, txtMaSV.Text, int.Parse(cbbNamHoc.Text));
                    double? TBNam = KETQUAHOCTAPTableAdapter.GetTBnam(txtMaSV.Text, int.Parse(cbbNamHoc.Text));
                    lblTBnam.Text = "Trung bình năm :" + Math.Round(Convert.ToDouble(TBNam), 2).ToString();


                }

                double? TB=this.KETQUAHOCTAPTableAdapter.GetTB(txtMaSV.Text);
                
               
                lblTB.Text="Trung bình tích lũy :"+ Math.Round(Convert.ToDouble(TB), 2).ToString();
                
            }



            this.rpvBDCN.RefreshReport();
        }
        private void BangDiemCaNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BangDiem.KETQUAHOCTAP' table. You can move, or remove it, as needed.
            load_data();
        }

       
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            load_data();
        }
        private void SendCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Your message has been sucessfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSendtoALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
                lblLoad.Text = "";
            }
        }


        private void Send()
        {
            login = new NetworkCredential(Username, passwork);

            BLDiemSinhVien dtDSV = new BLDiemSinhVien();
            List<string> dsmasv = dtDSV.LayMaSinhVien();
            try
            {
                for (int i = 0; i < dsmasv.Count(); i++)
                {
                    client = new SmtpClient(smtptext);
                    client.Port = Convert.ToInt32(PortText);
                    client.EnableSsl = true;
                    client.Credentials = login;
                    msg = new MailMessage
                    {
                        From = new MailAddress(Username + smtptext.Replace("smtp.", "@"), "Trường đại học Sư Phạm Kỹ Thuật TPHCM", Encoding.UTF8)
                    };

                    msg.Subject = subjectText;

                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.Priority = MailPriority.Normal;
                    msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    if (i == dsmasv.Count - 2)
                    {
                        client.SendCompleted += new SendCompletedEventHandler(SendCompleteCallback);
                        //btnSendtoALL.BackColor = SystemColors.ActiveCaption;
                    }
                    string userstate = "Sending...";
                    string msv = dsmasv[i];
                    try
                    {
                        int x = int.Parse(msv);
                        desEmail = msv + "@student.hcmute.edu.vn";
                    }
                    catch
                    {
                        desEmail = msv + "@gmail.com";

                    }
                    msg.Body = dtDSV.DiemCaNhan(dsmasv[i]);
                    msg.To.Add(new MailAddress(desEmail));
                    if (!string.IsNullOrEmpty(desEmail))
                        msg.To.Add(new MailAddress(CCEmail));
                    client.SendAsync(msg, userstate);
                }
            }
            catch
            {
                MessageBox.Show("Không gửi được");
            }

        }
        private void pnlTittlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTittlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSendtoALL_Click(object sender, EventArgs e)
        {
            btnSendtoALL.BackColor = Color.Red;
            lblLoad.Text = "Sending......";
            Send();
        }
    }
}
