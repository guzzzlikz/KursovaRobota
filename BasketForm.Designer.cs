using System.ComponentModel;
using System.Windows.Forms;
namespace KursovaRobota
{
    partial class BasketForm
    {
        private IContainer components = null;
        private ListBox listBox;
        private Button buttonRemove;
        private Button buttonPay;
        private Label labelTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBox = new ListBox();
            buttonRemove = new Button();
            buttonPay = new Button();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(12, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(381, 184);
            listBox.TabIndex = 0;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(12, 210);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(100, 27);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Видалити";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(293, 210);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(100, 27);
            buttonPay.TabIndex = 2;
            buttonPay.Text = "Оплатити";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // labelTotal
            // 
            labelTotal.Location = new Point(151, 210);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 27);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Усього: $0.00";
            labelTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BasketForm
            // 
            ClientSize = new Size(405, 250);
            Controls.Add(listBox);
            Controls.Add(buttonRemove);
            Controls.Add(buttonPay);
            Controls.Add(labelTotal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BasketForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Кошик";
            ResumeLayout(false);
        }
    }
}