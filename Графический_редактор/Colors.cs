using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графический_редактор
{
    public partial class Colors : Form
    {
        Color color;
        private void UpdateColor()
        {
            color = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
            pictureBoxColor.BackColor = color;
        }
        public Colors (Color color)
        {
            InitializeComponent();
            hScrollBarRed.Tag = numericUpDownRed;
            hScrollBarGreen.Tag = numericUpDownGreen;
            hScrollBarBlue.Tag = numericUpDownBlue;
            numericUpDownRed.Tag = hScrollBarRed;
            numericUpDownGreen.Tag = hScrollBarGreen;
            numericUpDownBlue.Tag = hScrollBarBlue;
            numericUpDownRed.Value = color.R;
            numericUpDownGreen.Value = color.G;
            numericUpDownBlue.Value = color.B;
        }
        private void HScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scroll = (ScrollBar)sender;
            NumericUpDown numeric = (NumericUpDown)scroll.Tag;
            numeric.Value = scroll.Value;
            UpdateColor();
        }
        private void NumericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            ScrollBar scroll = (ScrollBar)numeric.Tag;
            scroll.Value = (int)numeric.Value;
        }
        private void HScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scroll = (ScrollBar)sender;
            NumericUpDown numeric = (NumericUpDown)scroll.Tag;
            numeric.Value = scroll.Value;
            UpdateColor();
        }
        private void NumericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            ScrollBar scroll = (ScrollBar)numeric.Tag;
            scroll.Value = (int)numeric.Value;
        }
        private void HScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar scroll = (ScrollBar)sender;
            NumericUpDown numeric = (NumericUpDown)scroll.Tag;
            numeric.Value = scroll.Value;
            UpdateColor();
        }
        private void NumericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            ScrollBar scroll = (ScrollBar)numeric.Tag;
            scroll.Value = (int)numeric.Value;
        }
        private void ButtonColors_Click(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            if (colors.ShowDialog() == DialogResult.OK)
            {
                hScrollBarRed.Value = colors.Color.R;
                hScrollBarGreen.Value = colors.Color.G;
                hScrollBarBlue.Value = colors.Color.B;
                UpdateColor();
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            NewColor.Value = color;
            Close();
        }
    }
}
