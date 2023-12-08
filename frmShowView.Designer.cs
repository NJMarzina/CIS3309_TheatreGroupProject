
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShows
            // 
            this.dgvShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShows.Location = new System.Drawing.Point(32, 65);
            this.dgvShows.Name = "dgvShows";
            this.dgvShows.RowHeadersWidth = 72;
            this.dgvShows.RowTemplate.Height = 31;
            this.dgvShows.Size = new System.Drawing.Size(1902, 336);
            this.dgvShows.TabIndex = 0;
            this.dgvShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 56);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFilterMovie
            // 
            this.btnFilterMovie.Location = new System.Drawing.Point(201, 416);
            this.btnFilterMovie.Name = "btnFilterMovie";
            this.btnFilterMovie.Size = new System.Drawing.Size(169, 56);
            this.btnFilterMovie.TabIndex = 4;
            this.btnFilterMovie.Text = "Filter By Movie";
            this.btnFilterMovie.UseVisualStyleBackColor = true;
            this.btnFilterMovie.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddShow
            // 
            this.btnAddShow.Location = new System.Drawing.Point(377, 416);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(148, 56);
            this.btnAddShow.TabIndex = 5;
            this.btnAddShow.Text = "Add Show";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxMovieTitle
            // 
            this.cbxMovieTitle.FormattingEnabled = true;
            this.cbxMovieTitle.Location = new System.Drawing.Point(27, 428);
            this.cbxMovieTitle.Name = "cbxMovieTitle";
            this.cbxMovieTitle.Size = new System.Drawing.Size(168, 32);
            this.cbxMovieTitle.TabIndex = 6;
            this.cbxMovieTitle.SelectedIndexChanged += new System.EventHandler(this.cbxMovieTitle_SelectedIndexChanged);
            // 
            // cbxFilterTime
            // 
            this.cbxFilterTime.FormattingEnabled = true;
            this.cbxFilterTime.Location = new System.Drawing.Point(27, 494);
            this.cbxFilterTime.Name = "cbxFilterTime";
            this.cbxFilterTime.Size = new System.Drawing.Size(168, 32);
            this.cbxFilterTime.TabIndex = 7;
            // 
            // btnFilterTime
            // 
            this.btnFilterTime.Location = new System.Drawing.Point(201, 481);
            this.btnFilterTime.Name = "btnFilterTime";
            this.btnFilterTime.Size = new System.Drawing.Size(169, 56);
            this.btnFilterTime.TabIndex = 8;
            this.btnFilterTime.Text = "Filter By Time";
            this.btnFilterTime.UseVisualStyleBackColor = true;
            this.btnFilterTime.Click += new System.EventHandler(this.btnFilterTime_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1745, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 56);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh/ Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Here you casn manage the shows by adding, deleting and filtering";
            // 
            // frmShowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFilterTime);
            this.Controls.Add(this.cbxFilterTime);
            this.Controls.Add(this.cbxMovieTitle);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.btnFilterMovie);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvShows);
            this.Name = "frmShowView";
            this.Text = "frmShowView";
            this.Load += new System.EventHandler(this.frmShowView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShows;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFilterMovie;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.ComboBox cbxMovieTitle;
        private System.Windows.Forms.ComboBox cbxFilterTime;
        private System.Windows.Forms.Button btnFilterTime;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}