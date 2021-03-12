using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeatingShot
{
    public partial class frmShadow : Form
    {
        public frmShadow()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            //WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.None;
        }

        public delegate void NewFocusAreaCreatedHandler(object sender);

        public event NewFocusAreaCreatedHandler OnNewFocusAreaCreated;

        private void frmShadow_Load(object sender, EventArgs e)
        {
            
        }

        private void frmShadow_MouseDown(object sender, MouseEventArgs e)
        {
            // Clean cropped rectangle
            var region = new Region(this.ClientRectangle);
            region.Exclude(new Rectangle(0,0,0,0));
            this.Region = region;

            this.focusArea1.Location = new Point(e.X, e.Y);
            this.focusArea1.Size = new Size(1, 1);
            this.focusArea1.Visible = true;

            OnNewFocusAreaCreated?.Invoke(this);
        }

        private void frmShadow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                focusArea1.Width = e.X - focusArea1.Location.X;
                focusArea1.Height = e.Y - focusArea1.Location.Y;
            }
        }

        private void frmShadow_MouseUp(object sender, MouseEventArgs e)
        {
            // Create a hole in the rectangle area below
            var holeLocX = focusArea1.Location.X + 3;
            var holeLocY = focusArea1.Location.Y + 3;
            var holeSizeW = focusArea1.Size.Width - 6;
            var holeSizeH = focusArea1.Size.Height - 6;
            var region = new Region(this.ClientRectangle);
            region.Exclude(new Rectangle(holeLocX,holeLocY,holeSizeW,holeSizeH));
            this.Region = region;
        }

        public void HideFocusAreas()
        {
            focusArea1.Visible = false;
        }
    }
}
