
namespace CIS3309_TheatreGroupProject
{
    partial class frmAddShow
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTheaterRoom = new System.Windows.Forms.TextBox();
            this.lblTheaterRoom = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.cbxMovieTitle = new System.Windows.Forms.ComboBox();
            this.cbxTimeSlot = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(181, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // tbxTheaterRoom
            // 
            this.tbxTheaterRoom.Location = new System.Drawing.Point(136, 15);
            this.tbxTheaterRoom.Name = "tbxTheaterRoom";
            this.tbxTheaterRoom.Size = new System.Drawing.Size(165, 29);
            this.tbxTheaterRoom.TabIndex = 2;
            // 
            // lblTheaterRoom
            // 
            this.lblTheaterRoom.AutoSize = true;
            this.lblTheaterRoom.Location = new System.Drawing.Point(3, 15);
            this.lblTheaterRoom.Name = "lblTheaterRoom";
            this.lblTheaterRoom.Size = new System.Drawing.Size(135, 25);
            this.lblTheaterRoom.TabIndex = 3;
            this.lblTheaterRoom.Text = "Theater room:";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(16, 50);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(113, 25);
            this.lblMovie.TabIndex = 6;
            this.lblMovie.Text = "Movie Title:";
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(16, 88);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(101, 25);
            this.lblTimeSlot.TabIndex = 7;
            this.lblTimeSlot.Text = "Time Slot:";
            // 
            // cbxMovieTitle
            // 
            this.cbxMovieTitle.FormattingEnabled = true;
            this.cbxMovieTitle.Location = new System.Drawing.Point(136, 50);
            this.cbxMovieTitle.Name = "cbxMovieTitle";
            this.cbxMovieTitle.Size = new System.Drawing.Size(165, 32);
            this.cbxMovieTitle.TabIndex = 8;
            // 
            // cbxTimeSlot
            // 
            this.cbxTimeSlot.FormattingEnabled = true;
            this.cbxTimeSlot.Location = new System.Drawing.Point(136, 88);
            this.cbxTimeSlot.Name = "cbxTimeSlot";
            this.cbxTimeSlot.Size = new System.Drawing.Size(165, 32);
            this.cbxTimeSlot.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblTheaterRoom);
            this.panel1.Controls.Add(this.cbxTimeSlot);
            this.panel1.Controls.Add(this.tbxTheaterRoom);
            this.panel1.Controls.Add(this.cbxMovieTitle);
            this.panel1.Controls.Add(this.lblMovie);
            this.panel1.Controls.Add(this.lblTimeSlot);
            this.panel1.Location = new System.Drawing.Point(96, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 142);
            this.panel1.TabIndex = 10;
            // 
            // frmAddShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmAddShow";
            this.Text = "frmAddShow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTheaterRoom;
        private System.Windows.Forms.Label lblTheaterRoom;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.ComboBox cbxMovieTitle;
        private System.Windows.Forms.ComboBox cbxTimeSlot;
        private System.Windows.Forms.Panel panel1;
    }
}