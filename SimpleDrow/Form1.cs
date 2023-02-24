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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            pie.OnPaint(e);
        }
    }
}