
namespace FreeShot
{
    partial class frmKeyListener
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeyListener));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ctxMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FreeShot";
            this.notifyIcon1.Visible = true;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenu_About,
            this.ctxMenu_Exit});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // ctxMenu_About
            // 
            this.ctxMenu_About.Name = "ctxMenu_About";
            this.ctxMenu_About.Size = new System.Drawing.Size(107, 22);
            this.ctxMenu_About.Text = "About";
            this.ctxMenu_About.Click += new System.EventHandler(this.ctxMenu_About_Click);
            // 
            // ctxMenu_Exit
            // 
            this.ctxMenu_Exit.Name = "ctxMenu_Exit";
            this.ctxMenu_Exit.Size = new System.Drawing.Size(107, 22);
            this.ctxMenu_Exit.Text = "Exit";
            this.ctxMenu_Exit.Click += new System.EventHandler(this.ctxMenu_Exit_Click);
            // 
            // frmKeyListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(293, 229);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKeyListener";
            this.Text = "KeyListener";
            this.Load += new System.EventHandler(this.frmKeyListener_Load);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ctxMenu_About;
    }
}