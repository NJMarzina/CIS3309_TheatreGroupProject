
namespace CIS3309_TheatreGroupProject
{
    partial class frmShowView
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
            this.dgvShows = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFilterMovie = new System.Windows.Forms.Button();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.cbxMovieTitle = new System.Windows.Forms.ComboBox();
            this.cbxFilterTime = new System.Windows.Forms.ComboBox();
            this.btnFilterTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShows
            // 
            this.dgvShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShows.Location = new System.Drawing.Point(20, 16);
            this.dgvShows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvShows.Name = "dgvShows";
            this.dgvShows.RowHeadersWidth = 72;
            this.dgvShows.RowTemplate.Height = 31;
            this.dgvShows.Size = new System.Drawing.Size(1383, 224);
            this.dgvShows.TabIndex = 0;
            this.dgvShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 250);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFilterMovie
            // 
            this.btnFilterMovie.Location = new System.Drawing.Point(143, 250);
            this.btnFilterMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilterMovie.Name = "btnFilterMovie";
            this.btnFilterMovie.Size = new System.Drawing.Size(123, 37);
            this.btnFilterMovie.TabIndex = 4;
            this.btnFilterMovie.Text = "Filter By Movie";
            this.btnFilterMovie.UseVisualStyleBackColor = true;
            this.btnFilterMovie.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddShow
            // 
            this.btnAddShow.Location = new System.Drawing.Point(271, 250);
            this.btnAddShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(108, 37);
            this.btnAddShow.TabIndex = 5;
            this.btnAddShow.Text = "Add Show";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxMovieTitle
            // 
            this.cbxMovieTitle.FormattingEnabled = true;
            this.cbxMovieTitle.Location = new System.Drawing.Point(17, 258);
            this.cbxMovieTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMovieTitle.Name = "cbxMovieTitle";
            this.cbxMovieTitle.Size = new System.Drawing.Size(123, 24);
            this.cbxMovieTitle.TabIndex = 6;
            this.cbxMovieTitle.SelectedIndexChanged += new System.EventHandler(this.cbxMovieTitle_SelectedIndexChanged);
            // 
            // cbxFilterTime
            // 
            this.cbxFilterTime.FormattingEnabled = true;
            this.cbxFilterTime.Location = new System.Drawing.Point(17, 301);
            this.cbxFilterTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFilterTime.Name = "cbxFilterTime";
            this.cbxFilterTime.Size = new System.Drawing.Size(123, 24);
            this.cbxFilterTime.TabIndex = 7;
            // 
            // btnFilterTime
            // 
            this.btnFilterTime.Location = new System.Drawing.Point(143, 293);
            this.btnFilterTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilterTime.Name = "btnFilterTime";
            this.btnFilterTime.Size = new System.Drawing.Size(123, 37);
            this.btnFilterTime.TabIndex = 8;
            this.btnFilterTime.Text = "Filter By Time";
            this.btnFilterTime.UseVisualStyleBackColor = true;
            // 
            // frmShowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 483);
            this.Controls.Add(this.btnFilterTime);
            this.Controls.Add(this.cbxFilterTime);
            this.Controls.Add(this.cbxMovieTitle);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.btnFilterMovie);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvShows);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmShowView";
            this.Text = "frmShowView";
            this.Load += new System.EventHandler(this.frmShowView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShows;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFilterMovie;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.ComboBox cbxMovieTitle;
        private System.Windows.Forms.ComboBox cbxFilterTime;
        private System.Windows.Forms.Button btnFilterTime;
    }
}