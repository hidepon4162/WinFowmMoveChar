using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleDrow
{
    public partial class Form1 : Form
    {
        Pie pie;

        public Form1()
        {
            InitializeComponent();

            // 滑らかに描画するため
            DoubleBuffered = true;

            Point position = new Point(0, 0);
            pie = new Pie(this, position);

            // タイマーの生成
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Update;

            // タイマーを開始
            timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            int x = pie.Position.X;
            x += 10;
            pie.Position = new Point(x, pie.Position.Y);

            if (pie.Position.X > 300)
            {
                x = 0;
                pie.Position = new Point(x, pie.Position.Y);
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            pie.OnPaint(e);
        }
    }
}