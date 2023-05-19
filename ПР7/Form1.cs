using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace ПР7
{
    public partial class Form1 : Form
    {
        OpenFileDialog OpenFileDialog = new OpenFileDialog();
        SaveFileDialog SaveFileDialog = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(OpenFileDialog.FileName, Encoding.Default);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
        private void menuSave_Click(object sender, EventArgs e)
        {
            if(SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(SaveFileDialog.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++) 
                writer.WriteLine((string)listBox2.Items[i]);
                writer.Close();
            }
            saveFileDialog.Dispose();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] strings = richTextBox1.Text.Split(new char[] {'\n', '\t', ' '},
            StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in strings )
            {
                string str = s.Trim();
                if (str == String.Empty) continue;
                else if (radioButton1.Checked) listBox1.Items.Add(str);
                else if (radioButton2.Checked) if (Regex.IsMatch(str, @"\d")) listBox1.Items.Add(str);
                else if (radioButton3.Checked) if (Regex.IsMatch(str, @"\w+@\w+\. \w+")) listBox1.Items.Add(str);
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            radioButton1.Checked = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            richTextBox1.Text = String.Empty;
            textBox1.Text = String.Empty;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonClear1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void buttonClear2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string find = textBox1.Text;
            if (checkBox1.Checked) foreach (string str in listBox1.Items)
                    if (str.Contains(find)) listBox3.Items.Add(str);
            if (checkBox2.Checked) foreach (string str in listBox2.Items)
                    if (str.Contains(find)) listBox3.Items.Add(str);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                if (listBox1.GetSelected(i)) listBox1.Items.RemoveAt(i);
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
                if (listBox2.GetSelected(i)) listBox2.Items.RemoveAt(i);
        }
        private void buttonAllRight_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void buttonAllLeft_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddDialog AddRec = new AddDialog();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach(object item in listBox1.SelectedItems) listBox2.Items.Add(item);
            listBox2.EndUpdate();
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object item in listBox2.SelectedItems) listBox1.Items.Add(item);
            listBox1.EndUpdate();
        }
    }
}
