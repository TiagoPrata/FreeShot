using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreeShot
{
    public partial class FocusArea : PictureBox
    {
        public FocusArea()
        {
            InitializeComponent();
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox4);
            this.Controls.Add(pictureBox5);
            this.Controls.Add(pictureBox6);
            this.Controls.Add(pictureBox7);
            this.Controls.Add(pictureBox8);
        }

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

        private PictureBox pictureBox1 = new PictureBox();
        private PictureBox pictureBox2 = new PictureBox();
        private PictureBox pictureBox3 = new PictureBox();
        private PictureBox pictureBox4 = new PictureBox();
        private PictureBox pictureBox5 = new PictureBox();
        private PictureBox pictureBox6 = new PictureBox();
        private PictureBox pictureBox7 = new PictureBox();
        private PictureBox pictureBox8 = new PictureBox();

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Width += e.X;
                if (this.Width < borderSize)
                {
                    this.Width = borderSize;
                }
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Height += e.Y;
                if (this.Height < borderSize)
                {
                    this.Height = borderSize;
                }
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Width += e.X;
                this.Height += e.Y;
                if (this.Width < borderSize)
                {
                    this.Width = borderSize;
                }
                if (this.Height < borderSize)
                {
                    this.Height = borderSize;
                }
            }
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = this.Location.X + e.X;
                int newY = this.Location.Y;
                this.Width -= e.X;
                this.Location = new Point(newX, newY);
                if (this.Width < borderSize)
                {
                    this.Width = borderSize;
                }
            }
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = this.Location.X;
                int newY = this.Location.Y + e.Y;
                this.Height -= e.Y;
                this.Location = new Point(newX, newY);
                if (this.Height < borderSize)
                {
                    this.Height = borderSize;
                }
            }
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = this.Location.X + e.X;
                int newY = this.Location.Y;
                this.Location = new Point(newX, newY);
                this.Width -= e.X;
                this.Height += e.Y;
                if (this.Width < borderSize)
                {
                    this.Width = borderSize;
                }
                if (this.Height < borderSize)
                {
                    this.Height = borderSize;
                }
            }
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = this.Location.X + e.X;
                int newY = this.Location.Y + e.Y;
                this.Location = new Point(newX, newY);
                this.Width -= e.X;
                this.Height -= e.Y;
                if (this.Width < borderSize)
                {
                    this.Width = borderSize;
                }
                if (this.Height < borderSize)
                {
                    this.Height = borderSize;
                }
            }
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = this.Location.X;
                int newY = this.Location.Y + e.Y;
                this.Location = new Point(newX, newY);
                this.Width += e.X;
                this.Height -= e.Y;
                if (this.Width < borderSize)
                {
                    this.Width = borderSize;
                }
                if (this.Height < borderSize)
                {
                    this.Height = borderSize;
                }
            }
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            // creating cropped area
            var holeLocX = this.Location.X + borderSize;
            var holeLocY = this.Location.Y + borderSize;
            var holeSizeW = this.Size.Width - 2 * borderSize;
            var holeSizeH = this.Size.Height - 2 * borderSize;
            var thisRegion = new Region(this.ClientRectangle);
            thisRegion.Exclude(new Rectangle(3, 3, holeSizeW, holeSizeH));
            this.Region = thisRegion;

            if (this.Parent != null)
            {
                var parentRegion = new Region(this.Parent.ClientRectangle);
                parentRegion.Exclude(new Rectangle(holeLocX, holeLocY, holeSizeW, holeSizeH));
                this.Parent.Region = parentRegion;
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            // removing cropped area
            if (!this.Visible)
            {
                var thisRegion = new Region(this.ClientRectangle);
                thisRegion.Exclude(new Rectangle(0,0,0,0));
                this.Region = thisRegion;

                if (this.Parent != null)
                {
                    var parentRegion = new Region(this.Parent.ClientRectangle);
                    parentRegion.Exclude(new Rectangle(0,0,0,0));
                    this.Parent.Region = parentRegion;
                }
            }
        }

        public Bitmap GetFocusAreaImage()
        {
            if (this.Parent == null) return null;

            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(Parent.Location.X + this.Location.X, Parent.Location.Y + this.Location.Y, 0, 0, bitmap.Size);

            return bitmap;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {

        }

        public int GetClientWidth()
        {
            return this.Width - FocusArea.BorderSize;
        }

        public int GetClientHeight()
        {
            return this.Height - FocusArea.BorderSize;
        }

        public Size GetClientSize()
        {
            return new Size(this.GetClientWidth(), this.GetClientHeight());
        }

        public void SetClientWidth(int width)
        {
            this.Width = width + FocusArea.BorderSize;
        }

        public void SetClientHeight(int height)
        {
            this.Height = height + FocusArea.BorderSize;
        }

        public void SetClientSize(Size size)
        {
            this.SetClientWidth(size.Width);
            this.SetClientHeight(size.Height);
        }
    }
}
