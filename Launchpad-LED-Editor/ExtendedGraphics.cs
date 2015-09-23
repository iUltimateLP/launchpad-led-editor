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
    
    public class circleButton : Panel
    {
        public Color c;
        int radius;
        Bitmap overlay;

        public circleButton(Color color, int radius, Bitmap overlay)
        {
            this.c = color;
            this.radius = radius;
            this.overlay = overlay;
        }

        public void updateThings()
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.CompositingQuality = CompositingQuality.GammaCorrected;
            SolidBrush br = new SolidBrush(c);
            graphics.FillEllipse(br, 0, 0, radius * 2, radius * 2);
            br.Dispose();
            if (overlay != null)
            {
                TextureBrush br2 = new TextureBrush(overlay);

                //SolidBrush br2 = new SolidBrush(Color.FromArgb(1, 255, 255, 255));
                //graphics.FillEllipse(br2, 0, 0, radius * 2, radius * 2);
                //br2.Dispose();

                System.Drawing.Imaging.ImageAttributes attr = new System.Drawing.Imaging.ImageAttributes();

                graphics.DrawImage(overlay, new Rectangle(0, 0, radius*2, radius*2), 0, 0, overlay.Width, overlay.Height, GraphicsUnit.Pixel, attr);
            }
        }
    }
}