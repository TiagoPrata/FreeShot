using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeatingShot
{
    public static class PathExtensions
    {
        public static void MakeHole(this Control cntrl, Rectangle xrect)
        {
            var region = new Region(cntrl.ClientRectangle);
            region.Exclude(xrect);

            cntrl.Region = region;
        }

        public static void MakeHoleCenteredProportional(this Control cntrl, int scaleX, int scaleY)
        {
            var rect = new Rectangle();
            rect.Size = cntrl.ClientRectangle.Size;
            Region region = new Region(rect);

            rect.Inflate(cntrl.Width / (scaleX * -2), cntrl.Height / (scaleY * -2));

            region.Exclude(rect);

            cntrl.Region = region;
        }
    }
}
