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

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        private string _name;

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.InitialDirectory = @"C:\Users\talbert\Desktop\Test Streams";
            openFileDialog1.InitialDirectory = @"C:\Users\talbert\Desktop\Test Streams";
            saveFileDialog1.Filter = @"Text Files (*.txt)|*.txt";
            openFileDialog1.Filter = @"Text Files (*.txt)|*.txt";
            saveFileDialog1.Title = @"Save This Shit, Bro";
            openFileDialog1.Title = @"Open This Shit, Bro";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(_name);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _name = saveFileDialog1.FileName;
                File.WriteAllText(_name, textBox1.Text);
            }
        }
    }
}
