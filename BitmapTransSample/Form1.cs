using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitmapTransSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0;
        int y = 0;

        Bitmap bitmap1;
        Bitmap bitmap2;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics FormG = this.CreateGraphics();
            bitmap2.SetResolution(FormG.DpiX, FormG.DpiY);

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    e.Graphics.DrawImage(bitmap1, x * 100, y * 100);
                }
            }

            e.Graphics.DrawImage(bitmap2, x, 0);
            e.Graphics.DrawImage(bitmap2, x * 1.2f, 100);
            e.Graphics.DrawImage(bitmap2, x * 1.5f, 200);

            e.Graphics.DrawImage(bitmap2, 100, y * 1.2f);
            e.Graphics.DrawImage(bitmap2, 150, y * 1.7f);
            e.Graphics.DrawImage(bitmap2, 200, y * 2.0f);

            e.Graphics.DrawImage(bitmap2, x * 1.2f, y * 1.2f);
            e.Graphics.DrawImage(bitmap2, x * 1.7f, y * 1.7f);
            e.Graphics.DrawImage(bitmap2, x * 1.7f, y * 2.0f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bitmap1 = new Bitmap(Properties.Resources.pie1);
            bitmap2 = new Bitmap(Properties.Resources.pie2);

            // タイマーの生成
            Timer timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Update;

            // タイマーを開始
            timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            if (x > 300)
            {
                x = 0;
            }
            if (y > 300)
            {
                y = 0;
            }
            x += 10;
            y += 10;

            Invalidate();
        }
    }
}
