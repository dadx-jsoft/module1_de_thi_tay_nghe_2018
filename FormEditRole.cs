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
    public partial class FormEditRole : Form
    {
        private session1dbDataContext db = new session1dbDataContext();
        User userSelected;
        public FormEditRole()
        {
            InitializeComponent();
        }

        private void FormEditRole_Load(object sender, EventArgs e)
        {
            //load_cbo();
            userSelected = (User)this.Tag;
            cboOffice.Text = userSelected.Office.Title;
            txtEmail.Text = userSelected.Email;
            txtFirstName.Text = userSelected.FirstName;
            txtLastName.Text = userSelected.LastName;
            if(userSelected.RoleID == 1)
            {
                radAdmin.Checked = true;
            }
            else
            {
                radUser.Checked = true;
            }
        }
        private void load_cbo()
        {
            var offices = db.Offices.Select(o => o);

            cboOffice.DataSource = offices;
            cboOffice.DisplayMember = "Title";
            cboOffice.ValueMember = "ID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var user = db.Users.SingleOrDefault(u => u.Email == txtEmail.Text);

            if(radAdmin.Checked == true)
            {
                user.RoleID = 1;
            }
            else
            {
                user.RoleID = 2;
            }

            db.SubmitChanges();
            MessageBox.Show("Thành công");
        }
    }
}
