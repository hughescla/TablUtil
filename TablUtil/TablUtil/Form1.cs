using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablUtil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            toolStripStatusLabel1.Text = "Accounts:" + richTextBox1.Lines.Length.ToString();
            toolStripStatusLabel2.Text = "ID:" + richTextBox2.Lines.Length.ToString();
            foreach (var acc in richTextBox1.Lines)
            {
                bool flagFound = false;
                foreach (var id in richTextBox2.Lines)
                {
                    if (acc.Contains(id))
                    {
                        flagFound = true;
                    }
                }
                if (!flagFound)
                {
                    richTextBox3.AppendText(acc + Environment.NewLine);
                    richTextBox4.AppendText(acc.Split('\t')[14]+Environment.NewLine);
                }
            }
            if (!string.IsNullOrEmpty(richTextBox3.Text))
            {
                string res = richTextBox3.Text;
                Clipboard.SetText(res);
            }
            toolStripStatusLabel3.Text = "Res:" + (richTextBox3.Lines.Length-1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            toolStripStatusLabel1.Text = "Accounts:" + richTextBox1.Lines.Length.ToString();
            toolStripStatusLabel2.Text = "ID:" + richTextBox2.Lines.Length.ToString();

            foreach (var acc in richTextBox1.Lines)
            {
                foreach (var id in richTextBox2.Lines)
                {
                    if (acc.Contains(id))
                    {
                        richTextBox3.AppendText(acc + Environment.NewLine);
                        richTextBox4.AppendText(acc.Split('\t')[14] + Environment.NewLine);
                    }
                }
            }
            if (!string.IsNullOrEmpty(richTextBox3.Text))
            {
                string res = richTextBox3.Text;
                Clipboard.SetText(res);
            }
            toolStripStatusLabel3.Text = "Res:" + (richTextBox3.Lines.Length - 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in richTextBox1.Lines)
            {
                richTextBox3.AppendText(res + Environment.NewLine);
            }
            Clipboard.SetText(richTextBox3.Text);
        }
    }
}
