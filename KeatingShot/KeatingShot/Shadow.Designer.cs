
namespace KeatingShot
{
    partial class frmShadow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.focusArea = new System.Windows.Forms.PictureBox();
            this.focusAreaLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.focusArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusAreaLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // focusArea
            // 
            this.focusArea.BackColor = System.Drawing.Color.White;
            this.focusArea.Location = new System.Drawing.Point(12, 12);
            this.focusArea.Name = "focusArea";
            this.focusArea.Size = new System.Drawing.Size(100, 50);
            this.focusArea.TabIndex = 0;
            this.focusArea.TabStop = false;
            this.focusArea.Visible = false;
            // 
            // focusAreaLoading
            // 
            this.focusAreaLoading.BackColor = System.Drawing.Color.White;
            this.focusAreaLoading.Location = new System.Drawing.Point(12, 85);
            this.focusAreaLoading.Name = "focusAreaLoading";
            this.focusAreaLoading.Size = new System.Drawing.Size(100, 50);
            this.focusAreaLoading.TabIndex = 1;
            this.focusAreaLoading.TabStop = false;
            this.focusAreaLoading.Visible = false;
            // 
            // frmShadow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(294, 250);
            this.Controls.Add(this.focusAreaLoading);
            this.Controls.Add(this.focusArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShadow";
            this.Opacity = 0.05D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmShadow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmShadow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmShadow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmShadow_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.focusArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focusAreaLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox focusArea;
        private System.Windows.Forms.PictureBox focusAreaLoading;
    }
}

