using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Audio_Organiser
{
    public class Kontrolka : Panel
    {
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }

        public int GradientRadius { get; set; }

        protected override void OnPaint(PaintEventArgs ev)
        {
            GradientRadius = 55;
            LinearGradientBrush someGradientBrush = new LinearGradientBrush(ClientRectangle, Color1, Color2, GradientRadius);
            Graphics grp = ev.Graphics;
            grp.FillRectangle(someGradientBrush, ClientRectangle);
            base.OnPaint(ev);
        }
    }
}