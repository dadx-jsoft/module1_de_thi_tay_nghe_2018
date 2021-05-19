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
    public partial class FormErrorLogout : Form
    {
        private session1dbDataContext db = new session1dbDataContext();
        History h_temp;
        public FormErrorLogout()
        {
            InitializeComponent();
        }

        private void FormErrorLogout_Load(object sender, EventArgs e)
        {
            hienThiLoi();
        }

        private void hienThiLoi()
        {
            History history= (History)this.Tag;
            h_temp = history;
            label1.Text = "No logout detected for your last login on " + history.LoginTime.Day + "/" + history.LoginTime.Month + "/" + history.LoginTime.Year + " at " + history.LoginTime.Hour + ":" + history.LoginTime.Minute;
            txtReason.Text = history.Reason;
            if(history.TypeError == 1)
            {
                radioButton1.Checked = true;
            }
            else 
            {
                radioButton2.Checked = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
