using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEmblemzavdannya
{
    class CEmblem
    {
        const int DefaultSize = 100;
        private Graphics graphics;
        private int size;
        public int X { get; set; }
        public int Y { get; set; }
        public int Size
        {
            get => size;
            set
            {
                if (value > 200) size = 200;
                else if (value < 10) size = 10;
                else size = value;
            }
        }
        public CEmblem(Graphics graphics, int x, int y)
        {
            this.graphics = graphics;
            this.X = x;
            this.Y = y;
            this.Size = DefaultSize;
        }
        public CEmblem(Graphics graphics, int x, int y, int size)
        {
            this.graphics = graphics;
            this.X = x;
            this.Y = y;
            this.Size = size;
        }
        private void Draw(Pen pen)
        {
            float half = Size / 2f;
            graphics.DrawEllipse(pen, X - half, Y - half, Size, Size);
            PointF[] square = new PointF[4];
            for (int i = 0; i < 4; i++)
            {
                float angle = (float)((Math.PI / 2) * i - Math.PI / 4);
                square[i] = new PointF(X + half * (float)Math.Cos(angle), Y + half * (float)Math.Sin(angle));
            }
            graphics.DrawPolygon(pen, square);
            PointF[] innerSquare = new PointF[4];
            for (int i = 0; i < 4; i++)

            {
                float angle = (float)((Math.PI / 2) * i);
                innerSquare[i] = new PointF(X + half / (float)Math.Sqrt(2) * (float)Math.Cos(angle), Y + half / (float)Math.Sqrt(2) * (float)Math.Sin(angle));
            }
            graphics.DrawPolygon(pen, innerSquare);
            for (int i = 0; i < 4; i++)
            {
                PointF a = square[i];
                PointF b = square[(i + 1) % 4];
                PointF mid = new PointF((a.X + b.X) / 2, (a.Y + b.Y) / 2);
                PointF center = innerSquare[i];
                graphics.DrawPolygon(pen, new PointF[] { a, b, center });
            }
        }
        public void Show()
        {
            Draw(Pens.Red);
        }
        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand(int dSize = 5)
        {
            Hide();
            Size = Size + dSize;
            Show();
        }
        public void Collapse(int dSize = 5)
        {
            Hide();
            Size = Size - dSize;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}
