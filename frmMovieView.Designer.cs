
namespace CIS3309_TheatreGroupProject
{
    partial class frmMovieView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowUI = new System.Windows.Forms.Button();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDspInfoPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "In this form you can Add/Delete/ Edit movies. Here you can also Schedule or manag" +
    "e shows ";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(381, 74);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(75, 25);
            this.lblMovies.TabIndex = 1;
            this.lblMovies.Text = "Movies";
            // 
            // dgvMovie
            // 
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Location = new System.Drawing.Point(43, 111);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.RowHeadersWidth = 72;
            this.dgvMovie.RowTemplate.Height = 31;
            this.dgvMovie.Size = new System.Drawing.Size(844, 444);
            this.dgvMovie.TabIndex = 3;
            this.dgvMovie.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Delete a Movie, double click the row, then the button. \r\nTo Edit, Make the chn" +
    "ge directly in the Field ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(39, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(343, 56);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(343, 56);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(948, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(343, 56);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowUI
            // 
            this.btnShowUI.Location = new System.Drawing.Point(948, 437);
            this.btnShowUI.Name = "btnShowUI";
            this.btnShowUI.Size = new System.Drawing.Size(343, 56);
            this.btnShowUI.TabIndex = 8;
            this.btnShowUI.Text = "View Shows";
            this.btnShowUI.UseVisualStyleBackColor = true;
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Location = new System.Drawing.Point(39, 16);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(121, 32);
            this.cbxGenre.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(166, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(216, 56);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter By Genre";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(43, 561);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 56);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh/ Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbxGenre);
            this.panel1.Location = new System.Drawing.Point(909, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 245);
            this.panel1.TabIndex = 12;
            // 
            // btnDspInfoPage
            // 
            this.btnDspInfoPage.Location = new System.Drawing.Point(948, 375);
            this.btnDspInfoPage.Name = "btnDspInfoPage";
            this.btnDspInfoPage.Size = new System.Drawing.Size(343, 56);
            this.btnDspInfoPage.TabIndex = 11;
            this.btnDspInfoPage.Text = "Display Info Page";
            this.btnDspInfoPage.UseVisualStyleBackColor = true;
            this.btnDspInfoPage.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 636);
            this.Controls.Add(this.btnDspInfoPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnShowUI);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMovie);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.label1);
            this.Name = "frmMovieView";
            this.Text = "frmMovieView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowUI;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDspInfoPage;
    }
}