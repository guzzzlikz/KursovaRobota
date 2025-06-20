namespace KursovaRobota
{
    public partial class MyForm : Form
    {
        public Instrument currentInstrument;
        private BindingSource instrumentBindingSource = new BindingSource();

        public Instrument GetSelected
        {
            get
            {
                var name = dataGridView1.CurrentRow?.Cells["Назва"].Value?.ToString();
                return Database.instruments.FirstOrDefault(i => i.Name == name);
            }
        }

        public MyForm()
        {
            InitializeComponent();
            shopLayout1.InstrumentSelected += OnInstrumentSelected;
            shopLayout1.currentForm = this;
            FillTable();
            AddBtn_MouseDown();
        }
        private void FillTable()
        {
            instrumentBindingSource.DataSource = Database.instruments.Select(i => new
            {
                Type = i.Type,
                Name = i.Name,
                Price = i.Price.ToString() + " $",
                IsAssigned = i.IsAssigned ? "Так" : "Ні",
            }).ToList();
            dataGridView1.DataSource = instrumentBindingSource;
        }
        private void UpdateTable()
        {
            instrumentBindingSource.DataSource = Database.instruments.Select(i => new
            {
                Type = i.Type,
                Name = i.Name,
                Price = i.Price.ToString() + " $",
                IsAssigned = i.IsAssigned ? "Так" : "Ні",
            }).ToList();
            dataGridView1.DataSource = instrumentBindingSource;
        }

        private void OnInstrumentSelected(Instrument instrument)
        {
            currentInstrument = instrument;
            label5.Text = instrument.Type;
            label6.Text = instrument.Name;
            label7.Text = instrument.Description;
            label8.Text = instrument.Price.ToString("F2") + " $";
            instrumentImgBox.Image = instrument.Img;
            changeDataButton.Visible = true;
            toBasketButton.Visible = true;
            UpdateTable();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Розмітка магазину (*.shoplayout)|*.shoplayout";
                saveFileDialog.DefaultExt = "shoplayout";
                saveFileDialog.Title = "Зберігти розмітку";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    shopLayout1.SaveToFile(saveFileDialog.FileName);
                    MessageBox.Show("Розмітка збережена!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    shopLayout1.Image = null;
                    foreach (InstrumentButton button in shopLayout1.Buttons)
                    {
                        button.Current = null;
                    }
                    shopLayout1.Controls.Clear();
                    label5.Text = string.Empty;
                    label6.Text = string.Empty;
                    label7.Text = string.Empty;
                    label8.Text = string.Empty;
                    instrumentImgBox.Image = null;
                    changeDataButton.Visible = false;
                    toBasketButton.Visible = false;
                    Database.toBasket.Clear();
                    Database.instruments.Clear();
                    FillTable();
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Розмітка магазину (*.shoplayout)|*.shoplayout";
                openFileDialog.Title = "Завантажити розмітку";
                openFileDialog.DefaultExt = "shoplayout";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Controls.Remove(shopLayout1);
                    var loadedLayout = ShopLayout.LoadFromFile(openFileDialog.FileName);
                    if (loadedLayout != null)
                    {
                        loadedLayout.Location = shopLayout1.Location;
                        loadedLayout.Name = shopLayout1.Name;
                        loadedLayout.Size = shopLayout1.Size;
                        this.Controls.Add(loadedLayout);
                        shopLayout1 = loadedLayout;
                        shopLayout1.InstrumentSelected += OnInstrumentSelected;
                        Database.instruments.Clear();
                        foreach (var button in shopLayout1.Buttons)
                        {
                            if (button.Current != null)
                            {
                                if (!Database.instruments.Any(i => i.Name == button.Current.Name))
                                    Database.instruments.Add(button.Current);
                            }
                        }
                        FillTable();

                        MessageBox.Show("Розмітка завантажена!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Невадлось завантажити!", "Проблема", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void changeDataButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(currentInstrument);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                OnInstrumentSelected(currentInstrument);
            }
            UpdateTable();
        }
        private void toBasket_Click(object sender, EventArgs e)
        {
            Database.toBasket.Add(currentInstrument);
            MessageBox.Show($"{currentInstrument.Name} додано до кошика.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void basketButton_Click(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm(Database.toBasket);
            basketForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            UpdateTable();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var selected = GetSelected;
            shopLayout1.FindButton(selected);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelected;
            if (selected != null)
            {
                EditForm editForm = new EditForm(selected);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateTable();
                    OnInstrumentSelected(selected);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelected;
            if (selected != null)
            {
                var result = MessageBox.Show($"Ви впевнені, що хочете видалити {selected.Name}?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Database.instruments.Remove(selected);
                    UpdateTable();
                    shopLayout1.FindButtonAfterDelete(selected);
                    MessageBox.Show($"{selected.Name} видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void shopLayout1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                InstrumentButton btn = new InstrumentButton(e.X, e.Y);
                btn.Click += shopLayout1.InstrumentButton_Click;
                btn.MouseDown += btn_MouseDown;
                btn.BackColor = Color.Red;
                shopLayout1.Controls.Add(btn);
                shopLayout1.Buttons.Add(btn);
            }
        }
        private void AddBtn_MouseDown()
        {
            foreach (var btn in shopLayout1.Buttons)
            {
                btn.MouseDown += btn_MouseDown;
            }
        }
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && sender is InstrumentButton btn)
            {
                var result = MessageBox.Show($"Ви впевнені, що хочете видалити цю позначку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                shopLayout1.Buttons.Remove(btn);
                shopLayout1.Controls.Remove(btn);
                if (btn.Current != null)
                {
                    IsLeft(btn.Current);
                }
                btn.Dispose();
            }
        }
        private void IsLeft(Instrument instrument)
        {
            bool found = false;
            foreach (var button in shopLayout1.Buttons)
            {
                if (button.Current == instrument)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                var dbInstrument = Database.instruments.FirstOrDefault(i => i.Name == instrument.Name);
                if (dbInstrument != null)
                {
                    dbInstrument.IsAssigned = false;
                }
                UpdateTable();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            }
            if (searchForm.Type != "" && searchForm.DialogResult == DialogResult.OK)
            {
                switch (searchForm.Type)
                {
                    case "type":
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["Тип"].Value != null &&
                                row.Cells["Тип"].Value.ToString().Equals(searchForm.Value, StringComparison.OrdinalIgnoreCase))
                            {
                                row.DefaultCellStyle.BackColor = Color.Yellow;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                        break;

                    case "name":
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["Назва"].Value != null &&
                                row.Cells["Назва"].Value.ToString().Equals(searchForm.Value, StringComparison.OrdinalIgnoreCase))
                            {
                                row.DefaultCellStyle.BackColor = Color.Yellow;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                        break;

                    case "price_greater":
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["Ціна"].Value != null)
                            {
                                var priceStr = row.Cells["Ціна"].Value.ToString().Replace(" $", "");
                                if (double.TryParse(priceStr, out double price) && price >= searchForm.NewValue)
                                {
                                    row.DefaultCellStyle.BackColor = Color.Yellow;
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                }
                            }
                        }
                        break;

                    case "price_less":
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["Ціна"].Value != null)
                            {
                                var priceStr = row.Cells["Ціна"].Value.ToString().Replace(" $", "");
                                if (double.TryParse(priceStr, out double price) && price <= searchForm.NewValue)
                                {
                                    row.DefaultCellStyle.BackColor = Color.Yellow;
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}

