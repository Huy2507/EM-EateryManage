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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmOrder = new Guna.UI2.WinForms.Guna2Button();
            this.cbTable = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.ColumnHeadersHeight = 24;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(601, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.RowTemplate.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(461, 535);
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
            this.flpnlMenu.Location = new System.Drawing.Point(0, 32);
            this.flpnlMenu.Name = "flpnlMenu";
            this.flpnlMenu.Size = new System.Drawing.Size(601, 607);
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
            this.cbTable.BorderRadius = 4;
            this.cbTable.BorderThickness = 2;
            this.cbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTable.ItemHeight = 30;
            this.cbTable.Location = new System.Drawing.Point(0, 0);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(601, 36);
            this.cbTable.TabIndex = 1;
            this.cbTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // frmOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1062, 639);
            this.Controls.Add(this.flpnlMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.dgvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvOrder;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel flpnlMenu;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnConfirmOrder;
        private Guna.UI2.WinForms.Guna2Button btnCancelOrder;
        private Guna.UI2.WinForms.Guna2ComboBox cbTable;
    }
}