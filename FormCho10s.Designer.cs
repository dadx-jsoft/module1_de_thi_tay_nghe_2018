
namespace Module1_2018_DuongXuanDa
{
    partial class FormCho10s
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
            this.components = new System.ComponentModel.Container();
            this.lblCho10s = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCho10s
            // 
            this.lblCho10s.AutoSize = true;
            this.lblCho10s.Location = new System.Drawing.Point(88, 82);
            this.lblCho10s.Name = "lblCho10s";
            this.lblCho10s.Size = new System.Drawing.Size(351, 17);
            this.lblCho10s.TabIndex = 0;
            this.lblCho10s.Text = "Đăng nhập thất bại vượt quá 3 lần, chờ 10s để tiếp tục";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCho10s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 183);
            this.ControlBox = false;
            this.Controls.Add(this.lblCho10s);
            this.Name = "FormCho10s";
            this.Text = "FormCho10s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCho10s;
        private System.Windows.Forms.Timer timer1;
    }
}