using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            string pattern = textBox1.Text;
            Match match;

            foreach (var item in richTextBox1.Text.Split('\n'))
            {
                match = Regex.Match(item, pattern);
                if (match.Length > 0)
                    richTextBox2.Text += item + '\n';
            }
        }
    }
}
