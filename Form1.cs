using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__ASSESSMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIdx = listBox1.SelectedIndex;
            if (selectedIdx != -1) 
            {
                string newWord =textBox1.Text;
                listBox1.Items[selectedIdx] = newWord;
                textBox1.Clear();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            listBox1.Items.Add(word);
            textBox1.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            int selectedIdx = listBox1.SelectedIndex;
            if (selectedIdx != -1) 
            {
                listBox1.Items.RemoveAt(selectedIdx);
            }
        }
    }
}
