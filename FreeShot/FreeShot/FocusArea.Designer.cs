
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FreeShot
{
    partial class FocusArea
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.pictureBox1.BackColor = borderColor;
            this.pictureBox1.Cursor = Cursors.SizeWE;
            this.pictureBox1.Location = new Point(this.GetClientWidth(), borderSize);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(borderSize, this.GetClientHeight() - borderSize);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox1.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pictureBox2.BackColor = borderColor;
            this.pictureBox2.Cursor = Cursors.SizeNS;
            this.pictureBox2.Location = new Point(borderSize, this.GetClientHeight());
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(this.GetClientWidth() - borderSize, borderSize);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox2.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.pictureBox3.BackColor = borderColor;
            this.pictureBox3.Cursor = Cursors.SizeNWSE;
            this.pictureBox3.Location = new Point(this.GetClientWidth(), this.GetClientHeight());
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(borderSize, borderSize);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseMove += new MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox3.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.pictureBox4.BackColor = borderColor;
            this.pictureBox4.Cursor = Cursors.SizeWE;
            this.pictureBox4.Location = new Point(0, borderSize);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(borderSize, this.GetClientHeight() - borderSize);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseMove += new MouseEventHandler(this.pictureBox4_MouseMove);
            this.pictureBox4.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox4.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pictureBox5.BackColor = borderColor;
            this.pictureBox5.Cursor = Cursors.SizeNS;
            this.pictureBox5.Location = new Point(borderSize, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(this.GetClientWidth() - borderSize, borderSize);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseMove += new MouseEventHandler(this.pictureBox5_MouseMove);
            this.pictureBox5.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox5.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.pictureBox6.BackColor = borderColor;
            this.pictureBox6.Cursor = Cursors.SizeNESW;
            this.pictureBox6.Location = new Point(0, this.GetClientHeight());
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(borderSize, borderSize);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseMove += new MouseEventHandler(this.pictureBox6_MouseMove);
            this.pictureBox6.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox6.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.pictureBox7.BackColor = borderColor;
            this.pictureBox7.Cursor = Cursors.SizeNWSE;
            this.pictureBox7.Location = new Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Size(borderSize, borderSize);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseMove += new MouseEventHandler(this.pictureBox7_MouseMove);
            this.pictureBox7.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox7.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.pictureBox8.BackColor = borderColor;
            this.pictureBox8.Cursor = Cursors.SizeNESW;
            this.pictureBox8.Location = new Point(this.GetClientWidth(), 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new Size(borderSize, borderSize);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseMove += new MouseEventHandler(this.pictureBox8_MouseMove);
            this.pictureBox8.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox8.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
        }

        #endregion
    }
}
