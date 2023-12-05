namespace service_center.main
{
    partial class newPartForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.ForeColor = Color.DarkBlue;
            textBox1.Location = new Point(916, 82);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Назва деталі";
            textBox1.Size = new Size(255, 36);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.ForeColor = Color.DarkBlue;
            textBox2.Location = new Point(916, 130);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Кількість";
            textBox2.Size = new Size(255, 36);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(192, 192, 255);
            textBox3.ForeColor = Color.DarkBlue;
            textBox3.Location = new Point(916, 178);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ціна";
            textBox3.Size = new Size(255, 36);
            textBox3.TabIndex = 1;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(916, 354);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(255, 57);
            button1.TabIndex = 2;
            button1.Text = "Додати деталь";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CornflowerBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(873, 408);
            dataGridView1.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 192, 255);
            textBox4.ForeColor = Color.DarkBlue;
            textBox4.Location = new Point(916, 34);
            textBox4.Margin = new Padding(6);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Код виробника";
            textBox4.Size = new Size(255, 36);
            textBox4.TabIndex = 1;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.DarkBlue;
            radioButton1.Location = new Point(6, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(240, 33);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Новий(з заводу)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.DarkBlue;
            radioButton2.Location = new Point(6, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(161, 33);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Уживаний";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(916, 223);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 122);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Стан";
            // 
            // newPartForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1186, 500);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "newPartForm";
            Text = "Додавання нової деталі";
            Load += newPartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
    }
}