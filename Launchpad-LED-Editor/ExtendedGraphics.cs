using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Midi;
using System.Drawing.Drawing2D;

namespace Launchpad_LED_Editor
{
    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return createParams;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Nothing in here, cause we dont want Background Painting..
        }
    }

    public class Gfx
    {
        public static void RotateRect(Graphics g, Rectangle r, float angle, Color color)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2), r.Top + (r.Height / 2)));
                g.Transform = m;
                SolidBrush br = new SolidBrush(color);
                g.FillRectangle(br, r);

                g.ResetTransform();
            }
        }
    }
}