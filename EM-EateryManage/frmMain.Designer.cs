namespace EM_EateryManage
{
    partial class frmMain
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panelOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Wheat;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.btnSetting);
            this.guna2Panel2.Controls.Add(this.btnTable);
            this.guna2Panel2.Controls.Add(this.btnOrder);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 673);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "EM";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eatery Manage";
            // 
            // btnSetting
            // 
            this.btnSetting.BorderRadius = 24;
            this.btnSetting.BorderThickness = 2;
            this.btnSetting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Location = new System.Drawing.Point(3, 302);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(194, 82);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "Tùy Chỉnh";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnTable
            // 
            this.btnTable.BorderRadius = 24;
            this.btnTable.BorderThickness = 2;
            this.btnTable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnTable.ForeColor = System.Drawing.Color.Black;
            this.btnTable.Location = new System.Drawing.Point(3, 214);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(194, 82);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "Quản Lý Bàn";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BorderRadius = 24;
            this.btnOrder.BorderThickness = 2;
            this.btnOrder.Checked = true;
            this.btnOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(3, 126);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(194, 82);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Đặt Món";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panelOrder
            // 
            this.panelOrder.BorderThickness = 1;
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrder.Location = new System.Drawing.Point(200, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1062, 641);
            this.panelOrder.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblClock);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Location = new System.Drawing.Point(200, 639);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1062, 34);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(900, 5);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(56, 25);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "Time";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.guna2Panel2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eatery ManageMent";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panelOrder;
        private Guna.UI2.WinForms.Guna2Button btnTable;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.Timer timerClock;
    }
}