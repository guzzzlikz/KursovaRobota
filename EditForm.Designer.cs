using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace KursovaRobota
{
    partial class EditForm
    {
        private IContainer components = null;
        private TextBox textBoxType;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownPrice;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelType;
        private Label labelName;
        private Label labelDescription;
        private Label labelPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxType = new TextBox();
            textBoxName = new TextBox();
            numericUpDownPrice = new NumericUpDown();
            buttonOK = new Button();
            buttonCancel = new Button();
            labelType = new Label();
            labelName = new Label();
            labelDescription = new Label();
            labelPrice = new Label();
            richTextBox1 = new RichTextBox();
            imageButton = new Button();
            ((ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(143, 12);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(285, 27);
            textBoxType.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(330, 27);
            textBoxName.TabIndex = 3;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(100, 210);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(200, 27);
            numericUpDownPrice.TabIndex = 7;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(30, 309);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 45);
            buttonOK.TabIndex = 8;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(299, 309);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 45);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Відміна";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 15);
            labelType.Name = "labelType";
            labelType.Size = new Size(125, 20);
            labelType.TabIndex = 0;
            labelType.Text = "Тип:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(54, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Назва:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 73);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(48, 20);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Опис:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 217);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(44, 20);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Ціна:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(100, 74);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(328, 120);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // imageButton
            // 
            imageButton.Location = new Point(120, 261);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(180, 29);
            imageButton.TabIndex = 11;
            imageButton.Text = "Зображення";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // EditForm
            // 
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
            ClientSize = new Size(442, 381);
            Controls.Add(imageButton);
            Controls.Add(richTextBox1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(numericUpDownPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(textBoxType);
            Controls.Add(labelType);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Змінити параметри";
            ((ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private RichTextBox richTextBox1;
        private Button imageButton;
    }
}
