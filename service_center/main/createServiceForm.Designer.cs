namespace service_center.main
{
    partial class createServiceForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(365, 86);
            label1.Name = "label1";
            label1.Size = new Size(237, 33);
            label1.TabIndex = 0;
            label1.Text = "Додати послугу";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.DarkBlue;
            textBox1.Location = new Point(336, 146);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Назва послуги";
            textBox1.Size = new Size(292, 40);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.DarkBlue;
            textBox2.Location = new Point(336, 220);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ціна";
            textBox2.Size = new Size(215, 40);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(383, 292);
            button1.Name = "button1";
            button1.Size = new Size(198, 43);
            button1.TabIndex = 2;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(557, 227);
            label2.Name = "label2";
            label2.Size = new Size(71, 33);
            label2.TabIndex = 0;
            label2.Text = "грн.";
            // 
            // createServiceForm
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(995, 532);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 7, 7, 7);
            Name = "createServiceForm";
            Text = "Додавання послуг";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
    }
}