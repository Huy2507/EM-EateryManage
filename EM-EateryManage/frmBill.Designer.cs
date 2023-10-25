namespace EM_EateryManage
{
    partial class frmBill
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
            this.cbTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbSoDienThoaiCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbGiamGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTable
            // 
            this.cbTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTable.BackColor = System.Drawing.Color.Transparent;
            this.cbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTable.ItemHeight = 30;
            this.cbTable.Location = new System.Drawing.Point(263, 3);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(799, 36);
            this.cbTable.TabIndex = 0;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbGiamGia);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txbSoDienThoaiCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbTong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGiamGia);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 127);
            this.panel1.TabIndex = 6;
            // 
            // txbTong
            // 
            this.txbTong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTong.DefaultText = "";
            this.txbTong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTong.Enabled = false;
            this.txbTong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTong.Location = new System.Drawing.Point(299, 16);
            this.txbTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTong.Name = "txbTong";
            this.txbTong.PasswordChar = '\0';
            this.txbTong.PlaceholderText = "";
            this.txbTong.SelectedText = "";
            this.txbTong.Size = new System.Drawing.Size(268, 48);
            this.txbTong.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng phải thanh toán";
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamGia.Location = new System.Drawing.Point(614, 16);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(209, 38);
            this.btnGiamGia.TabIndex = 1;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(829, 16);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(213, 82);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 466);
            this.panel2.TabIndex = 7;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(1062, 466);
            this.dtgvBill.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn Bàn Cần Xem Bill:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 46);
            this.panel3.TabIndex = 9;
            // 
            // txbSoDienThoaiCustomer
            // 
            this.txbSoDienThoaiCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDienThoaiCustomer.DefaultText = "";
            this.txbSoDienThoaiCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSoDienThoaiCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSoDienThoaiCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoDienThoaiCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoDienThoaiCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoDienThoaiCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoDienThoaiCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoDienThoaiCustomer.Location = new System.Drawing.Point(176, 72);
            this.txbSoDienThoaiCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSoDienThoaiCustomer.Name = "txbSoDienThoaiCustomer";
            this.txbSoDienThoaiCustomer.PasswordChar = '\0';
            this.txbSoDienThoaiCustomer.PlaceholderText = "";
            this.txbSoDienThoaiCustomer.SelectedText = "";
            this.txbSoDienThoaiCustomer.Size = new System.Drawing.Size(268, 48);
            this.txbSoDienThoaiCustomer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(450, 72);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(132, 48);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txbGiamGia
            // 
            this.txbGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGiamGia.DefaultText = "";
            this.txbGiamGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbGiamGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbGiamGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbGiamGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbGiamGia.Enabled = false;
            this.txbGiamGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbGiamGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbGiamGia.Location = new System.Drawing.Point(614, 65);
            this.txbGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbGiamGia.Name = "txbGiamGia";
            this.txbGiamGia.PasswordChar = '\0';
            this.txbGiamGia.PlaceholderText = "";
            this.txbGiamGia.ReadOnly = true;
            this.txbGiamGia.SelectedText = "";
            this.txbGiamGia.Size = new System.Drawing.Size(209, 48);
            this.txbGiamGia.TabIndex = 10;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1062, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private Guna.UI2.WinForms.Guna2TextBox txbTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txbSoDienThoaiCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private Guna.UI2.WinForms.Guna2TextBox txbGiamGia;
    }
}