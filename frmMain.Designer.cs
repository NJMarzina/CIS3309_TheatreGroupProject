
namespace CIS3309_TheatreGroupProject
{
    partial class frmMain
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnViewShows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(78, 74);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(162, 67);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Movies";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnViewShows
            // 
            this.btnViewShows.Location = new System.Drawing.Point(78, 240);
            this.btnViewShows.Name = "btnViewShows";
            this.btnViewShows.Size = new System.Drawing.Size(162, 67);
            this.btnViewShows.TabIndex = 2;
            this.btnViewShows.Text = "View Shows";
            this.btnViewShows.UseVisualStyleBackColor = true;
            this.btnViewShows.Click += new System.EventHandler(this.btnViewShows_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.btnViewShows);
            this.Controls.Add(this.btnView);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnViewShows;
    }
}

