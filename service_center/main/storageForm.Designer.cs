namespace service_center.main
{
    partial class storageForm
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
            partsGridView = new DataGridView();
            manufacturerGridView = new DataGridView();
            manufacturerName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)partsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manufacturerGridView).BeginInit();
            SuspendLayout();
            // 
            // partsGridView
            // 
            partsGridView.AllowUserToAddRows = false;
            partsGridView.BackgroundColor = Color.CornflowerBlue;
            partsGridView.BorderStyle = BorderStyle.None;
            partsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            partsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            partsGridView.Location = new Point(508, 16);
            partsGridView.Margin = new Padding(7);
            partsGridView.MultiSelect = false;
            partsGridView.Name = "partsGridView";
            partsGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            partsGridView.RowTemplate.Height = 25;
            partsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsGridView.Size = new Size(1286, 483);
            partsGridView.TabIndex = 0;
            partsGridView.CellEndEdit += partsCellEdited;
            partsGridView.CellValueChanged += partsGridView_CellValueChanged;
            // 
            // manufacturerGridView
            // 
            manufacturerGridView.AllowUserToAddRows = false;
            manufacturerGridView.AllowUserToDeleteRows = false;
            manufacturerGridView.BackgroundColor = Color.CornflowerBlue;
            manufacturerGridView.BorderStyle = BorderStyle.None;
            manufacturerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            manufacturerGridView.DefaultCellStyle = dataGridViewCellStyle1;
            manufacturerGridView.Location = new Point(29, 16);
            manufacturerGridView.Margin = new Padding(7);
            manufacturerGridView.MultiSelect = false;
            manufacturerGridView.Name = "manufacturerGridView";
            manufacturerGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            manufacturerGridView.RowTemplate.Height = 25;
            manufacturerGridView.Size = new Size(324, 483);
            manufacturerGridView.TabIndex = 0;
            manufacturerGridView.CellEndEdit += manufacturerCellEdited;
            // 
            // manufacturerName
            // 
            manufacturerName.Location = new Point(29, 525);
            manufacturerName.Margin = new Padding(7);
            manufacturerName.Name = "manufacturerName";
            manufacturerName.PlaceholderText = "Введіть назву";
            manufacturerName.Size = new Size(324, 40);
            manufacturerName.TabIndex = 1;
            manufacturerName.TextAlign = HorizontalAlignment.Center;
            manufacturerName.TextChanged += manufacturerName_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(29, 579);
            button1.Margin = new Padding(7);
            button1.Name = "button1";
            button1.Size = new Size(324, 40);
            button1.TabIndex = 2;
            button1.Text = "Додати виробника";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(1245, 525);
            button2.Margin = new Padding(7);
            button2.Name = "button2";
            button2.Size = new Size(274, 40);
            button2.TabIndex = 3;
            button2.Text = "Змінити кількість";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(1245, 579);
            button3.Margin = new Padding(7);
            button3.Name = "button3";
            button3.Size = new Size(549, 40);
            button3.TabIndex = 4;
            button3.Text = "Додати нову деталь";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1533, 525);
            textBox1.Margin = new Padding(7);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введіть кількість";
            textBox1.Size = new Size(261, 40);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += manufacturerName_TextChanged;
            // 
            // storageForm
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1810, 686);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(manufacturerName);
            Controls.Add(manufacturerGridView);
            Controls.Add(partsGridView);
            Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7);
            Name = "storageForm";
            Text = "Склад";
            Load += storageForm_Load;
            ((System.ComponentModel.ISupportInitialize)partsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)manufacturerGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView partsGridView;
        private DataGridView manufacturerGridView;
        private TextBox manufacturerName;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}