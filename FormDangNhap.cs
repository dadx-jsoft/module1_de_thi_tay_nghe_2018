using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1_2018_DuongXuanDa
{
    public partial class FormDangNhap : Form
    {
        //MD5 md = MD5.Create();
        //StringBuilder passMD5 = new StringBuilder();
        private session1dbDataContext db = new session1dbDataContext();
        User userLogined;
        History h_temp = new History();

        private int countNotValid = 0;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                userLogined = db.Users.SingleOrDefault(
                u => u.Email.Equals(txtUname.Text) && u.Password.Equals(txtUpass.Text));

                if (userLogined != null)
                {

                    if (checkCrash())
                    {
                        FormErrorLogout fError = new FormErrorLogout();
                        fError.Tag = h_temp;
                        fError.ShowDialog();
                    }

                    if (userLogined.Role.ID == 1) //admin
                    {
                        FormQuanTri formQuanTri = new FormQuanTri();
                        formQuanTri.Tag = userLogined;
                        formQuanTri.Show();
                        this.Hide();
                    }
                    else if (userLogined.Role.ID == 2)
                    {
                        if (userLogined.Active == true)
                        {
                            FormNguoiDung formNguoiDung = new FormNguoiDung();
                            formNguoiDung.Tag = userLogined;
                            formNguoiDung.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản của bạn đã bị vô hiệu hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else
                {
                    if (countNotValid < 3)
                    {
                        countNotValid++;
                        MessageBox.Show("Sai mật khẩu hoặc tài khoản");
                    }
                    else
                    {
                        // Chờ 10s cho đến lần đăng nhập tiếp
                        //AutoClosingMessageBox.Show("Chờ 10s", "Thông báo", 10000);
                        FormCho10s formCho10S = new FormCho10s();
                        formCho10S.ShowDialog();

                        countNotValid = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập!" + ex.Message);
            }
        }

        private bool checkCrash()
        {
            var histories = from cr in db.Histories
                            where cr.UserID == userLogined.ID
                            select cr;

            if (histories.Count() > 0)
            {
                foreach (var item in histories)
                {
                    h_temp = item;
                };

                if (h_temp.Status == 1)
                    return true;
            }
            return false;
        }
    }
}
