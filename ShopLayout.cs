using System.ComponentModel;
using System.Text.Json;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KursovaRobota
{
    [ToolboxItem(true)]
    public class ShopLayout : PictureBox
    {
        public List<InstrumentButton> Buttons = new List<InstrumentButton>();

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new Image Image
        {
            get => base.Image;
            set => base.Image = value;
        }

        [Browsable(false)]
        public event Action<Instrument> InstrumentSelected;
        public ShopLayout()
        {
            this.Size = new Size(100, 100);
            this.BackColor = Color.LightGray;
            this.SizeMode = PictureBoxSizeMode.Zoom;
            setup();
        }
        public MyForm currentForm { get; set; }
        private void setup()
        {
            int x = 200;
            int y = 35;
            for (int i = 0; i < Database.instruments.Count; i++)
            {
                if (x >= 1000)
                {
                    y += 110;
                    x = 200;
                }
                Buttons.Add(new InstrumentButton(x, y, Database.instruments[i])); //145
                Database.instruments[i].IsAssigned = true;
                Buttons[i].Click += InstrumentButton_Click;
                this.Controls.Add(Buttons[i]);
                x += 70;
            }
            Buttons.Add(new InstrumentButton(x, y));
            Buttons[Buttons.Count - 1].Click += InstrumentButton_Click;
            this.Controls.Add(Buttons[Buttons.Count - 1]);
        }
        public void InstrumentButton_Click(object sender, EventArgs e)
        {
            if (sender is InstrumentButton btn && btn.Current != null)
            {
                InstrumentSelected?.Invoke(btn.Current);
            } else if (sender is InstrumentButton emptybtn && emptybtn.Current == null)
            {
                var selectedInstrument = currentForm?.GetSelected;
                if (selectedInstrument != null)
                {
                    var result = MessageBox.Show($"Ви впевнені, що хочете прив'язати {selectedInstrument.Name}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    emptybtn.Current = selectedInstrument;
                    emptybtn.Current.IsAssigned = true;
                    InstrumentSelected?.Invoke(emptybtn.Current);
                }
            }
        }
        public void FindButton(Instrument instrument)
        {
            foreach (var btn in Buttons)
            {
                if (btn.Current == null)
                {
                    btn.BackColor = Color.Red;
                    btn.Invalidate();
                }
                else if (btn.Current == instrument)
                {
                    btn.BackColor = Color.Green;
                    btn.Invalidate();
                }
                else
                {
                    btn.BackColor = Color.LightGray;
                    btn.Invalidate();
                }
            }
        }
        public void FindButtonAfterDelete(Instrument instrument)
        {
            foreach (var btn in Buttons)
            {
                if (btn.Current == instrument)
                {
                    btn.BackColor = Color.Red;
                    btn.Current = null;
                    btn.Invalidate();
                }
            }
        }

        public void SaveToFile(string filePath)
        {
            try
            {
                if (this.Image != null)
                {
                    string imagePath = Path.ChangeExtension(filePath, ".png");
                    using (FileStream imgStream = new FileStream(imagePath, FileMode.Create))
                    {
                        this.Image.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
                var buttonDataList = new List<InstrumentButtonData>();
                foreach (var btn in Buttons)
                {
                    buttonDataList.Add(new InstrumentButtonData
                    {
                        X = btn.Location.X,
                        Y = btn.Location.Y,
                        Instrument = btn.Current
                    });
                }
                var data = new ShopLayoutData
                {
                    Width = this.Width,
                    Height = this.Height,
                    BackColor = this.BackColor.ToArgb(),
                    Buttons = buttonDataList
                };
                string json = JsonSerializer.Serialize(data);
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static ShopLayout LoadFromFile(string filePath)
        {
            try
            {
                ShopLayoutData data;
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                using (StreamReader reader = new StreamReader(fs))
                {
                    string json = reader.ReadToEnd();
                    data = JsonSerializer.Deserialize<ShopLayoutData>(json);
                }

                var layout = new ShopLayout
                {
                    Width = data.Width,
                    Height = data.Height,
                    BackColor = Color.FromArgb(data.BackColor)
                };
                layout.Controls.Clear();
                layout.Buttons.Clear();
                if (data.Buttons != null)
                {
                    foreach (var btnData in data.Buttons)
                    {
                        var btn = new InstrumentButton(btnData.X, btnData.Y, btnData.Instrument);
                        btn.Click += layout.InstrumentButton_Click;
                        layout.Buttons.Add(btn);
                        layout.Controls.Add(btn);
                    }
                }
                string imagePath = Path.ChangeExtension(filePath, ".png");
                if (File.Exists(imagePath))
                {
                    using (FileStream imgStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        layout.Image = Image.FromStream(imgStream);
                    }
                }

                return layout;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        private class ShopLayoutData
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int BackColor { get; set; }
            public List<InstrumentButtonData> Buttons { get; set; }
        }
        private class InstrumentButtonData
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Instrument Instrument { get; set; }
        }
    }
}
