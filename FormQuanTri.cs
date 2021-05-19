using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1_2018_DuongXuanDa
{
    public partial class FormQuanTri : Form
    {
        private session1dbDataContext db = new session1dbDataContext();
        private User userSelected;
        private User userLogined;
        private string emailSelected;

        DateTime loginTime;
        DateTime logoutTime;
        public FormQuanTri()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                logoutTime = DateTime.Now;
                UpdateHistory();
                Application.Exit();
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userSelected = null;
            emailSelected = null;
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.ShowDialog();
        }

        private void FormQuanTri_Load(object sender, EventArgs e)
        {
            load_cbo();
            userLogined = (User)this.Tag;
            loginTime = DateTime.Now;
            CreateHistory(userLogined);
            List<User> listUsers = db.Users.Select(user => user).ToList();
            load_gridview(listUsers);
        }

        private void load_gridview(List<User> users)
        {
            dataGridView1.Rows.Clear();

            foreach (var item in users)
            {

                DataGridViewRow dongMoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dongMoi.DefaultCellStyle.BackColor = Color.White;

                if (item.Active == false)
                {
                    dongMoi.DefaultCellStyle.BackColor = Color.IndianRed;
                }else if(item.RoleID == 1)
                {
                    dongMoi.DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                
                dongMoi.Cells[0].Value = item.FirstName;
                dongMoi.Cells[1].Value = item.LastName;
                dongMoi.Cells[2].Value = DateTime.Now.Year - item.Birthdate.Value.Year;
                dongMoi.Cells[3].Value = item.Role.Title;
                dongMoi.Cells[4].Value = item.Email;
                dongMoi.Cells[5].Value = item.Office.Title;

                dataGridView1.Rows.Add(dongMoi);
            }
        }

        private void load_cbo()
        {
            var offices = db.Offices.Select(o => o);

            cboOffices.DataSource = offices;
            cboOffices.DisplayMember = "Title";
            cboOffices.ValueMember = "ID";
        }

        private void cboOffices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<User> users = db.Users.Where(user => user.OfficeID.Equals(int.Parse(cboOffices.SelectedValue.ToString()))).Select(user=>user).ToList();

            dataGridView1.Rows.Clear();

            load_gridview(users);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            emailSelected = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            userSelected = db.Users.SingleOrDefault(u => u.Email.Equals(emailSelected));

            if (userSelected.Email != userLogined.Email)
            {
                if (userSelected.Active == false)
                {
                    btnEnable.Text = "Unsuspend Account";
                }
                else
                {
                    btnEnable.Text = "Suspend Account";
                }
                btnEnable.Enabled = true;
                btnChangeRole.Enabled = true;
            }
            else
            {
                btnEnable.Enabled = false;
                btnChangeRole.Enabled = false;
            }
                
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (userSelected != null)
            {
                if (userSelected.Email != userLogined.Email)
                {

                    if (userSelected.Active == false)
                    {
                        userSelected.Active = true;
                        btnEnable.Text = "Suspend Account";
                    }
                    else if (userSelected.Active == true)
                    {
                        userSelected.Active = false;

                        btnEnable.Text = "Unsuspend Account";


                    }

                    db.SubmitChanges();
                    userSelected = null;
                    emailSelected = null;
                    List<User> users = db.Users.Select(user => user).ToList();
                    load_gridview(users);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 user");
            }
            
        }

        private void FormQuanTri_Activated(object sender, EventArgs e)
        {
            List<User> listUsers = db.Users.Select(user => user).ToList();
            load_gridview(listUsers);
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            if (userSelected != null)
            {
                FormEditRole formEditRole = new FormEditRole();
                formEditRole.Tag = userSelected;
                formEditRole.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn user");
            }
        }

        private void CreateHistory(User user)
        {
            History h = new History();
            h.UserID = user.ID;
            h.LoginTime = loginTime;
            h.LogoutTime = loginTime;
            h.Status = 1;
            h.Reason = "Đăng xuất không đúng cách";
            h.TypeError = 2; // lỗi phần mềm
            db.Histories.InsertOnSubmit(h);
            db.SubmitChanges();
        }

        private void UpdateHistory()
        {
            History h = db.Histories.SingleOrDefault(c => c.UserID == userLogined.ID && c.LoginTime == loginTime);

            h.LogoutTime = DateTime.Now;
            h.Status = 0;
            h.Reason = "";
            h.TypeError = null;

            db.SubmitChanges();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormQuanTri_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateHistory();
            Application.Exit();
        }
    }
}
