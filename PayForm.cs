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
    public partial class PayForm : Form
    {
        private double total;
        private BasketForm basketForm;
        private List<Instrument> instruments = Database.toBasket;
        public PayForm(double total, BasketForm basket)
        {
            InitializeComponent();
            this.total = total;
            this.basketForm = basket;
            refresh();
        }
        private void refresh()
        {
            label1.Text = label1.Text + total.ToString("F2") + " $";
        }

        private void pay_Click(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(textBox1.Text);
            } catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректну суму!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Double.Parse(textBox1.Text) == total)
            {
                MessageBox.Show("Оплата успішна!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                basketForm.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (Double.Parse(textBox1.Text) > total)
            {
                MessageBox.Show("Оплата успішна! Здача: " + (Double.Parse(textBox1.Text) - total).ToString() + " $", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                basketForm.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Недостатньо коштів!", "Проблема!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
