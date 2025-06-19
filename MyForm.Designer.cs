namespace KursovaRobota
{
    partial class MyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            searchButton = new Button();
            deleteButton = new Button();
            changeButton = new Button();
            addButton = new Button();
            loadLayoutButton = new Button();
            saveLayoutButton = new Button();
            dataGridView1 = new DataGridView();
            Тип = new DataGridViewTextBoxColumn();
            Назва = new DataGridViewTextBoxColumn();
            Ціна = new DataGridViewTextBoxColumn();
            Привязана = new DataGridViewTextBoxColumn();
            shopLayout1 = new ShopLayout();
            panel2 = new Panel();
            basketButton = new PictureBox();
            toBasketButton = new Button();
            changeDataButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            priceLabel = new Label();
            descLabel = new Label();
            nameLabel = new Label();
            typeLabel = new Label();
            instrumentImgBox = new PictureBox();
            databaseBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shopLayout1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)basketButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)instrumentImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(changeButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(loadLayoutButton);
            panel1.Controls.Add(saveLayoutButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 985);
            panel1.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(347, 364);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 6;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(489, 364);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(173, 364);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(94, 29);
            changeButton.TabIndex = 4;
            changeButton.Text = "Редагувати";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(32, 364);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 3;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // loadLayoutButton
            // 
            loadLayoutButton.Location = new Point(394, 733);
            loadLayoutButton.Name = "loadLayoutButton";
            loadLayoutButton.Size = new Size(189, 29);
            loadLayoutButton.TabIndex = 1;
            loadLayoutButton.Text = "Завантажити розмітку";
            loadLayoutButton.UseVisualStyleBackColor = true;
            loadLayoutButton.Click += loadButton_Click;
            // 
            // saveLayoutButton
            // 
            saveLayoutButton.Location = new Point(41, 733);
            saveLayoutButton.Name = "saveLayoutButton";
            saveLayoutButton.Size = new Size(188, 29);
            saveLayoutButton.TabIndex = 0;
            saveLayoutButton.Text = "Зберегти розмітку";
            saveLayoutButton.UseVisualStyleBackColor = true;
            saveLayoutButton.Click += saveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Тип, Назва, Ціна, Привязана });
            dataGridView1.Location = new Point(32, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(551, 250);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Тип
            // 
            Тип.DataPropertyName = "Type";
            Тип.Frozen = true;
            Тип.HeaderText = "Тип";
            Тип.MinimumWidth = 6;
            Тип.Name = "Тип";
            Тип.Width = 125;
            // 
            // Назва
            // 
            Назва.DataPropertyName = "Name";
            Назва.HeaderText = "Назва";
            Назва.MinimumWidth = 6;
            Назва.Name = "Назва";
            Назва.ReadOnly = true;
            Назва.Width = 125;
            // 
            // Ціна
            // 
            Ціна.DataPropertyName = "Price";
            Ціна.HeaderText = "Ціна";
            Ціна.MinimumWidth = 6;
            Ціна.Name = "Ціна";
            Ціна.ReadOnly = true;
            Ціна.Width = 125;
            // 
            // Привязана
            // 
            Привязана.DataPropertyName = "IsAssigned";
            Привязана.HeaderText = "Прив'язаний";
            Привязана.MinimumWidth = 6;
            Привязана.Name = "Привязаний";
            Привязана.ReadOnly = true;
            Привязана.Width = 125;
            // 
            // shopLayout1
            // 
            shopLayout1.BackColor = Color.LightGray;
            shopLayout1.currentForm = null;
            shopLayout1.Image = Properties.Resources.shopLayout1;
            shopLayout1.Location = new Point(670, 522);
            shopLayout1.Name = "shopLayout1";
            shopLayout1.Size = new Size(1240, 465);
            shopLayout1.SizeMode = PictureBoxSizeMode.Zoom;
            shopLayout1.TabIndex = 1;
            shopLayout1.TabStop = false;
            shopLayout1.MouseDown += shopLayout1_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(basketButton);
            panel2.Controls.Add(toBasketButton);
            panel2.Controls.Add(changeDataButton);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(priceLabel);
            panel2.Controls.Add(descLabel);
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(typeLabel);
            panel2.Controls.Add(instrumentImgBox);
            panel2.Location = new Point(656, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1298, 523);
            panel2.TabIndex = 2;
            // 
            // basketButton
            // 
            basketButton.Image = Properties.Resources.basket11;
            basketButton.Location = new Point(1132, 0);
            basketButton.Name = "basketButton";
            basketButton.Size = new Size(99, 101);
            basketButton.TabIndex = 11;
            basketButton.TabStop = false;
            basketButton.Click += basketButton_Click;
            // 
            // toBasketButton
            // 
            toBasketButton.Location = new Point(871, 260);
            toBasketButton.Name = "toBasketButton";
            toBasketButton.Size = new Size(184, 29);
            toBasketButton.TabIndex = 10;
            toBasketButton.Text = "Додати у кошик";
            toBasketButton.UseVisualStyleBackColor = true;
            toBasketButton.Visible = false;
            toBasketButton.Click += toBasket_Click;
            // 
            // changeDataButton
            // 
            changeDataButton.Location = new Point(871, 138);
            changeDataButton.Name = "changeDataButton";
            changeDataButton.Size = new Size(94, 29);
            changeDataButton.TabIndex = 9;
            changeDataButton.Text = "Редагувати";
            changeDataButton.UseVisualStyleBackColor = true;
            changeDataButton.Visible = false;
            changeDataButton.Click += changeDataButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 419);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 269);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 147);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 39);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 5;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(325, 419);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 20);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Ціна:";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(325, 269);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(48, 20);
            descLabel.TabIndex = 3;
            descLabel.Text = "Опис:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(325, 147);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(54, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Назва:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(325, 39);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(125, 20);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Тип:";
            // 
            // instrumentImgBox
            // 
            instrumentImgBox.BackColor = Color.White;
            instrumentImgBox.Location = new Point(82, 39);
            instrumentImgBox.Name = "instrumentImgBox";
            instrumentImgBox.Size = new Size(200, 400);
            instrumentImgBox.TabIndex = 0;
            instrumentImgBox.TabStop = false;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 986);
            Controls.Add(panel2);
            Controls.Add(shopLayout1);
            Controls.Add(panel1);
            Name = "MyForm";
            Text = "Магазин музичних інструментів";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shopLayout1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)basketButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)instrumentImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ResumeLayout(false);
        }

        private void ShopLayout1_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private ShopLayout shopLayout1;
        private Button saveLayoutButton;
        private Button loadLayoutButton;
        private Panel panel2;
        private Label priceLabel;
        private Label descLabel;
        private Label nameLabel;
        private Label typeLabel;
        private PictureBox instrumentImgBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Button toBasketButton;
        private Button changeDataButton;
        private PictureBox basketButton;
        public DataGridView dataGridView1;
        private BindingSource databaseBindingSource;
        private DataGridViewTextBoxColumn Тип;
        private DataGridViewTextBoxColumn Назва;
        private DataGridViewTextBoxColumn Ціна;
        private DataGridViewTextBoxColumn Привязана;
        private Button addButton;
        private Button changeButton;
        private Button deleteButton;
        private Button searchButton;
    }
}
