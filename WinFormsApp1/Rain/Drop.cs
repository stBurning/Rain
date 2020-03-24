using System;
using System.Drawing;
using System.Threading;


namespace Rain{
    public class Drop : Animatable{
        private int _width;
        private int _height;
        private int _dx;
        private readonly int _dy;
        private readonly int _r;
        private static Random _rand;
        private static Brush _brush;

        public Drop(Rectangle rectangle) : base(rectangle) {
            _brush = new SolidBrush(Color.Aqua);
            _dx = Form1.WindPower;
            _dy = 15;
            _width = rectangle.Width;
            _height = rectangle.Height;
            if (_rand == null) _rand = new Random();
            X = _rand.Next(0, _width);
            Y = 0;
            _r = 6;
            
        }
        public override void Draw(Graphics graphics) {
            graphics.FillEllipse(_brush, X, Y, 2*_r, 2*_r);
            graphics.FillPie(_brush, X-_r, Y-3*_r, 4*_r, 4*_r,60, 60);
        }

        public override void Update(Rectangle rectangle) {
            _width = rectangle.Width;
            _height = rectangle.Height;
            _dx = Form1.WindPower;
        }
        protected override void Move() {
            while(!_stop && Y < _height) {
                Thread.Sleep(10);
                Y += _dy;
                if (_dx == 0) continue;
                X += _dx;
                if (X < 0) { X = _width - 1; }
                if (X > _width) { X = 1; }
            }
        }
    }
}