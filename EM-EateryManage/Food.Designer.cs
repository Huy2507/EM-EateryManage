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
            this.lblNameFood = new System.Windows.Forms.Label();
            this.picSpagetti = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSpagetti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.Location = new System.Drawing.Point(3, 107);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(151, 20);
            this.lblNameFood.TabIndex = 1;
            this.lblNameFood.Text = "Mỳ Ý ( Spagetti )";
            // 
            // picSpagetti
            // 
            this.picSpagetti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSpagetti.Image = global::EM_EateryManage.Properties.Resources.MiYsotdautoi;
            this.picSpagetti.ImageRotate = 0F;
            this.picSpagetti.Location = new System.Drawing.Point(3, 3);
            this.picSpagetti.Name = "picSpagetti";
            this.picSpagetti.Size = new System.Drawing.Size(188, 101);
            this.picSpagetti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpagetti.TabIndex = 0;
            this.picSpagetti.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(101, 148);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "50.000đ";
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameFood);
            this.Controls.Add(this.picSpagetti);
            this.Name = "Food";
            this.Size = new System.Drawing.Size(192, 173);
            ((System.ComponentModel.ISupportInitialize)(this.picSpagetti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picSpagetti;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.Label lblPrice;
    }
}
