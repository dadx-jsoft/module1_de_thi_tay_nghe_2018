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
    
    public partial class FormCho10s : Form
    {
        private int counter = 10;
        public FormCho10s()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            lblCho10s.Text = "Đăng nhập thất bại vượt quá 3 lần, chờ " + counter.ToString() + "s để tiếp tục";
            if (counter == 0)
                this.Close();
        }
    }
}
