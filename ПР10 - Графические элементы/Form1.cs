using System;
using System.Drawing;
using System.Drawing.Imaging;
namespace ПР10
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);
        bool _RectangeClicked = false, _CircleClicked = false, _SquareClicked = false;
        int recX = 0, recY = 0, cirX = 0, cirY = 0, sqrX = 0, sqrY = 0;

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _RectangeClicked = false;
            _CircleClicked = false;
            _SquareClicked = false;
            int x, y, dx, dy;
            int lastClicked = 0;

            if (lastClicked == 2)
            {
                if((label3.Location.X < Circle.X + Circle.Width) && (label3.Location.X > Circle.X))
                {
                    if ((label3.Location.Y < Circle.Y + Circle.Height) && (label3.Location.Y > Circle.Y)) 
                    {
                        x = Circle.X;
                        y = Circle.Y;
                        dx = cirX;
                        dy = cirY;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        cirX = sqrX;
                        cirY = sqrY;

                        Square.X = x;
                        Square.Y = y;
                        sqrX = dx;
                        sqrY = dy;
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_RectangeClicked)
            {
                Rectangle.X = e.X - recX;
                Rectangle.Y = e.Y - recY;
            }
            if (_CircleClicked)
            {
                Circle.X = e.X - cirX;
                Circle.Y = e.Y - cirY;
            }
            if (_SquareClicked)
            {
                Square.X = e.X - sqrX;
                Square.Y = e.Y - sqrY;
            }

            if((label1.Location.X < Rectangle.X + Rectangle.Width)&&(label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label2.Text = "Желтый прямоугольник";
                }
            }

            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label2.Text = "Красный круг";
                }
            }

            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X))
            {
                if ((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                {
                    label2.Text = "Синий квадрат";
                }
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Move(object sender, EventArgs e)
        {
            _RectangeClicked = false;
            _CircleClicked = false;
            _SquareClicked = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height)&&(e.Y > Rectangle.Y))
                {
                    _RectangeClicked = true;
                    recX = e.X - Rectangle.X;
                    recY = e.Y - Rectangle.Y;
                }
            }

            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    _CircleClicked = true;
                    cirX = e.X - Circle.X;
                    cirY = e.Y - Circle.Y;
                }
            }

            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    _SquareClicked = true;
                    sqrX = e.X - Square.X;
                    sqrY = e.Y - Square.Y;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
        }
    }
}