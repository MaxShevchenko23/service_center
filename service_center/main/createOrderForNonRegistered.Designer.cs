namespace service_center.admin_forms
{
    partial class createOrderForNonRegistered
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createOrderForNonRegistered));
            nameBox = new TextBox();
            button1 = new Button();
            phoneBox = new TextBox();
            docBox = new TextBox();
            descBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            nameBox.ForeColor = Color.DarkBlue;
            nameBox.Location = new Point(667, 144);
            nameBox.Margin = new Padding(7);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Ім'я";
            nameBox.Size = new Size(394, 46);
            nameBox.TabIndex = 0;
            nameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(745, 404);
            button1.Margin = new Padding(7);
            button1.Name = "button1";
            button1.Size = new Size(251, 63);
            button1.TabIndex = 1;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            phoneBox.ForeColor = Color.DarkBlue;
            phoneBox.Location = new Point(667, 208);
            phoneBox.Margin = new Padding(7);
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Номер телефону";
            phoneBox.Size = new Size(394, 46);
            phoneBox.TabIndex = 0;
            phoneBox.TextAlign = HorizontalAlignment.Center;
            // 
            // docBox
            // 
            docBox.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            docBox.ForeColor = Color.DarkBlue;
            docBox.Location = new Point(667, 271);
            docBox.Margin = new Padding(7);
            docBox.Name = "docBox";
            docBox.PlaceholderText = "ІД документу";
            docBox.Size = new Size(394, 46);
            docBox.TabIndex = 0;
            docBox.TextAlign = HorizontalAlignment.Center;
            // 
            // descBox
            // 
            descBox.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            descBox.ForeColor = Color.DarkBlue;
            descBox.Location = new Point(667, 335);
            descBox.Margin = new Padding(7);
            descBox.Name = "descBox";
            descBox.PlaceholderText = "Опис техніки";
            descBox.Size = new Size(394, 46);
            descBox.TabIndex = 0;
            descBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(713, 83);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 39);
            label1.TabIndex = 2;
            label1.Text = "Нове замовлення";
            // 
            // createOrderForNonRegistered
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1855, 635);
            Controls.Add(label1);
            Controls.Add(descBox);
            Controls.Add(button1);
            Controls.Add(docBox);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7);
            Name = "createOrderForNonRegistered";
            Text = "Нове замовлення";
            Load += newOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private Button button1;
        private TextBox phoneBox;
        private TextBox docBox;
        private TextBox descBox;
        private Label label1;
    }
}