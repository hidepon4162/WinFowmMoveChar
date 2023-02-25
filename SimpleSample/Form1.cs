
using GraphClassLibrary;

namespace SimpleSample
{
    public partial class Form1 : Form
    {
        GraphPicture pie;

        public Form1()
        {
            InitializeComponent();

            // ŠŠ‚ç‚©‚É•`‰æ‚·‚é‚½‚ß
            DoubleBuffered = true;

            var bitmap = Properties.Resources.food_goon_pad_pong_curry;
            var position = new Point(0, 0);

            pie = new GraphPicture(this, bitmap, position);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            pie.OnPaint(e);
        }
    }
}