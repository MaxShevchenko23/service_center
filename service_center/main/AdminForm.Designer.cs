namespace service_center.main
{
    partial class newAdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            functionalBox = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button12 = new Button();
            button13 = new Button();
            button15 = new Button();
            functionalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(29, 520);
            button1.Margin = new Padding(8, 7, 8, 7);
            button1.Name = "button1";
            button1.Size = new Size(369, 76);
            button1.TabIndex = 0;
            button1.Text = "Переглянути замовлення";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // functionalBox
            // 
            functionalBox.BackColor = Color.FromArgb(224, 224, 224);
            functionalBox.Location = new Point(56, 712);
            functionalBox.Margin = new Padding(8, 7, 8, 7);
            functionalBox.Name = "functionalBox";
            functionalBox.PlaceholderText = "Введіть параметр";
            functionalBox.Size = new Size(304, 40);
            functionalBox.TabIndex = 1;
            functionalBox.TextAlign = HorizontalAlignment.Center;
            functionalBox.TextChanged += functionalBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CornflowerBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(4, 26);
            dataGridView1.Margin = new Padding(8, 7, 8, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1788, 429);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.ForeColor = Color.DarkBlue;
            button4.Location = new Point(29, 610);
            button4.Margin = new Padding(8, 7, 8, 7);
            button4.Name = "button4";
            button4.Size = new Size(369, 76);
            button4.TabIndex = 0;
            button4.Text = "Перелік для обраного замовлення";
            button4.UseVisualStyleBackColor = false;
            button4.Click += showEnumForChosen;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 192, 255);
            button7.ForeColor = Color.DarkBlue;
            button7.Location = new Point(1439, 520);
            button7.Margin = new Padding(8, 7, 8, 7);
            button7.Name = "button7";
            button7.Size = new Size(326, 51);
            button7.TabIndex = 0;
            button7.Text = "Новий клієнт";
            button7.UseVisualStyleBackColor = false;
            button7.Click += newClient;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(192, 192, 255);
            button8.ForeColor = Color.DarkBlue;
            button8.Location = new Point(1439, 584);
            button8.Margin = new Padding(8, 7, 8, 7);
            button8.Name = "button8";
            button8.Size = new Size(326, 51);
            button8.TabIndex = 0;
            button8.Text = "Нова техніка";
            button8.UseVisualStyleBackColor = false;
            button8.Click += newApplience;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(192, 192, 255);
            button9.ForeColor = Color.DarkBlue;
            button9.Location = new Point(1439, 647);
            button9.Margin = new Padding(8, 7, 8, 7);
            button9.Name = "button9";
            button9.Size = new Size(326, 51);
            button9.TabIndex = 0;
            button9.Text = "Новий працівник";
            button9.UseVisualStyleBackColor = false;
            button9.Click += newEmployee;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(192, 192, 255);
            button12.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.DarkBlue;
            button12.Location = new Point(1097, 520);
            button12.Margin = new Padding(8, 7, 8, 7);
            button12.Name = "button12";
            button12.Size = new Size(326, 51);
            button12.TabIndex = 0;
            button12.Text = "Склад";
            button12.UseVisualStyleBackColor = false;
            button12.Click += newPart;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(192, 192, 255);
            button13.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.DarkBlue;
            button13.Location = new Point(1097, 585);
            button13.Margin = new Padding(8, 7, 8, 7);
            button13.Name = "button13";
            button13.Size = new Size(326, 51);
            button13.TabIndex = 0;
            button13.Text = "Нове замовлення";
            button13.UseVisualStyleBackColor = false;
            button13.Click += newOrderFormShow;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(192, 192, 255);
            button15.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = Color.DarkBlue;
            button15.Location = new Point(1439, 712);
            button15.Margin = new Padding(8, 7, 8, 7);
            button15.Name = "button15";
            button15.Size = new Size(326, 51);
            button15.TabIndex = 0;
            button15.Text = "Нова послуга";
            button15.UseVisualStyleBackColor = false;
            button15.Click += newService;
            // 
            // functionalLabel
            // 
            functionalLabel.AutoSize = true;
            functionalLabel.ForeColor = Color.Red;
            functionalLabel.Location = new Point(822, 108);
            functionalLabel.Margin = new Padding(8, 0, 8, 0);
            functionalLabel.Name = "functionalLabel";
            functionalLabel.Size = new Size(0, 33);
            functionalLabel.TabIndex = 3;
            functionalLabel.Click += functionalLabel_Click;
            // 
            // newAdminForm
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1797, 855);
            Controls.Add(functionalLabel);
            Controls.Add(dataGridView1);
            Controls.Add(functionalBox);
            Controls.Add(button13);
            Controls.Add(button15);
            Controls.Add(button12);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8, 7, 8, 7);
            Name = "newAdminForm";
            Text = "newAdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox functionalBox;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button12;
        private Button button13;
        private Button button15;
        private Label functionalLabel;
    }
}