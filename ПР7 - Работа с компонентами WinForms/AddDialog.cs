using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР7
{
    public partial class AddDialog : Form
    {
        public AddDialog()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (textBox1.Text != " ")
            {
                if (this.radioButton1.Checked == true)
                Main.listBox1.Items.Add(this.textBox1.Text);
                else Main.listBox2.Items.Add(this.textBox1.Text);
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
