using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleDrow
{
    internal class Pie
    {
        Form form;

        Bitmap pieBitmap;

        public Point Position { get; set; }

        public Pie(Form form, Point position)
        {
            this.form = form;
            Position = position;

            pieBitmap = new Bitmap(Properties.Resources.pie2);

            // タイマーの生成
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Update;

            // タイマーを開始
            timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            int x = Position.X;
            x += 10;
            Position = new Point(x, Position.Y);

            if (Position.X > 300)
            {
                x = 0;
                Position = new Point(x, Position.Y);
            }

            form.Invalidate();
        }

        public void OnPaint(PaintEventArgs e)
        {
            Graphics formGraph = form.CreateGraphics();
            pieBitmap.SetResolution(formGraph.DpiX, formGraph.DpiY);

            e.Graphics.DrawImage(pieBitmap, Position);
        }
    }
}