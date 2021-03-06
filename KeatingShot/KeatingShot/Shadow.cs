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

            TCResize resizablePicture = new TCResize(this.pictureBox1);
        }

        private void frmShadow_Load(object sender, EventArgs e)
        {
            PathExtensions.MakeHole(this, new Rectangle(100, 100, 100, 100));

            var picture = new SizeablePictureBox 
            {
                Name = "pictureBox",
                Size = new Size(100, 100),
                Location = new Point(300, 300),
                //Image = Image.FromFile(@"C:\Users\tiago\Desktop\printscreen.jpg"),

            };
            this.Controls.Add(picture);
        }
    }
}
