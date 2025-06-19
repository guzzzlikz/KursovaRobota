using System;
using System.Windows.Forms;

namespace KursovaRobota
{
    public partial class EditForm : Form
    {
        private Instrument instrument;
        private Image curImage;

        public EditForm(Instrument instrument)
        {
            InitializeComponent();
            this.instrument = instrument;
            textBoxType.Text = instrument.Type;
            textBoxName.Text = instrument.Name;
            richTextBox1.Text = instrument.Description;
            numericUpDownPrice.Value = (decimal)instrument.Price;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxType.Text.Length == 0 ||
                textBoxName.Text.Length == 0 ||
                richTextBox1.Text.Length == 0 ||
                numericUpDownPrice.Value == 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string type = textBoxType.Text;
                string name = textBoxName.Text;
                string description = richTextBox1.Text;
                double price = (double)numericUpDownPrice.Value;
                instrument.Type = type;
                instrument.Name = name;
                instrument.Description = description;
                instrument.Price = price;
                if (curImage != null)
                {
                   instrument.Img = curImage;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void imageButton_Click(object sender, EventArgs e)
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