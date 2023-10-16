namespace EM_EateryManage
{
    partial class frmADMIN
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTaiKhoan = new System.Windows.Forms.TabPage();
            this.tpThucAn = new System.Windows.Forms.TabPage();
            this.btnTimMon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAdd_TenMon = new System.Windows.Forms.TextBox();
            this.txtAdd_DanhMuc = new System.Windows.Forms.TextBox();
            this.txtAdd_Gia = new System.Windows.Forms.TextBox();
            this.txtAdd_LinkIMG = new System.Windows.Forms.TextBox();
            this.txtAdd_Loai = new System.Windows.Forms.TextBox();
            this.txtAdd_MoTa = new System.Windows.Forms.TextBox();
            this.tpDanhMuc = new System.Windows.Forms.TabPage();
            this.tpBanAn = new System.Windows.Forms.TabPage();
            this.tpDoanhThu = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDisplayBill = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayDi = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpkNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl1.SuspendLayout();
            this.tpThucAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpDoanhThu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTaiKhoan);
            this.tabControl1.Controls.Add(this.tpThucAn);
            this.tabControl1.Controls.Add(this.tpDanhMuc);
            this.tabControl1.Controls.Add(this.tpBanAn);
            this.tabControl1.Controls.Add(this.tpDoanhThu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTaiKhoan
            // 
            this.tpTaiKhoan.Location = new System.Drawing.Point(4, 29);
            this.tpTaiKhoan.Name = "tpTaiKhoan";
            this.tpTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaiKhoan.Size = new System.Drawing.Size(1054, 606);
            this.tpTaiKhoan.TabIndex = 0;
            this.tpTaiKhoan.Text = "Tài Khoản";
            this.tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tpThucAn
            // 
            this.tpThucAn.BackColor = System.Drawing.Color.RosyBrown;
            this.tpThucAn.Controls.Add(this.dgvDSMonAn);
            this.tpThucAn.Controls.Add(this.btnXoa);
            this.tpThucAn.Controls.Add(this.btnSua);
            this.tpThucAn.Controls.Add(this.btnThem);
            this.tpThucAn.Controls.Add(this.label7);
            this.tpThucAn.Controls.Add(this.label6);
            this.tpThucAn.Controls.Add(this.label5);
            this.tpThucAn.Controls.Add(this.label4);
            this.tpThucAn.Controls.Add(this.label3);
            this.tpThucAn.Controls.Add(this.label2);
            this.tpThucAn.Controls.Add(this.panel1);
            this.tpThucAn.Location = new System.Drawing.Point(4, 29);
            this.tpThucAn.Name = "tpThucAn";
            this.tpThucAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpThucAn.Size = new System.Drawing.Size(1054, 606);
            this.tpThucAn.TabIndex = 1;
            this.tpThucAn.Text = "Thức Ăn";
            // 
            // btnTimMon
            // 
            this.btnTimMon.Location = new System.Drawing.Point(330, 9);
            this.btnTimMon.Name = "btnTimMon";
            this.btnTimMon.Size = new System.Drawing.Size(148, 41);
            this.btnTimMon.TabIndex = 5;
            this.btnTimMon.Text = "Tìm Món";
            this.btnTimMon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(302, 506);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 71);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa Món";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(170, 506);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 71);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa Món";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 506);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 71);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm Món";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(7, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mô Tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(7, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại Đồ Ăn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(7, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Link Hình Ảnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(7, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh Mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Món:";
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDSMonAn.Location = new System.Drawing.Point(487, 3);
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.RowHeadersVisible = false;
            this.dgvDSMonAn.RowHeadersWidth = 51;
            this.dgvDSMonAn.RowTemplate.Height = 24;
            this.dgvDSMonAn.Size = new System.Drawing.Size(564, 600);
            this.dgvDSMonAn.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.btnTimMon);
            this.panel1.Controls.Add(this.txtAdd_TenMon);
            this.panel1.Controls.Add(this.txtAdd_DanhMuc);
            this.panel1.Controls.Add(this.txtAdd_Gia);
            this.panel1.Controls.Add(this.txtAdd_LinkIMG);
            this.panel1.Controls.Add(this.txtAdd_Loai);
            this.panel1.Controls.Add(this.txtAdd_MoTa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 600);
            this.panel1.TabIndex = 6;
            // 
            // txtAdd_TenMon
            // 
            this.txtAdd_TenMon.Location = new System.Drawing.Point(197, 84);
            this.txtAdd_TenMon.Name = "txtAdd_TenMon";
            this.txtAdd_TenMon.Size = new System.Drawing.Size(281, 27);
            this.txtAdd_TenMon.TabIndex = 2;
            // 
            // txtAdd_DanhMuc
            // 
            this.txtAdd_DanhMuc.Location = new System.Drawing.Point(197, 143);
            this.txtAdd_DanhMuc.Name = "txtAdd_DanhMuc";
            this.txtAdd_DanhMuc.Size = new System.Drawing.Size(281, 27);
            this.txtAdd_DanhMuc.TabIndex = 2;
            // 
            // txtAdd_Gia
            // 
            this.txtAdd_Gia.Location = new System.Drawing.Point(197, 197);
            this.txtAdd_Gia.Name = "txtAdd_Gia";
            this.txtAdd_Gia.Size = new System.Drawing.Size(281, 27);
            this.txtAdd_Gia.TabIndex = 2;
            this.txtAdd_Gia.TextChanged += new System.EventHandler(this.txtAdd_Gia_TextChanged);
            this.txtAdd_Gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd_Gia_KeyPress);
            // 
            // txtAdd_LinkIMG
            // 
            this.txtAdd_LinkIMG.Location = new System.Drawing.Point(197, 257);
            this.txtAdd_LinkIMG.Name = "txtAdd_LinkIMG";
            this.txtAdd_LinkIMG.Size = new System.Drawing.Size(281, 27);
            this.txtAdd_LinkIMG.TabIndex = 2;
            // 
            // txtAdd_Loai
            // 
            this.txtAdd_Loai.Location = new System.Drawing.Point(197, 320);
            this.txtAdd_Loai.Name = "txtAdd_Loai";
            this.txtAdd_Loai.Size = new System.Drawing.Size(281, 27);
            this.txtAdd_Loai.TabIndex = 2;
            // 
            // txtAdd_MoTa
            // 
            this.txtAdd_MoTa.Location = new System.Drawing.Point(197, 388);
            this.txtAdd_MoTa.Name = "txtAdd_MoTa";
            this.txtAdd_MoTa.Size = new System.Drawing.Size(281, 27);
            this.txtAdd_MoTa.TabIndex = 2;
            // 
            // tpDanhMuc
            // 
            this.tpDanhMuc.Location = new System.Drawing.Point(4, 29);
            this.tpDanhMuc.Name = "tpDanhMuc";
            this.tpDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhMuc.Size = new System.Drawing.Size(1054, 606);
            this.tpDanhMuc.TabIndex = 2;
            this.tpDanhMuc.Text = "Danh Mục";
            this.tpDanhMuc.UseVisualStyleBackColor = true;
            // 
            // tpBanAn
            // 
            this.tpBanAn.Location = new System.Drawing.Point(4, 29);
            this.tpBanAn.Name = "tpBanAn";
            this.tpBanAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanAn.Size = new System.Drawing.Size(1054, 606);
            this.tpBanAn.TabIndex = 3;
            this.tpBanAn.Text = "Bàn Ăn";
            this.tpBanAn.UseVisualStyleBackColor = true;
            // 
            // tpDoanhThu
            // 
            this.tpDoanhThu.Controls.Add(this.panel2);
            this.tpDoanhThu.Location = new System.Drawing.Point(4, 29);
            this.tpDoanhThu.Name = "tpDoanhThu";
            this.tpDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoanhThu.Size = new System.Drawing.Size(1054, 606);
            this.tpDoanhThu.TabIndex = 4;
            this.tpDoanhThu.Text = "Doanh Thu";
            this.tpDoanhThu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 600);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDisplayBill);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.dtpkNgayDi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 74);
            this.panel4.TabIndex = 1;
            // 
            // btnDisplayBill
            // 
            this.btnDisplayBill.Location = new System.Drawing.Point(639, 3);
            this.btnDisplayBill.Name = "btnDisplayBill";
            this.btnDisplayBill.Size = new System.Drawing.Size(134, 60);
            this.btnDisplayBill.TabIndex = 7;
            this.btnDisplayBill.Text = "Display Bill";
            this.btnDisplayBill.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(476, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dtpkNgayDi
            // 
            this.dtpkNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayDi.Location = new System.Drawing.Point(476, 3);
            this.dtpkNgayDi.Name = "dtpkNgayDi";
            this.dtpkNgayDi.Size = new System.Drawing.Size(157, 27);
            this.dtpkNgayDi.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpkNgayDen);
            this.panel3.Controls.Add(this.dgvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 520);
            this.panel3.TabIndex = 0;
            // 
            // dtpkNgayDen
            // 
            this.dtpkNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayDen.Location = new System.Drawing.Point(374, -50);
            this.dtpkNgayDen.Name = "dtpkNgayDen";
            this.dtpkNgayDen.Size = new System.Drawing.Size(125, 27);
            this.dtpkNgayDen.TabIndex = 5;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(1048, 520);
            this.dgvBill.TabIndex = 4;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(3, 9);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(290, 41);
            this.guna2TextBox1.TabIndex = 3;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // frmADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 639);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmADMIN";
            this.Text = "frmADMIN";
            this.Load += new System.EventHandler(this.frmADMIN_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpThucAn.ResumeLayout(false);
            this.tpThucAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpDoanhThu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.TabPage tpThucAn;
        private System.Windows.Forms.TabPage tpDanhMuc;
        private System.Windows.Forms.TabPage tpBanAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private System.Windows.Forms.TextBox txtAdd_MoTa;
        private System.Windows.Forms.TextBox txtAdd_Loai;
        private System.Windows.Forms.TextBox txtAdd_LinkIMG;
        private System.Windows.Forms.TextBox txtAdd_Gia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdd_DanhMuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdd_TenMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDisplayBill;
        private System.Windows.Forms.DateTimePicker dtpkNgayDi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpkNgayDen;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}