namespace EM_EateryManage
{
    partial class frmBillManage
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
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dttpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dttpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvManageBill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dttpToDate);
            this.panel1.Controls.Add(this.dttpFromDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 104);
            this.panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnViewBill.Location = new System.Drawing.Point(406, 25);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(226, 58);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dttpToDate
            // 
            this.dttpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dttpToDate.Checked = true;
            this.dttpToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dttpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dttpToDate.Location = new System.Drawing.Point(638, 25);
            this.dttpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dttpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dttpToDate.Name = "dttpToDate";
            this.dttpToDate.Size = new System.Drawing.Size(386, 59);
            this.dttpToDate.TabIndex = 1;
            this.dttpToDate.Value = new System.DateTime(2023, 10, 21, 23, 36, 18, 329);
            // 
            // dttpFromDate
            // 
            this.dttpFromDate.Checked = true;
            this.dttpFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dttpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dttpFromDate.Location = new System.Drawing.Point(14, 26);
            this.dttpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dttpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dttpFromDate.Name = "dttpFromDate";
            this.dttpFromDate.Size = new System.Drawing.Size(386, 58);
            this.dttpFromDate.TabIndex = 0;
            this.dttpFromDate.Value = new System.DateTime(2023, 10, 21, 23, 35, 8, 609);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvManageBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 537);
            this.panel2.TabIndex = 1;
            // 
            // dtgvManageBill
            // 
            this.dtgvManageBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvManageBill.Name = "dtgvManageBill";
            this.dtgvManageBill.RowHeadersWidth = 51;
            this.dtgvManageBill.RowTemplate.Height = 24;
            this.dtgvManageBill.Size = new System.Drawing.Size(1062, 537);
            this.dtgvManageBill.TabIndex = 0;
            // 
            // frmBillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillManage";
            this.Text = "frmBillManage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private Guna.UI2.WinForms.Guna2DateTimePicker dttpToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dttpFromDate;
        private System.Windows.Forms.DataGridView dtgvManageBill;
    }
}