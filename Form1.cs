using System;
using System.IO;
using System.Windows.Forms;

namespace Paperman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Mətn daxil edin!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                File.WriteAllText("paperman.txt", richTextBox1.Text);
                MessageBox.Show("Fayl saxlanıldı!", "Məlumat");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Əlavə etmək üçün mətn yazın!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                File.AppendAllText("paperman.txt", richTextBox1.Text + Environment.NewLine);
                MessageBox.Show("Mətn fayla əlavə olundu!", "Məlumat");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists("paperman.txt"))
            {
                File.Delete("paperman.txt");
                richTextBox1.Clear();
                MessageBox.Show("Fayl silindi!", "Məlumat");
            }
            else
            {
                MessageBox.Show("Silinəcək fayl tapılmadı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists("paperman.txt"))
            {
                richTextBox1.Text = File.ReadAllText("paperman.txt");
            }
            else
            {
                MessageBox.Show("Fayl tapılmadı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}