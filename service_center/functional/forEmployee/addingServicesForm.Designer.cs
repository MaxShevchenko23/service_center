namespace service_center.functional.forEmployee
{
    partial class addingServicesForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            timeBox = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            descriptionBox = new Label();
            button3 = new Button();
            label1 = new Label();
            functext = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // timeBox
            // 
            timeBox.AutoSize = true;
            timeBox.Font = new Font("ROG Fonts v1.6", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            timeBox.ForeColor = Color.LightGreen;
            timeBox.Location = new Point(208, 9);
            timeBox.Margin = new Padding(4, 0, 4, 0);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(63, 42);
            timeBox.TabIndex = 0;
            timeBox.Text = "Час";
            timeBox.Click += timeBox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(1019, 154);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 29);
            label2.TabIndex = 0;
            label2.Text = "Наявні запчастини";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CornflowerBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(196, 186);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(614, 411);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(378, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(207, 29);
            label3.TabIndex = 0;
            label3.Text = "Наявні послуги";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.CornflowerBlue;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Location = new Point(818, 186);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(683, 411);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(208, 603);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(1218, 58);
            button2.TabIndex = 2;
            button2.Text = "Застосувати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // descriptionBox
            // 
            descriptionBox.AutoSize = true;
            descriptionBox.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionBox.ForeColor = Color.DarkBlue;
            descriptionBox.Location = new Point(753, 87);
            descriptionBox.Margin = new Padding(4, 0, 4, 0);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(59, 23);
            descriptionBox.TabIndex = 0;
            descriptionBox.Text = "Опис";
            descriptionBox.Click += descriptionBox_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(208, 773);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(1218, 74);
            button3.TabIndex = 3;
            button3.Text = "Завершити";
            button3.UseVisualStyleBackColor = false;
            button3.Click += finishOrder;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(695, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 29);
            label1.TabIndex = 0;
            label1.Text = "Опис несправності";
            // 
            // functext
            // 
            functext.AutoSize = true;
            functext.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            functext.ForeColor = Color.DarkBlue;
            functext.Location = new Point(1176, 43);
            functext.Margin = new Padding(4, 0, 4, 0);
            functext.Name = "functext";
            functext.Size = new Size(250, 29);
            functext.TabIndex = 0;
            functext.Text = "Опис несправності";
            // 
            // addingServicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1514, 866);
            Controls.Add(descriptionBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(functext);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(timeBox);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "addingServicesForm";
            Text = "Додавання послуг";
            Load += addingServicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeBox;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridView dataGridView2;
        private Button button2;
        private Label descriptionBox;
        private Button button3;
        private Label label1;
        private Label functext;
    }
}