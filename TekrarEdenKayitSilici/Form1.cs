using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekrarEdenKayitSilici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplamsatsay.Text = textBox1.Lines.Count().ToString();
            textBox2.Text = string.Join("\r\n", textBox1.Lines.ToList().Distinct());
            sonsatsay.Text = textBox2.Lines.Count().ToString();
            textBox2.SelectAll();
            Clipboard.SetText(textBox2.Text,TextDataFormat.UnicodeText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text, TextDataFormat.UnicodeText);
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 frm = new TekrarEdenKayitSilici.Form1();
            
            textBox1.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toplamsatsay.Text = textBox1.Lines.Count().ToString();
        }
    }
}
