using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreeShot
{
    public partial class ActionBar : Form
    {
        public delegate void ButtonExitClick(object sender);

        public event ButtonExitClick OnButtonExitClick;

        public delegate void ButtonSaveClick(object sender);

        public event ButtonSaveClick OnButtonSaveClick;

        public delegate void ButtonCopyClick(object sender);

        public event ButtonCopyClick OnButtonCopyClick;

        public ActionBar()
        {
            InitializeComponent();
        }

        private void ActionBar_Load(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            int SumSizeWidth = 0;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                SumSizeWidth += (int)(item.Size.Width * 1.5);
            }
            this.Size = new Size(SumSizeWidth, toolStrip1.Size.Height);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnButtonExitClick?.Invoke(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnButtonSaveClick?.Invoke(this);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            OnButtonCopyClick?.Invoke(this);
        }
    }
}
