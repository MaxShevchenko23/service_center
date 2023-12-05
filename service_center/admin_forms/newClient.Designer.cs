namespace service_center.admin_forms
{
    partial class newClient
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
            button1 = new Button();
            phoneBox = new TextBox();
            docBox = new TextBox();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(26, 23);
            nameBox.Margin = new Padding(6);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Ім'я клієнта";
            nameBox.Size = new Size(306, 36);
            nameBox.TabIndex = 0;
            nameBox.TextAlign = HorizontalAlignment.Center;
            nameBox.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(103, 191);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(161, 44);
            button1.TabIndex = 1;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(26, 79);
            phoneBox.Margin = new Padding(6);
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Номер телефону";
            phoneBox.Size = new Size(306, 36);
            phoneBox.TabIndex = 0;
            phoneBox.TextAlign = HorizontalAlignment.Center;
            phoneBox.UseWaitCursor = true;
            // 
            // docBox
            // 
            docBox.Location = new Point(26, 135);
            docBox.Margin = new Padding(6);
            docBox.Name = "docBox";
            docBox.PlaceholderText = "Номер документу";
            docBox.Size = new Size(306, 36);
            docBox.TabIndex = 0;
            docBox.TextAlign = HorizontalAlignment.Center;
            docBox.UseWaitCursor = true;
            // 
            // newClient
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(377, 251);
            Controls.Add(button1);
            Controls.Add(docBox);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkBlue;
            Margin = new Padding(6);
            Name = "newClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новий клієнт";
            UseWaitCursor = true;
            Load += newClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private Button button1;
        private TextBox phoneBox;
        private TextBox docBox;
    }
}