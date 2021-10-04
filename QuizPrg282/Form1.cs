using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizPrg282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void ReadTheFile()
        {
            string[] lines = File.ReadAllLines("File.txt");
            listBox1.Items.AddRange(lines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadTheFile();
        }
    }
}
