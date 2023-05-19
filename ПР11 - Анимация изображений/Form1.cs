using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анимация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Bitmap[] Frames;
        private int FrameNum = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[18];
            for (int i = 0; i < 18; i++) Frames[i] = new Bitmap($"Frame{i}.png");
            pictureBoxImage.Image = Frames[FrameNum];
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % Frames.Length;
            pictureBoxImage.Image = Frames[FrameNum];
        }
        private void buttonBegin_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            if (timer.Enabled) buttonBegin.Text = "Стоп";
            else buttonBegin.Text = "Старт";
        }
        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            timer.Interval = 1000 / trackBarSpeed.Value;
        }
    }
}
