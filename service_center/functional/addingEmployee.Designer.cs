namespace service_center.functional
{
    partial class addingEmployee
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
            nameBox = new TextBox();
            phoneBox = new TextBox();
            positionComboBox = new ComboBox();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.ForeColor = Color.DarkBlue;
            nameBox.Location = new Point(71, 161);
            nameBox.Margin = new Padding(6);
            nameBox.Multiline = true;
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "ПІБ";
            nameBox.Size = new Size(546, 41);
            nameBox.TabIndex = 0;
            nameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // phoneBox
            // 
            phoneBox.ForeColor = Color.DarkBlue;
            phoneBox.Location = new Point(71, 214);
            phoneBox.Margin = new Padding(6);
            phoneBox.Multiline = true;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Номер телефону";
            phoneBox.Size = new Size(546, 41);
            phoneBox.TabIndex = 0;
            phoneBox.TextAlign = HorizontalAlignment.Center;
            // 
            // positionComboBox
            // 
            positionComboBox.ForeColor = Color.DarkBlue;
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Items.AddRange(new object[] { "Майстер", "Працівник приймальні" });
            positionComboBox.Location = new Point(71, 267);
            positionComboBox.Margin = new Padding(6);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(546, 37);
            positionComboBox.TabIndex = 1;
            positionComboBox.Text = "Посада";
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            loginBox.ForeColor = Color.DarkBlue;
            loginBox.Location = new Point(71, 443);
            loginBox.Margin = new Padding(6);
            loginBox.Multiline = true;
            loginBox.Name = "loginBox";
            loginBox.PlaceholderText = "Логін";
            loginBox.Size = new Size(546, 41);
            loginBox.TabIndex = 0;
            loginBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            passwordBox.ForeColor = Color.DarkBlue;
            passwordBox.Location = new Point(71, 512);
            passwordBox.Margin = new Padding(6);
            passwordBox.Multiline = true;
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Пароль";
            passwordBox.Size = new Size(546, 41);
            passwordBox.TabIndex = 0;
            passwordBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(263, 602);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(161, 44);
            button1.TabIndex = 2;
            button1.Text = "Створити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(166, 391);
            label1.Name = "label1";
            label1.Size = new Size(387, 29);
            label1.TabIndex = 3;
            label1.Text = "Створення облікового запису";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(232, 126);
            label2.Name = "label2";
            label2.Size = new Size(231, 29);
            label2.TabIndex = 3;
            label2.Text = "Персональні дані";
            // 
            // addingEmployee
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(762, 758);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(positionComboBox);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "addingEmployee";
            Text = "addingEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private TextBox phoneBox;
        private ComboBox positionComboBox;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}