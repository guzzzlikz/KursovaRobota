using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace KursovaRobota
{
    public partial class BasketForm : Form
    {
        private List<Instrument> basket;
        private double total = 0;
        private PayForm payForm;
        public List<Instrument> Payed { get; private set; } = new List<Instrument>();

        public BasketForm(List<Instrument> basket)
        {
            InitializeComponent();
            this.basket = Database.toBasket;
            RefreshBasket();
        }

        private void RefreshBasket()
        {
            listBox.Items.Clear();
            foreach (var instrument in basket)
            {
                listBox.Items.Add($"{instrument.Name} - {instrument.Price:F2} $");
            }
            total = 0;
            UpdateTotal();
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int idx = listBox.SelectedIndex;
            if (idx >= 0 && idx < basket.Count)
            {
                basket.RemoveAt(idx);
                RefreshBasket();
            }
            else if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Кошик пустий!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                MessageBox.Show("Кошик пустий!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PayForm payForm = new PayForm(total, this);
            if (payForm.ShowDialog() == DialogResult.OK)
            {
                Payed = new List<Instrument>(basket);
                this.DialogResult = DialogResult.OK;
                basket.Clear();
                this.Close();
            }
        }

        private void UpdateTotal()
        {
            if (basket.Count == 0)
            {
                labelTotal.Text = $"Усього: {total} $";
            }
            else
            {
                foreach (var instrument in basket)
                {
                    total += instrument.Price;
                    labelTotal.Text = $"Усього: {total} $";
                }
            }
        }
    }
}
