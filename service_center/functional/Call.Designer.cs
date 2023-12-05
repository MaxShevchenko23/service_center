namespace service_center.functional
{
    partial class Call
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Call));
            label1 = new Label();
            label2 = new Label();
            nameLabel = new Label();
            phoneNumberLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(231, 96);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 33);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(231, 146);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 33);
            label2.TabIndex = 0;
            label2.Text = "Phone:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.DarkBlue;
            nameLabel.Location = new Point(334, 96);
            nameLabel.Margin = new Padding(6, 0, 6, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(104, 33);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.DarkBlue;
            phoneNumberLabel.Location = new Point(334, 146);
            phoneNumberLabel.Margin = new Padding(6, 0, 6, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(110, 33);
            phoneNumberLabel.TabIndex = 0;
            phoneNumberLabel.Text = "Phone:";
            // 
            // Call
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(679, 327);
            Controls.Add(phoneNumberLabel);
            Controls.Add(label2);
            Controls.Add(nameLabel);
            Controls.Add(label1);
            Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 6, 6, 6);
            Name = "Call";
            Text = "Зателефонувати";
            Load += Call_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label nameLabel;
        private Label phoneNumberLabel;
    }
}