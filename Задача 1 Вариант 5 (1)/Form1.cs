using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_1_Вариант_5__1_
{
    public partial class Form1 : Form
    {
        private string filename = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            // читаем файл в строку
            textBox1.Text = System.IO.File.ReadAllText(filename);
            saveToolStripMenuItem.Enabled = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(filename, textBox1.Text);
        }
    }
}
