namespace service_center.main
{
    partial class decisionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(decisionForm));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(16, 40);
            button1.Margin = new Padding(7, 7, 7, 7);
            button1.Name = "button1";
            button1.Size = new Size(509, 108);
            button1.TabIndex = 0;
            button1.Text = "Клієнт не вперше";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clientHasAccount;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(16, 162);
            button2.Margin = new Padding(7, 7, 7, 7);
            button2.Name = "button2";
            button2.Size = new Size(509, 103);
            button2.TabIndex = 0;
            button2.Text = "Клієнт вперше";
            button2.UseVisualStyleBackColor = false;
            button2.Click += clientDoesNotHave;
            // 
            // decisionForm
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(541, 310);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 7, 7, 7);
            Name = "decisionForm";
            Text = "Форма вибору";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}