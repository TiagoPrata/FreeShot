
namespace FreeShot
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
            this.focusArea1 = new FreeShot.FocusArea();
            ((System.ComponentModel.ISupportInitialize)(this.focusArea1)).BeginInit();
            this.SuspendLayout();
            // 
            // focusArea1
            // 
            this.focusArea1.BackColor = System.Drawing.Color.White;
            this.focusArea1.Location = new System.Drawing.Point(34, 45);
            this.focusArea1.Name = "focusArea1";
            this.focusArea1.Size = new System.Drawing.Size(123, 80);
            this.focusArea1.TabIndex = 2;
            this.focusArea1.TabStop = false;
            this.focusArea1.Visible = false;
            // 
            // frmShadow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(294, 250);
            this.Controls.Add(this.focusArea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShadow";
            this.Opacity = 0.35D;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShadow_FormClosed);
            this.Load += new System.EventHandler(this.frmShadow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmShadow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmShadow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.focusArea1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FocusArea focusArea1;
    }
}

