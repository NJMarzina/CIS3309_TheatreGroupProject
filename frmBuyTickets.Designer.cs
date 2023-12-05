
namespace CIS3309_TheatreGroupProject
{
    partial class frmBuyTickets
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
            this.cbxMovies = new System.Windows.Forms.ComboBox();
            this.cbxTimeSlots = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxMovies
            // 
            this.cbxMovies.FormattingEnabled = true;
            this.cbxMovies.Location = new System.Drawing.Point(58, 73);
            this.cbxMovies.Name = "cbxMovies";
            this.cbxMovies.Size = new System.Drawing.Size(121, 24);
            this.cbxMovies.TabIndex = 0;
            // 
            // cbxTimeSlots
            // 
            this.cbxTimeSlots.FormattingEnabled = true;
            this.cbxTimeSlots.Items.AddRange(new object[] {
            "8:00am-11:30am",
            "11:30am-3:00pm",
            "3:00pm-6:30pm",
            "6:30pm-10:00pm"});
            this.cbxTimeSlots.Location = new System.Drawing.Point(58, 156);
            this.cbxTimeSlots.Name = "cbxTimeSlots";
            this.cbxTimeSlots.Size = new System.Drawing.Size(121, 24);
            this.cbxTimeSlots.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(55, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(62, 17);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter by:";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(58, 50);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(56, 17);
            this.lblMovies.TabIndex = 3;
            this.lblMovies.Text = "Movies:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(58, 133);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time Slot:";
            // 
            // frmBuyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbxTimeSlots);
            this.Controls.Add(this.cbxMovies);
            this.Name = "frmBuyTickets";
            this.Text = "frmBuyTickets";
            this.Load += new System.EventHandler(this.frmBuyTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMovies;
        private System.Windows.Forms.ComboBox cbxTimeSlots;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblTime;
    }
}