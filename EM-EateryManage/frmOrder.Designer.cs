namespace EM_EateryManage
{
    partial class frmOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.flpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmOrder = new Guna.UI2.WinForms.Guna2Button();
            this.cbTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnX = new Guna.UI2.WinForms.Guna2Button();
            this.txtFindFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnDanhMuc = new System.Windows.Forms.Panel();
            this.btnDrink = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodTrangMieng = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodHaiSan = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodChay = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodRau = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodCa = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodThit = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodMy = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodCom = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodAll = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnDanhMuc.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrder.ColumnHeadersHeight = 24;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(601, 42);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.RowTemplate.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(461, 416);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrder.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvOrder.ThemeStyle.ReadOnly = true;
            this.dgvOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrder.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // flpnlMenu
            // 
            this.flpnlMenu.AutoScroll = true;
            this.flpnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnlMenu.Location = new System.Drawing.Point(0, 79);
            this.flpnlMenu.Name = "flpnlMenu";
            this.flpnlMenu.Size = new System.Drawing.Size(601, 569);
            this.flpnlMenu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelOrder);
            this.panel1.Controls.Add(this.btnConfirmOrder);
            this.panel1.Location = new System.Drawing.Point(601, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 107);
            this.panel1.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BorderRadius = 24;
            this.btnCancelOrder.BorderThickness = 3;
            this.btnCancelOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCancelOrder.Location = new System.Drawing.Point(32, 17);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(178, 73);
            this.btnCancelOrder.TabIndex = 0;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BorderRadius = 24;
            this.btnConfirmOrder.BorderThickness = 3;
            this.btnConfirmOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConfirmOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmOrder.Location = new System.Drawing.Point(255, 17);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(178, 73);
            this.btnConfirmOrder.TabIndex = 0;
            this.btnConfirmOrder.Text = "Confirm";
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // cbTable
            // 
            this.cbTable.AllowDrop = true;
            this.cbTable.BackColor = System.Drawing.Color.Transparent;
            this.cbTable.BorderRadius = 12;
            this.cbTable.BorderThickness = 2;
            this.cbTable.DisplayMember = "Table 1";
            this.cbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTable.FormatString = "12.5";
            this.cbTable.ItemHeight = 30;
            this.cbTable.Location = new System.Drawing.Point(128, 0);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 36);
            this.cbTable.TabIndex = 1;
            this.cbTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            this.cbTable.Click += new System.EventHandler(this.cbTable_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnDanhMuc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.flpnlMenu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 648);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnX);
            this.panel4.Controls.Add(this.txtFindFood);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(255, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 37);
            this.panel4.TabIndex = 4;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.BorderRadius = 12;
            this.btnX.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnX.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnX.FillColor = System.Drawing.Color.White;
            this.btnX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(300, 3);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(35, 31);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "x";
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtFindFood
            // 
            this.txtFindFood.BorderRadius = 12;
            this.txtFindFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindFood.DefaultText = "Nhập Món Muốn Tìm";
            this.txtFindFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindFood.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.txtFindFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindFood.Location = new System.Drawing.Point(0, 0);
            this.txtFindFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindFood.Name = "txtFindFood";
            this.txtFindFood.PasswordChar = '\0';
            this.txtFindFood.PlaceholderText = "";
            this.txtFindFood.SelectedText = "";
            this.txtFindFood.Size = new System.Drawing.Size(346, 37);
            this.txtFindFood.TabIndex = 0;
            this.txtFindFood.TextChanged += new System.EventHandler(this.txtFindFood_TextChanged);
            this.txtFindFood.Click += new System.EventHandler(this.txtFindFood_Click);
            this.txtFindFood.Leave += new System.EventHandler(this.txtFindFood_Leave);
            // 
            // pnDanhMuc
            // 
            this.pnDanhMuc.Controls.Add(this.btnDrink);
            this.pnDanhMuc.Controls.Add(this.btnFoodTrangMieng);
            this.pnDanhMuc.Controls.Add(this.btnFoodNuoc);
            this.pnDanhMuc.Controls.Add(this.btnFoodHaiSan);
            this.pnDanhMuc.Controls.Add(this.btnFoodChay);
            this.pnDanhMuc.Controls.Add(this.btnFoodRau);
            this.pnDanhMuc.Controls.Add(this.btnFoodCa);
            this.pnDanhMuc.Controls.Add(this.btnFoodThit);
            this.pnDanhMuc.Controls.Add(this.btnFoodMy);
            this.pnDanhMuc.Controls.Add(this.btnFoodCom);
            this.pnDanhMuc.Controls.Add(this.btnFoodAll);
            this.pnDanhMuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDanhMuc.Location = new System.Drawing.Point(0, 37);
            this.pnDanhMuc.Name = "pnDanhMuc";
            this.pnDanhMuc.Size = new System.Drawing.Size(601, 42);
            this.pnDanhMuc.TabIndex = 3;
            // 
            // btnDrink
            // 
            this.btnDrink.BorderRadius = 6;
            this.btnDrink.BorderThickness = 1;
            this.btnDrink.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDrink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDrink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDrink.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnDrink.ForeColor = System.Drawing.Color.Black;
            this.btnDrink.Location = new System.Drawing.Point(547, 0);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(54, 42);
            this.btnDrink.TabIndex = 10;
            this.btnDrink.Text = "Nước";
            this.btnDrink.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodTrangMieng
            // 
            this.btnFoodTrangMieng.BorderRadius = 6;
            this.btnFoodTrangMieng.BorderThickness = 1;
            this.btnFoodTrangMieng.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodTrangMieng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodTrangMieng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodTrangMieng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodTrangMieng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodTrangMieng.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodTrangMieng.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodTrangMieng.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodTrangMieng.ForeColor = System.Drawing.Color.Black;
            this.btnFoodTrangMieng.Location = new System.Drawing.Point(486, 0);
            this.btnFoodTrangMieng.Name = "btnFoodTrangMieng";
            this.btnFoodTrangMieng.Size = new System.Drawing.Size(61, 42);
            this.btnFoodTrangMieng.TabIndex = 9;
            this.btnFoodTrangMieng.Text = "Tráng Miệng";
            this.btnFoodTrangMieng.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodNuoc
            // 
            this.btnFoodNuoc.BorderRadius = 6;
            this.btnFoodNuoc.BorderThickness = 1;
            this.btnFoodNuoc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodNuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodNuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodNuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodNuoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodNuoc.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodNuoc.ForeColor = System.Drawing.Color.Black;
            this.btnFoodNuoc.Location = new System.Drawing.Point(432, 0);
            this.btnFoodNuoc.Name = "btnFoodNuoc";
            this.btnFoodNuoc.Size = new System.Drawing.Size(54, 42);
            this.btnFoodNuoc.TabIndex = 8;
            this.btnFoodNuoc.Text = "Món Nước";
            this.btnFoodNuoc.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodHaiSan
            // 
            this.btnFoodHaiSan.BorderRadius = 6;
            this.btnFoodHaiSan.BorderThickness = 1;
            this.btnFoodHaiSan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodHaiSan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodHaiSan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodHaiSan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodHaiSan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodHaiSan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodHaiSan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodHaiSan.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodHaiSan.ForeColor = System.Drawing.Color.Black;
            this.btnFoodHaiSan.Location = new System.Drawing.Point(378, 0);
            this.btnFoodHaiSan.Name = "btnFoodHaiSan";
            this.btnFoodHaiSan.Size = new System.Drawing.Size(54, 42);
            this.btnFoodHaiSan.TabIndex = 7;
            this.btnFoodHaiSan.Text = "Hải Sản";
            this.btnFoodHaiSan.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodChay
            // 
            this.btnFoodChay.BorderRadius = 6;
            this.btnFoodChay.BorderThickness = 1;
            this.btnFoodChay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodChay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodChay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodChay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodChay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodChay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodChay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodChay.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodChay.ForeColor = System.Drawing.Color.Black;
            this.btnFoodChay.Location = new System.Drawing.Point(324, 0);
            this.btnFoodChay.Name = "btnFoodChay";
            this.btnFoodChay.Size = new System.Drawing.Size(54, 42);
            this.btnFoodChay.TabIndex = 6;
            this.btnFoodChay.Text = "Chay";
            this.btnFoodChay.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodRau
            // 
            this.btnFoodRau.BorderRadius = 6;
            this.btnFoodRau.BorderThickness = 1;
            this.btnFoodRau.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodRau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodRau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodRau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodRau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodRau.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodRau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodRau.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodRau.ForeColor = System.Drawing.Color.Black;
            this.btnFoodRau.Location = new System.Drawing.Point(270, 0);
            this.btnFoodRau.Name = "btnFoodRau";
            this.btnFoodRau.Size = new System.Drawing.Size(54, 42);
            this.btnFoodRau.TabIndex = 5;
            this.btnFoodRau.Text = "Rau";
            this.btnFoodRau.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodCa
            // 
            this.btnFoodCa.BorderRadius = 6;
            this.btnFoodCa.BorderThickness = 1;
            this.btnFoodCa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodCa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodCa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodCa.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodCa.ForeColor = System.Drawing.Color.Black;
            this.btnFoodCa.Location = new System.Drawing.Point(216, 0);
            this.btnFoodCa.Name = "btnFoodCa";
            this.btnFoodCa.Size = new System.Drawing.Size(54, 42);
            this.btnFoodCa.TabIndex = 4;
            this.btnFoodCa.Text = "Cá";
            this.btnFoodCa.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodThit
            // 
            this.btnFoodThit.BorderRadius = 6;
            this.btnFoodThit.BorderThickness = 1;
            this.btnFoodThit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodThit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodThit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodThit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodThit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodThit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodThit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodThit.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodThit.ForeColor = System.Drawing.Color.Black;
            this.btnFoodThit.Location = new System.Drawing.Point(162, 0);
            this.btnFoodThit.Name = "btnFoodThit";
            this.btnFoodThit.Size = new System.Drawing.Size(54, 42);
            this.btnFoodThit.TabIndex = 3;
            this.btnFoodThit.Text = "Thịt";
            this.btnFoodThit.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodMy
            // 
            this.btnFoodMy.BorderRadius = 6;
            this.btnFoodMy.BorderThickness = 1;
            this.btnFoodMy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodMy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodMy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodMy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodMy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodMy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodMy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodMy.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodMy.ForeColor = System.Drawing.Color.Black;
            this.btnFoodMy.Location = new System.Drawing.Point(108, 0);
            this.btnFoodMy.Name = "btnFoodMy";
            this.btnFoodMy.Size = new System.Drawing.Size(54, 42);
            this.btnFoodMy.TabIndex = 2;
            this.btnFoodMy.Text = "Mỳ";
            this.btnFoodMy.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodCom
            // 
            this.btnFoodCom.BorderRadius = 6;
            this.btnFoodCom.BorderThickness = 1;
            this.btnFoodCom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodCom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodCom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodCom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodCom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodCom.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodCom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodCom.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodCom.ForeColor = System.Drawing.Color.Black;
            this.btnFoodCom.Location = new System.Drawing.Point(54, 0);
            this.btnFoodCom.Name = "btnFoodCom";
            this.btnFoodCom.Size = new System.Drawing.Size(54, 42);
            this.btnFoodCom.TabIndex = 1;
            this.btnFoodCom.Text = "Cơm";
            this.btnFoodCom.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // btnFoodAll
            // 
            this.btnFoodAll.BorderRadius = 6;
            this.btnFoodAll.BorderThickness = 1;
            this.btnFoodAll.Checked = true;
            this.btnFoodAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFoodAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFoodAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFoodAll.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnFoodAll.ForeColor = System.Drawing.Color.Black;
            this.btnFoodAll.Location = new System.Drawing.Point(0, 0);
            this.btnFoodAll.Name = "btnFoodAll";
            this.btnFoodAll.Size = new System.Drawing.Size(54, 42);
            this.btnFoodAll.TabIndex = 0;
            this.btnFoodAll.Text = "Tất Cả";
            this.btnFoodAll.Click += new System.EventHandler(this.MyButtonDanhMuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Bàn ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Các Món Ăn Đã Được Chọn";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(197, 4);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 25);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Tổng:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(297, 4);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(30, 25);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Controls.Add(this.lblTongTien);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(601, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 35);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbTrangThai);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(601, 494);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(461, 38);
            this.panel5.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng Thái:";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTrangThai.ItemHeight = 30;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cbTrangThai.Location = new System.Drawing.Point(281, 0);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(180, 36);
            this.cbTrangThai.TabIndex = 8;
            // 
            // frmOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1062, 639);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "6";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnDanhMuc.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvOrder;
        private System.Windows.Forms.FlowLayoutPanel flpnlMenu;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnConfirmOrder;
        private Guna.UI2.WinForms.Guna2Button btnCancelOrder;
        private Guna.UI2.WinForms.Guna2ComboBox cbTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btnFoodAll;
        private Guna.UI2.WinForms.Guna2Button btnDrink;
        private Guna.UI2.WinForms.Guna2Button btnFoodTrangMieng;
        private Guna.UI2.WinForms.Guna2Button btnFoodNuoc;
        private Guna.UI2.WinForms.Guna2Button btnFoodHaiSan;
        private Guna.UI2.WinForms.Guna2Button btnFoodChay;
        private Guna.UI2.WinForms.Guna2Button btnFoodRau;
        private Guna.UI2.WinForms.Guna2Button btnFoodCa;
        private Guna.UI2.WinForms.Guna2Button btnFoodThit;
        private Guna.UI2.WinForms.Guna2Button btnFoodMy;
        private Guna.UI2.WinForms.Guna2Button btnFoodCom;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtFindFood;
        private Guna.UI2.WinForms.Guna2Button btnX;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangThai;
        private System.Windows.Forms.Label label3;
    }
}