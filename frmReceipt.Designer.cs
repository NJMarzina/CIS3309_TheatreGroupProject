
namespace CIS3309_TheatreGroupProject
{
    partial class frmReceipt
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblPlease = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(46, 213);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 17);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(27, 27);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(396, 39);
            this.lblThanks.TabIndex = 1;
            this.lblThanks.Text = "Thank you for your order!";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(46, 141);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(125, 17);
            this.lblMovie.TabIndex = 2;
            this.lblMovie.Text = "You bought tickets";
            // 
            // lblPlease
            // 
            this.lblPlease.AutoSize = true;
            this.lblPlease.Location = new System.Drawing.Point(46, 248);
            this.lblPlease.Name = "lblPlease";
            this.lblPlease.Size = new System.Drawing.Size(131, 17);
            this.lblPlease.TabIndex = 3;
            this.lblPlease.Text = "Please come again!";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(128, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 72);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close Tab";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(46, 176);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(113, 17);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Movie will play at";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(46, 110);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(104, 17);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Tickets amount";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPlease);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "frmReceipt";
            this.Text = "frmReceipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblPlease;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAmount;
    }
}