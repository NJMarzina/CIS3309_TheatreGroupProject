
namespace CIS3309_TheatreGroupProject
{
    partial class frmAddMovie
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxMovie = new System.Windows.Forms.TextBox();
            this.tbxDirector = new System.Windows.Forms.TextBox();
            this.tbxRating = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.tbxImg = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(60, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxMovie
            // 
            this.tbxMovie.Location = new System.Drawing.Point(130, 76);
            this.tbxMovie.Name = "tbxMovie";
            this.tbxMovie.Size = new System.Drawing.Size(124, 29);
            this.tbxMovie.TabIndex = 2;
            // 
            // tbxDirector
            // 
            this.tbxDirector.Location = new System.Drawing.Point(130, 166);
            this.tbxDirector.Name = "tbxDirector";
            this.tbxDirector.Size = new System.Drawing.Size(124, 29);
            this.tbxDirector.TabIndex = 4;
            // 
            // tbxRating
            // 
            this.tbxRating.Location = new System.Drawing.Point(130, 212);
            this.tbxRating.Name = "tbxRating";
            this.tbxRating.Size = new System.Drawing.Size(124, 29);
            this.tbxRating.TabIndex = 5;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(60, 121);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(66, 25);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(48, 166);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(79, 25);
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Text = "Director";
            this.lblDirector.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(60, 216);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(67, 25);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Rating";
            // 
            // tbxImg
            // 
            this.tbxImg.Location = new System.Drawing.Point(130, 301);
            this.tbxImg.Name = "tbxImg";
            this.tbxImg.Size = new System.Drawing.Size(329, 29);
            this.tbxImg.TabIndex = 9;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(130, 257);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(329, 29);
            this.tbxDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 257);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 25);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(60, 305);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(66, 25);
            this.lblImg.TabIndex = 12;
            this.lblImg.Text = "Image";
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Location = new System.Drawing.Point(133, 121);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(121, 32);
            this.cbxGenre.TabIndex = 13;
            this.cbxGenre.SelectedIndexChanged += new System.EventHandler(this.cbxGenre_SelectedIndexChanged);
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 454);
            this.Controls.Add(this.cbxGenre);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxImg);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.tbxRating);
            this.Controls.Add(this.tbxDirector);
            this.Controls.Add(this.tbxMovie);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddMovie";
            this.Text = "frmAddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxMovie;
        private System.Windows.Forms.TextBox tbxDirector;
        private System.Windows.Forms.TextBox tbxRating;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox tbxImg;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.ComboBox cbxGenre;
    }
}