
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxMovieTitle = new System.Windows.Forms.ComboBox();
            this.cbxFilterTime = new System.Windows.Forms.ComboBox();
            this.btnFilterTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShows
            // 
            this.dgvShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShows.Location = new System.Drawing.Point(27, 24);
            this.dgvShows.Name = "dgvShows";
            this.dgvShows.RowHeadersWidth = 72;
            this.dgvShows.RowTemplate.Height = 31;
            this.dgvShows.Size = new System.Drawing.Size(1901, 336);
            this.dgvShows.TabIndex = 0;
            this.dgvShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(526, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 55);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "Filter By Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(372, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Show";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxMovieTitle
            // 
            this.cbxMovieTitle.FormattingEnabled = true;
            this.cbxMovieTitle.Location = new System.Drawing.Point(23, 387);
            this.cbxMovieTitle.Name = "cbxMovieTitle";
            this.cbxMovieTitle.Size = new System.Drawing.Size(168, 32);
            this.cbxMovieTitle.TabIndex = 6;
            // 
            // cbxFilterTime
            // 
            this.cbxFilterTime.FormattingEnabled = true;
            this.cbxFilterTime.Location = new System.Drawing.Point(23, 451);
            this.cbxFilterTime.Name = "cbxFilterTime";
            this.cbxFilterTime.Size = new System.Drawing.Size(168, 32);
            this.cbxFilterTime.TabIndex = 7;
            // 
            // btnFilterTime
            // 
            this.btnFilterTime.Location = new System.Drawing.Point(197, 439);
            this.btnFilterTime.Name = "btnFilterTime";
            this.btnFilterTime.Size = new System.Drawing.Size(169, 55);
            this.btnFilterTime.TabIndex = 8;
            this.btnFilterTime.Text = "Filter By Time";
            this.btnFilterTime.UseVisualStyleBackColor = true;
            // 
            // frmShowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 725);
            this.Controls.Add(this.btnFilterTime);
            this.Controls.Add(this.cbxFilterTime);
            this.Controls.Add(this.cbxMovieTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvShows);
            this.Name = "frmShowView";
            this.Text = "frmShowView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShows;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxMovieTitle;
        private System.Windows.Forms.ComboBox cbxFilterTime;
        private System.Windows.Forms.Button btnFilterTime;
    }
}