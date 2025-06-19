namespace KursovaRobota
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            typeField = new TextBox();
            nameField = new TextBox();
            richTextBox1 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            addButton = new Button();
            assignImageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 51);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Тип";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 226);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Опис";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 330);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Ціна";
            // 
            // typeField
            // 
            typeField.Location = new Point(172, 54);
            typeField.Name = "typeField";
            typeField.Size = new Size(248, 27);
            typeField.TabIndex = 5;
            // 
            // nameField
            // 
            nameField.Location = new Point(176, 126);
            nameField.Name = "nameField";
            nameField.Size = new Size(244, 27);
            nameField.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(172, 176);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(248, 120);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(172, 330);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(172, 459);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 9;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // assignImageButton
            // 
            assignImageButton.Location = new Point(123, 395);
            assignImageButton.Name = "assignImageButton";
            assignImageButton.Size = new Size(199, 29);
            assignImageButton.TabIndex = 10;
            assignImageButton.Text = "Зображення";
            assignImageButton.UseVisualStyleBackColor = true;
            assignImageButton.Click += assignButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 515);
            Controls.Add(assignImageButton);
            Controls.Add(addButton);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBox1);
            Controls.Add(nameField);
            Controls.Add(typeField);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Додати";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox typeField;
        private TextBox nameField;
        private RichTextBox richTextBox1;
        private NumericUpDown numericUpDown1;
        private Button addButton;
        private Button assignImageButton;
    }
}