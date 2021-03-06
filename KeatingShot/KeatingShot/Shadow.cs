using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            ControlResizer resizablePicture = new ControlResizer(this.pictureBox1);
        }

        private void frmShadow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
