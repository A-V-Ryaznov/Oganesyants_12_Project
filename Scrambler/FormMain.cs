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

namespace Scrambler
{
    public partial class AttachmentScrambler : Form
    {
        public AttachmentScrambler()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|TIM Notepad File (*.tnf)|*.tnf";
        }
        public string GetScrambler(string str, int key)
        {
           return Coder.Scrambler(str, textKey.Text);
        }

        static int GeneratorRandomValue()
        {
            Random rnd = new Random();
            int value = rnd.Next(int.MinValue, int.MaxValue);
            return value;
        }

        private void buttonScrambler_Click(object sender, EventArgs e)
        {
            try
            {
                textResult.Text = GetScrambler(textSourse.Text, int.Parse(textKey.Text));
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректный ключ!\nМинимальное значение: " + int.MinValue + "\nМаксимальное значение: " + int.MaxValue);
            }
        }

        private void buttonRandomGenerator_Click(object sender, EventArgs e)
        {
            textKey.Text = Convert.ToString(GeneratorRandomValue());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filetext = File.ReadAllText(filename, Encoding.GetEncoding(1251));
            textSourse.Text = filetext;
            MessageBox.Show("Файл успешно открыт.");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textResult.Text);
            MessageBox.Show("Файл успешно сохранён.");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filetext = File.ReadAllText(filename, Encoding.GetEncoding(1251));
            textSourse.Text = filetext;
            MessageBox.Show("Файл успешно открыт.");
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textResult.Text);
            MessageBox.Show("Файл успешно сохранён.");
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReference reference = new FormReference();
            reference.Show();
        }

        private void очиститьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textSourse.Clear();
        }

        private void очиститьПолеВводаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSourse.Clear();
        }

        private void очиститьПолеВыводаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textResult.Clear();
        }

        private void buttonCopyKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textKey.Text);
        }

        private void buttonCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textResult.Text);
        }

        private void buttonClearSourse_Click(object sender, EventArgs e)
        {
            textSourse.Clear();
        }
    }
}
