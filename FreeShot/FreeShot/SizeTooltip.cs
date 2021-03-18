using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreeShot
{
    public partial class SizeTooltip : Form
    {
        public SizeTooltip()
        {
            InitializeComponent();
        }

        public void UpdateLabelText(Size size)
        {
            lblSize.Text = (size.Width + "; " + size.Height);
        }
    }
}
