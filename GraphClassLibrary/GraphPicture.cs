using System.Drawing;
using System.Windows.Forms;

namespace GraphClassLibrary
{
    public class GraphPicture
    {
        Control baseControl;

        public Point Position { get; set; }
        public Bitmap Bitmap { get; }

        public GraphPicture(Control baseControl, Bitmap bitmap, Point position)
        {
            this.baseControl = baseControl;
            Position = position;
            Bitmap = new Bitmap(bitmap);
        }

        public void OnPaint(PaintEventArgs e)
        {
            var formGraph = baseControl.CreateGraphics();
            Bitmap.SetResolution(formGraph.DpiX, formGraph.DpiY);

            e.Graphics.DrawImage(Bitmap, Position);
        }
    }
}