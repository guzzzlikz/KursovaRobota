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
    public partial class SearchForm : Form
    {
        private string type = "";
        private string value = "";
        private double newValue = 0;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public double NewValue
        {
            get { return newValue; }
            set { newValue = value; }
        }

        public SearchForm()
        {
            InitializeComponent();
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.Items.Add("Тип");
            typeBox.Items.Add("Назва");
            typeBox.Items.Add("Ціна (більше)");
            typeBox.Items.Add("Ціна (менше)");
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (typeBox.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть тип пошуку!", "Проблема!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (typeBox.SelectedItem.ToString())
            {
                case "Тип":
                    Type = "type";
                    Value = valueField.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case "Назва":
                    Type = "name";
                    Value = valueField.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case "Ціна (більше)":
                    Type = "price_greater";
                    try
                    {
                        double.Parse(valueField.Text);
                    } catch (FormatException)
                    {
                        MessageBox.Show("Будь ласка, введіть коректне число для ціни!", "Проблема!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    NewValue = double.Parse(valueField.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case "Ціна (менше)":
                    Type = "price_less";
                    try
                    {
                        double.Parse(valueField.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Будь ласка, введіть коректне число для ціни!", "Проблема!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    NewValue = double.Parse(valueField.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Будь ласка, оберіть тип пошуку!");
                    return;
            }
        }
    }
}
