﻿using System;
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
    public partial class HelpDialog : Form
    {
        public HelpDialog()
        {
            InitializeComponent();
        }

        public Image ImageDuplicate = null;

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBoxImage.Image = ImageDuplicate;
        }
    }
}
