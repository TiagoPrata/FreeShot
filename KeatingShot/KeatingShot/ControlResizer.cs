using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeatingShot
{
    internal static class ControlExtension
    {
        public static int GetClientWidth(this Control theControl)
        {
            return theControl.Width - ControlResizer.BorderSize;
        }

        public static int GetClientHeight(this Control theControl)
        {
            return theControl.Height - ControlResizer.BorderSize;
        }

        public static Size GetClientSize(this Control theControl)
        {
            return new Size(theControl.GetClientWidth(), theControl.GetClientHeight());
        }

        public static void SetClientWidth(this Control theControl, int width)
        {
            theControl.Width = width + ControlResizer.BorderSize;
        }

        public static void SetClientHeight(this Control theControl, int height)
        {
            theControl.Height = height + ControlResizer.BorderSize;
        }

        public static void SetClientSize(this Control theControl, Size size)
        {
            theControl.SetClientWidth(size.Width);
            theControl.SetClientHeight(size.Height);
        }
    }

    public class ControlResizer
    {
        Control controltobeResized;
        static readonly int borderSize = 3;
        static readonly Color borderColor = Color.DarkGray;
        public static int BorderSize
        {
            get { return borderSize; }
        }
        public static Color BorderColor
        {
            get { return BorderColor; }
        }


        public ControlResizer(Control theControl)
        {
            controltobeResized = theControl;
            InitializeComponent();
            controltobeResized.Controls.Add(pictureBox1);
            controltobeResized.Controls.Add(pictureBox2);
            controltobeResized.Controls.Add(pictureBox3);
            controltobeResized.Controls.Add(pictureBox4);
            controltobeResized.Controls.Add(pictureBox5);
            controltobeResized.Controls.Add(pictureBox6);
            controltobeResized.Controls.Add(pictureBox7);
            controltobeResized.Controls.Add(pictureBox8);
        }

        private PictureBox pictureBox1 = new PictureBox();
        private PictureBox pictureBox2 = new PictureBox();
        private PictureBox pictureBox3 = new PictureBox();
        private PictureBox pictureBox4 = new PictureBox();
        private PictureBox pictureBox5 = new PictureBox();
        private PictureBox pictureBox6 = new PictureBox();
        private PictureBox pictureBox7 = new PictureBox();
        private PictureBox pictureBox8 = new PictureBox();


        private void InitializeComponent()
        {
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.pictureBox1.BackColor = borderColor;
            this.pictureBox1.Cursor = Cursors.SizeWE;
            this.pictureBox1.Location = new Point(controltobeResized.GetClientWidth(), borderSize);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(borderSize, controltobeResized.GetClientHeight() - borderSize);
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
            this.pictureBox2.Location = new Point(borderSize, controltobeResized.GetClientHeight());
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(controltobeResized.GetClientWidth() - borderSize, borderSize);
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
            this.pictureBox3.Location = new Point(controltobeResized.GetClientWidth(), controltobeResized.GetClientHeight());
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
            this.pictureBox4.Size = new Size(borderSize, controltobeResized.GetClientHeight() - borderSize);
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
            this.pictureBox5.Size = new Size(controltobeResized.GetClientWidth() - borderSize, borderSize);
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
            this.pictureBox6.Location = new Point(0, controltobeResized.GetClientHeight());
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
            this.pictureBox8.Location = new Point(controltobeResized.GetClientWidth(), 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new Size(borderSize, borderSize);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseMove += new MouseEventHandler(this.pictureBox8_MouseMove);
            this.pictureBox8.MouseLeave += new EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox8.MouseEnter += new EventHandler(this.pictureBox_MouseEnter);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                controltobeResized.Width += e.X;
                if (controltobeResized.Width < borderSize)
                {
                    controltobeResized.Width = borderSize;
                }
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                controltobeResized.Height += e.Y;
                if (controltobeResized.Height < borderSize)
                {
                    controltobeResized.Height = borderSize;
                }
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                controltobeResized.Width += e.X;
                controltobeResized.Height += e.Y;
                if (controltobeResized.Width < borderSize)
                {
                    controltobeResized.Width = borderSize;
                }
                if (controltobeResized.Height < borderSize)
                {
                    controltobeResized.Height = borderSize;
                }
            }
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = controltobeResized.Location.X + e.X;
                int newY = controltobeResized.Location.Y;
                controltobeResized.Width -= e.X;
                controltobeResized.Location = new Point(newX, newY);
                if (controltobeResized.Width < borderSize)
                {
                    controltobeResized.Width = borderSize;
                }
            }
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = controltobeResized.Location.X;
                int newY = controltobeResized.Location.Y + e.Y;
                controltobeResized.Height -= e.Y;
                controltobeResized.Location = new Point(newX, newY);
                if (controltobeResized.Height < borderSize)
                {
                    controltobeResized.Height = borderSize;
                }
            }
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = controltobeResized.Location.X + e.X;
                int newY = controltobeResized.Location.Y;
                controltobeResized.Location = new Point(newX, newY);
                controltobeResized.Width -= e.X;
                controltobeResized.Height += e.Y;
                if (controltobeResized.Width < borderSize)
                {
                    controltobeResized.Width = borderSize;
                }
                if (controltobeResized.Height < borderSize)
                {
                    controltobeResized.Height = borderSize;
                }
            }
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = controltobeResized.Location.X + e.X;
                int newY = controltobeResized.Location.Y + e.Y;
                controltobeResized.Location = new Point(newX, newY);
                controltobeResized.Width -= e.X;
                controltobeResized.Height -= e.Y;
                if (controltobeResized.Width < borderSize)
                {
                    controltobeResized.Width = borderSize;
                }
                if (controltobeResized.Height < borderSize)
                {
                    controltobeResized.Height = borderSize;
                }
            }
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = controltobeResized.Location.X;
                int newY = controltobeResized.Location.Y + e.Y;
                controltobeResized.Location = new Point(newX, newY);
                controltobeResized.Width += e.X;
                controltobeResized.Height -= e.Y;
                if (controltobeResized.Width < borderSize)
                {
                    controltobeResized.Width = borderSize;
                }
                if (controltobeResized.Height < borderSize)
                {
                    controltobeResized.Height = borderSize;
                }
            }
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
