namespace EM_EateryManage
{
    partial class frmCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbGTinhKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpkNgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnTichDiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtIDKH = new System.Windows.Forms.TextBox();
            this.lblIDKH = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.txtTimKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 592);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.cbbGTinhKH);
            this.panel2.Controls.Add(this.dtpkNgaySinhKH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.btnTichDiem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.txtEmailKH);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.txtIDKH);
            this.panel2.Controls.Add(this.lblIDKH);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.txtSDTKH);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 592);
            this.panel2.TabIndex = 0;
            // 
            // cbbGTinhKH
            // 
            this.cbbGTinhKH.BackColor = System.Drawing.Color.Transparent;
            this.cbbGTinhKH.BorderColor = System.Drawing.SystemColors.ControlText;
            this.cbbGTinhKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGTinhKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGTinhKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGTinhKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGTinhKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGTinhKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbGTinhKH.ItemHeight = 30;
            this.cbbGTinhKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không Xác Định"});
            this.cbbGTinhKH.Location = new System.Drawing.Point(185, 402);
            this.cbbGTinhKH.Name = "cbbGTinhKH";
            this.cbbGTinhKH.Size = new System.Drawing.Size(281, 36);
            this.cbbGTinhKH.TabIndex = 62;
            // 
            // dtpkNgaySinhKH
            // 
            this.dtpkNgaySinhKH.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgaySinhKH.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinhKH.Location = new System.Drawing.Point(185, 348);
            this.dtpkNgaySinhKH.Name = "dtpkNgaySinhKH";
            this.dtpkNgaySinhKH.Size = new System.Drawing.Size(281, 22);
            this.dtpkNgaySinhKH.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Giới Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Ngày Sinh";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(15, 453);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(250, 20);
            this.label28.TabIndex = 45;
            this.label28.Text = "-NOTE: Dấu (*) là bắt buộc  ";
            // 
            // btnTichDiem
            // 
            this.btnTichDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTichDiem.Location = new System.Drawing.Point(328, 515);
            this.btnTichDiem.Name = "btnTichDiem";
            this.btnTichDiem.Size = new System.Drawing.Size(126, 71);
            this.btnTichDiem.TabIndex = 56;
            this.btnTichDiem.Text = "Tích Điểm";
            this.btnTichDiem.UseVisualStyleBackColor = true;
            this.btnTichDiem.Click += new System.EventHandler(this.btnTichDiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(196, 515);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 71);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(64, 515);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 71);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(15, 186);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 20);
            this.label29.TabIndex = 46;
            this.label29.Text = "*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(15, 303);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 20);
            this.label30.TabIndex = 47;
            this.label30.Text = "*";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(185, 179);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(281, 27);
            this.txtTenKH.TabIndex = 48;
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailKH.Location = new System.Drawing.Point(185, 238);
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(281, 27);
            this.txtEmailKH.TabIndex = 49;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(37, 186);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 20);
            this.label31.TabIndex = 41;
            this.label31.Text = "Tên KH";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(37, 303);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 20);
            this.label32.TabIndex = 42;
            this.label32.Text = "SDT";
            // 
            // txtIDKH
            // 
            this.txtIDKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDKH.Enabled = false;
            this.txtIDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKH.Location = new System.Drawing.Point(185, 115);
            this.txtIDKH.Name = "txtIDKH";
            this.txtIDKH.ReadOnly = true;
            this.txtIDKH.Size = new System.Drawing.Size(281, 27);
            this.txtIDKH.TabIndex = 50;
            this.txtIDKH.Visible = false;
            // 
            // lblIDKH
            // 
            this.lblIDKH.AutoSize = true;
            this.lblIDKH.BackColor = System.Drawing.Color.Transparent;
            this.lblIDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDKH.Location = new System.Drawing.Point(37, 122);
            this.lblIDKH.Name = "lblIDKH";
            this.lblIDKH.Size = new System.Drawing.Size(34, 20);
            this.lblIDKH.TabIndex = 43;
            this.lblIDKH.Text = "ID:";
            this.lblIDKH.Visible = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(37, 245);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(56, 20);
            this.label36.TabIndex = 39;
            this.label36.Text = "Email";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel13.Controls.Add(this.label37);
            this.panel13.Controls.Add(this.txtTimKH);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(12, 12);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(457, 75);
            this.panel13.TabIndex = 55;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label37.Location = new System.Drawing.Point(20, 30);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(129, 20);
            this.label37.TabIndex = 17;
            this.label37.Text = "KH Muốn Tìm:";
            // 
            // txtTimKH
            // 
            this.txtTimKH.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTimKH.BorderColor = System.Drawing.Color.Gray;
            this.txtTimKH.BorderRadius = 20;
            this.txtTimKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKH.DefaultText = "";
            this.txtTimKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKH.Location = new System.Drawing.Point(173, 21);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.PasswordChar = '\0';
            this.txtTimKH.PlaceholderText = "";
            this.txtTimKH.SelectedText = "";
            this.txtTimKH.Size = new System.Drawing.Size(281, 41);
            this.txtTimKH.TabIndex = 10;
            this.txtTimKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(185, 296);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(281, 27);
            this.txtSDTKH.TabIndex = 53;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvKH);
            this.panel3.Location = new System.Drawing.Point(475, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 586);
            this.panel3.TabIndex = 0;
            // 
            // dgvKH
            // 
            this.dgvKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(3, 3);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(560, 583);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1044, 592);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Tài Khoản";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtIDKH;
        private System.Windows.Forms.Label lblIDKH;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label37;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinhKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGTinhKH;
        private System.Windows.Forms.Button btnTichDiem;
    }
}