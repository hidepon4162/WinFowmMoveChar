using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleDrow
{
    public partial class Form1 : Form
    {
        GraphPicture pie;

        public Form1()
        {
            InitializeComponent();

            // 滑らかに描画するため
            DoubleBuffered = true;

            var position = new Point(0, 0);
            var bitmap = Properties.Resources.pie2;
            pie = new GraphPicture(this, bitmap, position);

            // タイマーの生成
            var timer = new Timer
            {
                Interval = 100
            };

            timer.Tick += Update;

            // タイマーを開始
            timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            var x = pie.Position.X;
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