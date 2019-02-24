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
            toolStripStatusLabel1.Text = "Opening";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                toolStripStatusLabel1.Text = "Ready";
                return;
            }
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            // читаем файл в строку
            textBox1.Text = System.IO.File.ReadAllText(filename, Encoding.Default);
            saveToolStripMenuItem.Enabled = true;
            toolStripStatusLabel1.Text = "Ready";
            toolStripStatusLabel2.Text = "Saved";
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
            toolStripStatusLabel2.Text = "Saved";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(filename, textBox1.Text);
            toolStripStatusLabel2.Text = "Saved";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Changed";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Илья Кочанков:\nвозраст: 18 лет,\nрост: 192см\nвес: 78кг");
        }
    }
}
