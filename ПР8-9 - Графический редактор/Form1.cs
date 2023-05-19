using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Графический_редактор
{
    public partial class Form1 : Form
    {
        bool drawing;
        int counter;
        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        List<Image> History;
        public Form1()
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(Color.Black);
            currentPen.Width = trackBarThickness.Value;
            History = new List<Image>();
        }
        private void menuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия приложения: 0.1");
        }
        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Imag|*.gif|PNG Image|*.png";
            saveFileDialog.Title = "Сохранить изображение";
            saveFileDialog.FilterIndex = 4;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != " ")
            {
                FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1: pictureBoxArea.Image.Save(fileStream, ImageFormat.Jpeg); break;
                    case 2: pictureBoxArea.Image.Save(fileStream, ImageFormat.Bmp); break;
                    case 3: pictureBoxArea.Image.Save(fileStream, ImageFormat.Gif); break;
                    case 4: pictureBoxArea.Image.Save(fileStream, ImageFormat.Png); break;
                }
                fileStream.Close();
            }
        }
        private void menuNew_Click(object sender, EventArgs e)
        {
            History.Clear();
            counter = 0;
            Bitmap picture = new Bitmap(835, 500);
            pictureBoxArea.Image = picture;
            History.Add(new Bitmap(pictureBoxArea.Image));
            if (pictureBoxArea.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение?",
                "Внимание",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: menuSave_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }
        private void pictureBoxArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBoxArea.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }
            if(e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
        }
        private void pictureBoxArea_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(counter + 1, History.Count - counter - 1);
            History.Add(new Bitmap(pictureBoxArea.Image));
            if (counter + 1 < 10) counter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);
            drawing = false;
            try { currentPath.Dispose(); } catch { };
        }
        private void pictureBoxArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(pictureBoxArea.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                pictureBoxArea.Invalidate();
            }
            labelCord.Text = e.X.ToString() + "; " + e.Y.ToString();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            openFileDialog.Title = "Открыть изображение";
            openFileDialog.FilterIndex = 1;
            if(openFileDialog.ShowDialog() != DialogResult.Cancel) pictureBoxArea.Load(openFileDialog.FileName);
            pictureBoxArea.AutoSize = true;
        }
        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBarThickness.Value;
        }
        private void menuUndo_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && counter != 0) pictureBoxArea.Image = new Bitmap(History[--counter]);
            else MessageBox.Show("История пуста");
        }
        private void menuRedo_Click(object sender, EventArgs e)
        {
            if (counter < History.Count - 1) pictureBoxArea.Image = new Bitmap(History[++counter]);
            else MessageBox.Show("История пуста");
        }
        private void menuSolid_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            menuSolid.Checked = true;
            menuDot.Checked = false;
            menuDash.Checked = false;
        }
        private void menuDot_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            menuSolid.Checked = false;
            menuDot.Checked = true;
            menuDash.Checked = false;
        }
        private void menuDash_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dash;
            menuSolid.Checked = false;
            menuDot.Checked = false;
            menuDash.Checked = true;
        }
        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            History.Clear();
            counter = 0;
            Bitmap picture = new Bitmap(835, 500);
            pictureBoxArea.Image = picture;
            History.Add(new Bitmap(pictureBoxArea.Image));
            if (pictureBoxArea.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение?",
                "Внимание",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: menuSave_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }
        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Imag|*.gif|PNG Image|*.png";
            saveFileDialog.Title = "Сохранить изображение";
            saveFileDialog.FilterIndex = 4;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != " ")
            {
                FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1: pictureBoxArea.Image.Save(fileStream, ImageFormat.Jpeg); break;
                    case 2: pictureBoxArea.Image.Save(fileStream, ImageFormat.Bmp); break;
                    case 3: pictureBoxArea.Image.Save(fileStream, ImageFormat.Gif); break;
                    case 4: pictureBoxArea.Image.Save(fileStream, ImageFormat.Png); break;
                }
                fileStream.Close();
            }
            Graphics g = Graphics.FromImage(pictureBoxArea.Image);
            g.Clear(Color.White);
            g.DrawImage(pictureBoxArea.Image, 0, 0, 835, 500);
        }
        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            openFileDialog.Title = "Открыть изображение";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() != DialogResult.Cancel) pictureBoxArea.Load(openFileDialog.FileName);
            pictureBoxArea.AutoSize = true;
        }

        private void MenuColor_Click(object sender, EventArgs e)
        {
            Colors color = new Colors (NewColor.Value);
            color.ShowDialog();
            currentPen.Color = NewColor.Value;
        }
    }
    public static class NewColor
    {
        public static Color Value { get; set; }
    }
}
