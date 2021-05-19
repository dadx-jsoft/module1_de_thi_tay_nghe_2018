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
    public partial class FormAddUser : Form
    {
        MD5 md = MD5.Create();
        StringBuilder passMD5 = new StringBuilder();
        private session1dbDataContext db = new session1dbDataContext();
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!");
            }
            else
            {
                if (checkDate())
                {
                    DialogResult a = MessageBox.Show("Bạn có chắc muốn add User này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        themUser();
                    }
                }
                else
                {
                    MessageBox.Show("Ngày sinh nhật không hợp lệ! ");
                }
            }
        }

        private void themUser()
        {
            User addUser = new User();
            md5_create(txtPassword.Text);

            //addUser.ID = null;
            addUser.LastName = txtLastName.Text;
            addUser.FirstName = txtFirstName.Text;
            addUser.Birthdate = dateTimePicker1.Value;
            addUser.Active = true;
            addUser.Email = txtEmail.Text;
            addUser.OfficeID = int.Parse(cboOffice.SelectedValue.ToString());
            addUser.RoleID = 2;
            addUser.Password = txtPassword.Text;
            db.Users.InsertOnSubmit(addUser);

            db.SubmitChanges();

            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            cboOffice.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void md5_create(string pass)
        {
            byte[] inputStr = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = md.ComputeHash(inputStr);

            for (int i = 0; i < hash.Length; i++)
            {
                passMD5.Append(hash[i].ToString("X2"));
            }
        }

        private bool checkDate()
        {
            int t1 = dateTimePicker1.Value.Year;
            int t2 = DateTime.Now.Year;
            int check = t2 - t1;
            return check <= 0 ? false : true;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            load_cbo();
        }

        private void load_cbo()
        {
            var offices = db.Offices.Select(o => o);

            cboOffice.DataSource = offices;
            cboOffice.DisplayMember = "Title";
            cboOffice.ValueMember = "ID";
        }
    }
}
