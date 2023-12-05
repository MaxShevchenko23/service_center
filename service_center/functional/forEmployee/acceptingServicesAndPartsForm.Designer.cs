namespace service_center.functional.forEmployee
{
    partial class acceptingServicesAndPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acceptingServicesAndPartsForm));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            serviceLabel = new Label();
            partLabel = new Label();
            amountLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(225, 35);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 39);
            label1.TabIndex = 0;
            label1.Text = "Ви впевнені?";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.Location = new Point(151, 267);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1";
            textBox1.Size = new Size(48, 33);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(239, 380);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(168, 38);
            button1.TabIndex = 2;
            button1.Text = "Підтвердити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.ForeColor = Color.DarkBlue;
            serviceLabel.Location = new Point(30, 130);
            serviceLabel.Margin = new Padding(5, 0, 5, 0);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(101, 25);
            serviceLabel.TabIndex = 0;
            serviceLabel.Text = "Послуга";
            // 
            // partLabel
            // 
            partLabel.AutoSize = true;
            partLabel.ForeColor = Color.DarkBlue;
            partLabel.Location = new Point(30, 199);
            partLabel.Margin = new Padding(5, 0, 5, 0);
            partLabel.Name = "partLabel";
            partLabel.Size = new Size(90, 25);
            partLabel.TabIndex = 0;
            partLabel.Text = "Деталь";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.ForeColor = Color.DarkBlue;
            amountLabel.Location = new Point(30, 271);
            amountLabel.Margin = new Padding(5, 0, 5, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(120, 25);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Кількість:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(239, 271);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 0;
            label2.Text = "Кількість:";
            label2.Click += label2_Click;
            // 
            // acceptingServicesAndPartsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(754, 458);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(amountLabel);
            Controls.Add(partLabel);
            Controls.Add(serviceLabel);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "acceptingServicesAndPartsForm";
            Text = "Ви впевнені?";
            Load += acceptingServicesAndPartsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label serviceLabel;
        private Label partLabel;
        private Label amountLabel;
        private Label label2;
    }
}