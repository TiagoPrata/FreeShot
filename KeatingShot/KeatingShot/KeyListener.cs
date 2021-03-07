using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KeatingShot
{
    public partial class frmKeyListener : Form
    {
        private readonly GlobalKeyboardHook _gkh = new GlobalKeyboardHook();
        private List<frmShadow> shadowList = new List<frmShadow>();
        private List<frmPrintedImages> printedList = new List<frmPrintedImages>();

        public frmKeyListener()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.None;
        }

        protected override CreateParams CreateParams
        {
            // hidding application from alt+tab
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        private void frmKeyListener_Load(object sender, EventArgs e)
        {
            _gkh.HookedKeys.Add(Keys.PrintScreen);
            _gkh.HookedKeys.Add(Keys.Escape);

            _gkh.KeyDown += gkh_KeyDown;
            _gkh.KeyUp += gkh_KeyUp;
        }

        private void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.PrintScreen:
                    PrtScnBtnPressed();
                    break;
                case Keys.Escape:
                    ClearAndDeleteShadowForms();
                    ClearAndDeletePrintedForms();
                    break;
            }
            e.Handled = true;
        }

        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        public void PrtScnBtnPressed()
        {
            if (shadowList.Count > 0 || printedList.Count > 0) return;
            CreatePrintedForms();
            CreateShadowForms();
        }

        public void CreatePrintedForms()
        {
            foreach (var screen in Screen.AllScreens)
            {
                int last;

                Bitmap bitmap = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap as Image);
                graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, bitmap.Size);

                printedList.Add(new frmPrintedImages());
                last = printedList.Count - 1;
                printedList[last].SetNewImage(bitmap);
                printedList[last].StartPosition = FormStartPosition.Manual;
                printedList[last].SetBounds(screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height);
                printedList[last].WindowState = FormWindowState.Maximized;
                printedList[last].Show();
            }
        }

        public void ClearAndDeletePrintedForms()
        {
            foreach (var form in printedList)
            {
                form.Hide();
            }
            printedList.Clear();
        }

        public void CreateShadowForms()
        {
            foreach (var screen in Screen.AllScreens)
            {
                int last;
                shadowList.Add(new frmShadow());
                last = shadowList.Count - 1;
                shadowList[last].KeyPress += new KeyPressEventHandler(f_KeyPress);
                shadowList[last].StartPosition = FormStartPosition.Manual;
                shadowList[last].SetBounds(screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height);
                shadowList[last].WindowState = FormWindowState.Maximized;
                shadowList[last].TopMost = true;
                shadowList[last].Show();
            }
        }

        public void ClearAndDeleteShadowForms()
        {
            foreach (var form in shadowList)
            {
                form.Hide();
            }
            shadowList.Clear();
        }

        static void f_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This will exit when ANY key is pressed on ANY form
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PrtScnBtnPressed();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            PrtScnBtnPressed();
        }
    }
}
