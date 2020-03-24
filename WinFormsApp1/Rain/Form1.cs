using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Rain{
    public partial class Form1 : Form{
        private readonly Animator _animator;
        private bool _stop = true;
        private Thread _t;
        public static int WindPower { get; private set; }
        public Form1() {
            InitializeComponent();
            _animator = new Animator(panel1.CreateGraphics(), panel1.ClientRectangle);
            WindPower = trackBarPower.Value;
        }

        private new void Move() {
            while (!_stop) {
                Thread.Sleep(0);
                if(!_stop) _animator.Start(new Drop(new Rectangle(0, 0, Width, Height)));
            }
        }

        private void panelMain_Resize(object sender, EventArgs e) {
            if (this.WindowState != FormWindowState.Minimized) {
                _animator?.Update(panel1.CreateGraphics(), panel1.ClientRectangle);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Stop();
        }

        private void panelMain_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) { Stop(); }
            else if (e.Button == MouseButtons.Left) { Start(); }
        }

        private void Start() {
            if (_t == null || !_t.IsAlive) {
                _stop = false;
                ThreadStart th = Move;
                _t = new Thread(th);
                _t.Start();
            }
        }

        private void Stop() {
            _stop = true;
            _animator.Stop();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (button1.Text == @"Start") {
                button1.Text = @"Stop";
                Start();
            } else {
                button1.Text = @"Start";
                Stop();
            }
        }
        
        private void trackBarPower_Scroll(object sender, EventArgs e) {
            WindPower = trackBarPower.Value;
            _animator?.Update(panel1.CreateGraphics(), panel1.ClientRectangle);
        }
    }
}
