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
    public partial class FormNguoiDung : Form
    {
        private session1dbDataContext db = new session1dbDataContext();
        private User userLogined;
        DateTime timeLogin;
        public FormNguoiDung()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                UpdateHistory();
                Application.Exit();
            }
        }

        private void CreateHistory(User user)
        {
            History history = new History();
            history.UserID = user.ID;
            history.LoginTime = timeLogin;
            history.LogoutTime = timeLogin;
            history.Status = 1;
            history.Reason = "Đăng xuất không đúng cách";
            history.TypeError = 2; // lỗi phần mềm
            db.Histories.InsertOnSubmit(history);
            db.SubmitChanges();
        }
        private void UpdateHistory()
        {
            History history = db.Histories.SingleOrDefault(h => h.UserID == userLogined.ID && h.LoginTime == timeLogin);

            history.LogoutTime = DateTime.Now;
            history.Status = 0;
            history.Reason = "";
            history.TypeError = null;

            db.SubmitChanges();
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            userLogined = ((User)this.Tag);
            try
            {
                hienThiDL();
            }
            catch (Exception ex)
            {
                History history = db.Histories.SingleOrDefault(h => h.UserID == userLogined.ID && h.LoginTime == timeLogin);
                history.Status = 1;
                history.Reason = ex.Message;
                if (ex.Message.Contains("System"))
                {
                    history.TypeError = 1; // Lỗi system
                }
                else
                {
                    history.TypeError = 2;
                }
                db.SubmitChanges();
            }
            timeLogin = DateTime.Now;
            CreateHistory(userLogined);
        }

        private void hienThiDL()
        {
            lblChaoUser.Text = "Hi " + userLogined.FirstName + " " + userLogined.LastName + ", Welcome to AMONIC Airlines.";

            int count = 0;

            DateTime setdate = Convert.ToDateTime("1/1/2012 12:00:00 AM");
            TimeSpan totalTime = setdate - setdate;
            TimeSpan checkTime = totalTime;        

            var histories = from h in db.Histories
                            where h.UserID == userLogined.ID
                            select h;

            foreach (var item in histories)
            {
                checkTime = DateTime.Now - item.LoginTime;

                if (checkTime.Days <= 30)
                {
                    DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    dongmoi.DefaultCellStyle.BackColor = Color.White;
                    dongmoi.Cells[0].Value = item.LoginTime.Month + "/" + item.LoginTime.Day + "/" + item.LoginTime.Year;
                    dongmoi.Cells[1].Value = item.LoginTime.Hour + ":" + item.LoginTime.Minute;

                    if (item.Reason != "")
                    {
                        count++;
                        dongmoi.DefaultCellStyle.BackColor = Color.OrangeRed;
                        dongmoi.Cells[2].Value = "**";

                        dongmoi.Cells[3].Value = "**";
                        dongmoi.Cells[4].Value = item.Reason;
                    }
                    else
                    {
                        DateTime time_spent = item.LoginTime;

                        DateTime time_spent2 = (DateTime)item.LogoutTime;
                        TimeSpan timeRows = time_spent2 - time_spent;
                        totalTime += timeRows;
                        dongmoi.Cells[2].Value = item.LogoutTime.Hour + ":" + item.LogoutTime.Minute;

                        dongmoi.Cells[3].Value = timeRows.Hours + "giờ :" + timeRows.Minutes + "phút :" + timeRows.Seconds + "giây";

                        dongmoi.Cells[4].Value = "";
                    }

                    dataGridView1.Rows.Add(dongmoi);
                }
                lblTimeSpent.Text = totalTime.Days + "ngày :" + totalTime.Hours + "giờ :" + totalTime.Minutes + "phút :" + totalTime.Seconds + "giây"; ;
                lblSoLanCrash.Text = "" + count;
            }
        }

        private void FormNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateHistory();
            Application.Exit();
        }
    }
}
