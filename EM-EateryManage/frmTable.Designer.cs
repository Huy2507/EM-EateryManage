using System.Windows.Forms;

namespace EM_EateryManage
{
    partial class frmTable
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
            this.pntable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReloadTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFindTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnX = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pntable
            // 
            this.pntable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pntable.Location = new System.Drawing.Point(0, 83);
            this.pntable.Margin = new System.Windows.Forms.Padding(10);
            this.pntable.Name = "pntable";
            this.pntable.Padding = new System.Windows.Forms.Padding(10);
            this.pntable.Size = new System.Drawing.Size(1062, 556);
            this.pntable.TabIndex = 0;
            // 
            // btnReloadTable
            // 
            this.btnReloadTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadTable.Location = new System.Drawing.Point(0, 1);
            this.btnReloadTable.Name = "btnReloadTable";
            this.btnReloadTable.Size = new System.Drawing.Size(240, 77);
            this.btnReloadTable.TabIndex = 1;
            this.btnReloadTable.Text = "Reload Table";
            this.btnReloadTable.UseVisualStyleBackColor = true;
            this.btnReloadTable.Click += new System.EventHandler(this.btnReloadTable_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.txtFindTable);
            this.panel1.Location = new System.Drawing.Point(326, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 69);
            this.panel1.TabIndex = 2;
            // 
            // txtFindTable
            // 
            this.txtFindTable.BorderRadius = 12;
            this.txtFindTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindTable.DefaultText = "Nhập Bàn Muốn Tìm";
            this.txtFindTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindTable.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.txtFindTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindTable.Location = new System.Drawing.Point(0, 0);
            this.txtFindTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindTable.Name = "txtFindTable";
            this.txtFindTable.PasswordChar = '\0';
            this.txtFindTable.PlaceholderText = "";
            this.txtFindTable.SelectedText = "";
            this.txtFindTable.Size = new System.Drawing.Size(458, 69);
            this.txtFindTable.TabIndex = 1;
            this.txtFindTable.TextChanged += new System.EventHandler(this.txtFindTable_TextChanged);
            this.txtFindTable.Click += new System.EventHandler(this.txtFindTable_Click);
            this.txtFindTable.Leave += new System.EventHandler(this.txtFindTable_Leave);
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
            this.btnX.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(380, 3);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(65, 63);
            this.btnX.TabIndex = 3;
            this.btnX.Text = "x";
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReloadTable);
            this.Controls.Add(this.pntable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pntable;
        private System.Windows.Forms.Button btnReloadTable;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFindTable;
        private Guna.UI2.WinForms.Guna2Button btnX;
    }
}