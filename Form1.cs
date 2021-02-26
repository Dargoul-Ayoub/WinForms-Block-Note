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

namespace _6._1_Block_Note_Amelioré
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt"; // it will show but files with .txt extension
            openFileDialog.ShowDialog();
            if(openFileDialog.FileName!=string.Empty)
            using (StreamReader read = File.OpenText(openFileDialog.FileName))
            {
                textBox1.Text = read.ReadToEnd();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
             saveFile.Filter = "(*.txt)|*.txt";
            // saveFile.DefaultExt = "txt"; it will set the file with .txt Extention by default
            saveFile.ShowDialog();
            if (saveFile.FileName != string.Empty)
            {
                using(StreamWriter write = File.CreateText(saveFile.FileName))
                {
                    write.Write(textBox1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            if(font.Font!=null)
            textBox1.Font=font.Font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = textBox1.ForeColor;
            color.ShowDialog();
            if (color.Color != null)
                textBox1.ForeColor = color.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = textBox1.ForeColor;
            color.ShowDialog();
            if (color.Color != null)
                textBox1.BackColor = color.Color;
        }
    }
}
