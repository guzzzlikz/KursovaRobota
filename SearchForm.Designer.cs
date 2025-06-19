namespace KursovaRobota
{
    partial class SearchForm
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
            typeBox = new ComboBox();
            typeLabel = new Label();
            valueField = new TextBox();
            valueLabel = new Label();
            sendButton = new Button();
            SuspendLayout();
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(205, 40);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(151, 28);
            typeBox.TabIndex = 0;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(12, 43);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(157, 20);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Оберіть тип пошуку:";
            // 
            // valueField
            // 
            valueField.Location = new Point(205, 194);
            valueField.Name = "valueField";
            valueField.Size = new Size(286, 27);
            valueField.TabIndex = 2;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new Point(12, 201);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(133, 20);
            valueLabel.TabIndex = 3;
            valueLabel.Text = "Введіть значення:";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(205, 311);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 29);
            sendButton.TabIndex = 4;
            sendButton.Text = "Пошук";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 450);
            Controls.Add(sendButton);
            Controls.Add(valueLabel);
            Controls.Add(valueField);
            Controls.Add(typeLabel);
            Controls.Add(typeBox);
            Name = "Пошук";
            Text = "Пошук";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox typeBox;
        private Label typeLabel;
        private TextBox valueField;
        private Label valueLabel;
        private Button sendButton;
    }
}