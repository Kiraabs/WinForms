using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class ScreenShot : Form
    {
        public ScreenShot()
        {
            InitializeComponent();
            pictureBoxScreen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxScreen.Image = Form1.BM;
        }

        private void ScreenShot_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Form1.BM.Save(SFD.FileName);
            }
        }
    }
}
