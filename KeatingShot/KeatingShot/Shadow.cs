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

        public void HideFocusAreas()
        {
            focusArea1.Visible = false;
        }
    }
}
