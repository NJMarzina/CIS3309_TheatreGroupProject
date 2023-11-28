
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
            this.btnEmployeeSignin = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeSignin
            // 
            this.btnEmployeeSignin.Location = new System.Drawing.Point(170, 175);
            this.btnEmployeeSignin.Name = "btnEmployeeSignin";
            this.btnEmployeeSignin.Size = new System.Drawing.Size(162, 67);
            this.btnEmployeeSignin.TabIndex = 0;
            this.btnEmployeeSignin.Text = "Employee Sign-in";
            this.btnEmployeeSignin.UseVisualStyleBackColor = true;
            this.btnEmployeeSignin.Click += new System.EventHandler(this.btnEmployeeSignin_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(426, 175);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(162, 67);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Movies";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnEmployeeSignin);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeSignin;
        private System.Windows.Forms.Button btnView;
    }
}

