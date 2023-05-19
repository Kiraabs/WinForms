using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИграМозаика
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        public int numRect = 3;
        private void Settings_Load(object sender, EventArgs e)
        {
            switch (numRect)
            {
                case 3:
                    radioButton_3x3.Checked = true;
                    break;
                case 4:
                    radioButton_4x4.Checked = true;
                    break;
                case 5:
                    radioButton_5x5.Checked = true;
                    break;
            }
        }
        private void radioButton_3x3_CheckedChanged(object sender, EventArgs e)
        {
            switch (sender)
            {
                case RadioButton r when r == radioButton_3x3:
                    numRect = 3;
                    break;
                case RadioButton r when r == radioButton_4x4:
                    numRect = 4;
                    break;
                case RadioButton r when r == radioButton_5x5:
                    numRect = 5;
                    break;
            }
        }
    }
}
