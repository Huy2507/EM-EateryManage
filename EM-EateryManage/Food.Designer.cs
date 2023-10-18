namespace EM_EateryManage
{
    partial class Food
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
<<<<<<< HEAD
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameFood = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
=======
            this.pnFood = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameFood = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.pnFood.SuspendLayout();
>>>>>>> de4504eef60f4d96843c0691405ee7af511b7213
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnFood
            // 
            this.pnFood.BorderRadius = 24;
            this.pnFood.BorderThickness = 30;
            this.pnFood.Controls.Add(this.lblPrice);
            this.pnFood.Controls.Add(this.lblNameFood);
            this.pnFood.Controls.Add(this.picFood);
            this.pnFood.Location = new System.Drawing.Point(-1, -1);
            this.pnFood.Name = "pnFood";
            this.pnFood.Size = new System.Drawing.Size(192, 187);
            this.pnFood.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(95, 162);
            this.lblPrice.MaximumSize = new System.Drawing.Size(192, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            this.lblPrice.SizeChanged += new System.EventHandler(this.lblPrice_SizeChanged_1);
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoEllipsis = true;
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.Location = new System.Drawing.Point(4, 112);
            this.lblNameFood.MaximumSize = new System.Drawing.Size(192, 0);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(123, 25);
            this.lblNameFood.TabIndex = 8;
            this.lblNameFood.Text = "Name Food";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(26, 151);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoEllipsis = true;
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.Location = new System.Drawing.Point(4, 112);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(123, 25);
            this.lblNameFood.TabIndex = 8;
            this.lblNameFood.Text = "Name Food";
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(0, 0);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(192, 109);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 7;
            this.picFood.TabStop = false;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnFood);
            this.Name = "Food";
            this.Size = new System.Drawing.Size(190, 187);
            this.Load += new System.EventHandler(this.Food_Load);
            this.Click += new System.EventHandler(this.Food_Click);
            this.pnFood.ResumeLayout(false);
            this.pnFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnFood;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.Label lblPrice;
    }
}
