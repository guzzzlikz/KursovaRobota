using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaRobota
{
    public partial class AddForm : Form
    {
        private Image curImage;
        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0 || typeField.Text.Length == 0 || nameField.Text.Length == 0 || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Будь ласка, заповність всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (curImage == null)
            {
                MessageBox.Show("Будь ласка, додайте зображення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string type = typeField.Text;
                string name = nameField.Text;
                string description = richTextBox1.Text;
                if (Database.instruments.Exists(i => i.Name == name))
                {
                    MessageBox.Show("Такий інструмент вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Database.instruments.Add(new Instrument(type, name, description, (double) numericUpDown1.Value, curImage));
                this.Close();
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Jpg (.jpg)|*.jpg";
                openFileDialog.Title = "Open Instrument image";
                openFileDialog.DefaultExt = null;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    curImage = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
