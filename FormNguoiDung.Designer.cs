
namespace Module1_2018_DuongXuanDa
{
    partial class FormNguoiDung
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChaoUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.lblSoLanCrash = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblChaoUser
            // 
            this.lblChaoUser.AutoSize = true;
            this.lblChaoUser.Location = new System.Drawing.Point(31, 32);
            this.lblChaoUser.Name = "lblChaoUser";
            this.lblChaoUser.Size = new System.Drawing.Size(252, 17);
            this.lblChaoUser.TabIndex = 1;
            this.lblChaoUser.Text = "Hi Henri, Welcome to AMONIC Airlines.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian trên hệ thống:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lần crash:";
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Location = new System.Drawing.Point(269, 70);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(84, 17);
            this.lblTimeSpent.TabIndex = 2;
            this.lblTimeSpent.Text = "[hh: mm: ss]";
            // 
            // lblSoLanCrash
            // 
            this.lblSoLanCrash.AutoSize = true;
            this.lblSoLanCrash.Location = new System.Drawing.Point(680, 70);
            this.lblSoLanCrash.Name = "lblSoLanCrash";
            this.lblSoLanCrash.Size = new System.Drawing.Size(24, 17);
            this.lblSoLanCrash.TabIndex = 2;
            this.lblSoLanCrash.Text = "[n]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.LoginTime,
            this.LogoutTime,
            this.TimeSpent,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(34, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 260);
            this.dataGridView1.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // LoginTime
            // 
            this.LoginTime.HeaderText = "Login Time";
            this.LoginTime.MinimumWidth = 6;
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.Width = 125;
            // 
            // LogoutTime
            // 
            this.LogoutTime.HeaderText = "Logout Time";
            this.LogoutTime.MinimumWidth = 6;
            this.LogoutTime.Name = "LogoutTime";
            this.LogoutTime.Width = 125;
            // 
            // TimeSpent
            // 
            this.TimeSpent.HeaderText = "Time spent on System";
            this.TimeSpent.MinimumWidth = 6;
            this.TimeSpent.Name = "TimeSpent";
            this.TimeSpent.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Unsuccessful logout reason";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTimeSpent);
            this.Controls.Add(this.lblSoLanCrash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChaoUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNguoiDung";
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNguoiDung_FormClosing);
            this.Load += new System.EventHandler(this.FormNguoiDung_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblChaoUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.Label lblSoLanCrash;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}