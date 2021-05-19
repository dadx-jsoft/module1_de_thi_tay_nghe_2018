
namespace Module1_2018_DuongXuanDa
{
    partial class FormQuanTri
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
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOffices = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Office:";
            // 
            // cboOffices
            // 
            this.cboOffices.FormattingEnabled = true;
            this.cboOffices.Location = new System.Drawing.Point(80, 56);
            this.cboOffices.Name = "cboOffices";
            this.cboOffices.Size = new System.Drawing.Size(121, 24);
            this.cboOffices.TabIndex = 2;
            this.cboOffices.SelectionChangeCommitted += new System.EventHandler(this.cboOffices_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.LastName,
            this.Age,
            this.UserRole,
            this.EmailAddress,
            this.Office});
            this.dataGridView1.Location = new System.Drawing.Point(16, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 363);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // UserRole
            // 
            this.UserRole.HeaderText = "User Role";
            this.UserRole.MinimumWidth = 6;
            this.UserRole.Name = "UserRole";
            this.UserRole.Width = 125;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.MinimumWidth = 6;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 125;
            // 
            // Office
            // 
            this.Office.HeaderText = "Office";
            this.Office.MinimumWidth = 6;
            this.Office.Name = "Office";
            this.Office.Width = 125;
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.Location = new System.Drawing.Point(112, 525);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(75, 23);
            this.btnChangeRole.TabIndex = 4;
            this.btnChangeRole.Text = " Change Role";
            this.btnChangeRole.UseVisualStyleBackColor = true;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(295, 525);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(161, 23);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.Text = "Suspend Account";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // FormQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 621);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnChangeRole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboOffices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            //this.Name = "FormQuanTri";
            this.Text = "AMONIC Airlines Automation system";
            this.Activated += new System.EventHandler(this.FormQuanTri_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuanTri_FormClosing);
            this.Load += new System.EventHandler(this.FormQuanTri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOffices;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.Button btnEnable;
    }
}