using System.Drawing;
using System.Windows.Forms;

namespace SimpleDrow
{
    internal class Pie
    {
        Form form;

        public Point Position { get; set; }
        public Bitmap PieBitmap { get; }

        public Pie(Form form, Point position)
        {
            this.form = form;
            Position = position;

            PieBitmap = new Bitmap(Properties.Resources.pie2);
        }

        public void OnPaint(PaintEventArgs e)
        {
            Graphics formGraph = form.CreateGraphics();
            PieBitmap.SetResolution(formGraph.DpiX, formGraph.DpiY);

            e.Graphics.DrawImage(PieBitmap, Position);
        }
    }
}