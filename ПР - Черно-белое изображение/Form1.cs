using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) 
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Сохранить картинку как...";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.CheckPathExists = true; 
                saveFileDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                saveFileDialog.ShowHelp = true; 
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox2.Image.Save(saveFileDialog.FileName);
                    }
                    catch 
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) 
            {
                Bitmap input = new Bitmap(pictureBox1.Image);
                Bitmap output = new Bitmap(input.Width, input.Height);
                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                        UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                        float R = (float)((pixel & 0x00FF0000) >> 16); 
                        float G = (float)((pixel & 0x0000FF00) >> 8); 
                        float B = (float)(pixel & 0x000000FF); 
                        R = G = B = (R + G + B) / 3.0f;
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                pictureBox2.Image = output;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
