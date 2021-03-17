using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FreeShot
{
    public partial class frmShadow : Form
    {
        private int mouseOnClickPositionX;
        private int mouseOnClickPositionY;
        private SizeTooltip sizeTooltip = new SizeTooltip();

        public frmShadow()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            //WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.None;
        }

        public delegate void NewFocusAreaCreatedHandler(object sender);

        public event NewFocusAreaCreatedHandler OnNewFocusAreaCreated;

        private void frmShadow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOnClickPositionX = e.X;
            mouseOnClickPositionY = e.Y;

            this.focusArea1.Location = new Point(e.X, e.Y);
            this.focusArea1.Size = new Size(1, 1);
            this.focusArea1.Visible = true;

            sizeTooltip.Show();
            sizeTooltip.Location = new Point(e.X + this.Location.X, e.Y + this.Location.Y - 18);
            sizeTooltip.TopMost = true;

            OnNewFocusAreaCreated?.Invoke(this);
        }

        private void frmShadow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GetMouseXDirection(e) == ArrowDirection.Right && GetMouseYDirection(e) == ArrowDirection.Down)
                {
                    focusArea1.Width = e.X - focusArea1.Location.X;
                    focusArea1.Height = e.Y - focusArea1.Location.Y;
                }
                if (GetMouseXDirection(e) == ArrowDirection.Left && GetMouseYDirection(e) == ArrowDirection.Down)
                {
                    focusArea1.Location = new Point(e.X, focusArea1.Location.Y);
                    focusArea1.Width = mouseOnClickPositionX - focusArea1.Location.X;
                    focusArea1.Height = e.Y - focusArea1.Location.Y;
                }
                if (GetMouseXDirection(e) == ArrowDirection.Left && GetMouseYDirection(e) == ArrowDirection.Up)
                {
                    focusArea1.Location = new Point(e.X, e.Y);
                    focusArea1.Width = mouseOnClickPositionX - focusArea1.Location.X;
                    focusArea1.Height = mouseOnClickPositionY - focusArea1.Location.Y;
                }
                if (GetMouseXDirection(e) == ArrowDirection.Right && GetMouseYDirection(e) == ArrowDirection.Up)
                {
                    focusArea1.Location = new Point(focusArea1.Location.X, e.Y);
                    focusArea1.Width = e.X - focusArea1.Location.X;
                    focusArea1.Height = mouseOnClickPositionY - focusArea1.Location.Y;
                }
                sizeTooltip.UpdateLabelText(focusArea1.Size);
                sizeTooltip.Location = new Point(focusArea1.Location.X + this.Location.X, focusArea1.Location.Y + this.Location.Y - 18);
            }
        }

        public void HideFocusAreas()
        {
            focusArea1.Visible = false;
            sizeTooltip.Visible = false;
        }

        public ArrowDirection GetMouseXDirection(MouseEventArgs e)
        {
            ArrowDirection direction;

            double deltaDirection = mouseOnClickPositionX - e.X;
            direction = deltaDirection > 0 ? ArrowDirection.Left : ArrowDirection.Right;
            
            return direction;
        }

        public ArrowDirection GetMouseYDirection(MouseEventArgs e)
        {
            ArrowDirection direction;

            double deltaDirection = mouseOnClickPositionY - e.Y;
            direction = deltaDirection > 0 ? ArrowDirection.Up : ArrowDirection.Down;
            
            return direction;
        }

        private void frmShadow_FormClosed(object sender, FormClosedEventArgs e)
        {
            HideFocusAreas();
            System.GC.Collect();
        }
    }
}
