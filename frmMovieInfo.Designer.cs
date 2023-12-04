
namespace CIS3309_TheatreGroupProject
{
    partial class frmMovieInfo
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
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDspTitle = new System.Windows.Forms.Label();
            this.lblDspGenre = new System.Windows.Forms.Label();
            this.lblDspDirector = new System.Windows.Forms.Label();
            this.lblDspRating = new System.Windows.Forms.Label();
            this.lblDspDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImg
            // 
            this.pbxImg.Location = new System.Drawing.Point(20, 14);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(387, 405);
            this.pbxImg.TabIndex = 0;
            this.pbxImg.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 206);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(24, 158);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(73, 25);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(24, 113);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(85, 25);
            this.lblDirector.TabIndex = 5;
            this.lblDirector.Text = "Director:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(24, 73);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(72, 25);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre:";
            // 
            // lblDspTitle
            // 
            this.lblDspTitle.AutoSize = true;
            this.lblDspTitle.Location = new System.Drawing.Point(150, 36);
            this.lblDspTitle.Name = "lblDspTitle";
            this.lblDspTitle.Size = new System.Drawing.Size(64, 25);
            this.lblDspTitle.TabIndex = 7;
            this.lblDspTitle.Text = "label1";
            // 
            // lblDspGenre
            // 
            this.lblDspGenre.AutoSize = true;
            this.lblDspGenre.Location = new System.Drawing.Point(150, 73);
            this.lblDspGenre.Name = "lblDspGenre";
            this.lblDspGenre.Size = new System.Drawing.Size(64, 25);
            this.lblDspGenre.TabIndex = 8;
            this.lblDspGenre.Text = "label1";
            // 
            // lblDspDirector
            // 
            this.lblDspDirector.AutoSize = true;
            this.lblDspDirector.Location = new System.Drawing.Point(150, 113);
            this.lblDspDirector.Name = "lblDspDirector";
            this.lblDspDirector.Size = new System.Drawing.Size(64, 25);
            this.lblDspDirector.TabIndex = 9;
            this.lblDspDirector.Text = "label1";
            // 
            // lblDspRating
            // 
            this.lblDspRating.AutoSize = true;
            this.lblDspRating.Location = new System.Drawing.Point(150, 158);
            this.lblDspRating.Name = "lblDspRating";
            this.lblDspRating.Size = new System.Drawing.Size(64, 25);
            this.lblDspRating.TabIndex = 10;
            this.lblDspRating.Text = "label1";
            // 
            // lblDspDescription
            // 
            this.lblDspDescription.AutoSize = true;
            this.lblDspDescription.Location = new System.Drawing.Point(150, 206);
            this.lblDspDescription.Name = "lblDspDescription";
            this.lblDspDescription.Size = new System.Drawing.Size(64, 25);
            this.lblDspDescription.TabIndex = 11;
            this.lblDspDescription.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pbxImg);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 433);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblDspRating);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblDspDescription);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.lblRating);
            this.panel2.Controls.Add(this.lblDspDirector);
            this.panel2.Controls.Add(this.lblDirector);
            this.panel2.Controls.Add(this.lblDspGenre);
            this.panel2.Controls.Add(this.lblGenre);
            this.panel2.Controls.Add(this.lblDspTitle);
            this.panel2.Location = new System.Drawing.Point(468, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 271);
            this.panel2.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(825, 309);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 46);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 482);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMovieInfo";
            this.Text = "frmMovieInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDspTitle;
        private System.Windows.Forms.Label lblDspGenre;
        private System.Windows.Forms.Label lblDspDirector;
        private System.Windows.Forms.Label lblDspRating;
        private System.Windows.Forms.Label lblDspDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
    }
}