namespace service_center.functional.forEmployee
{
    partial class preCountingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preCountingForm));
            parts = new DataGridView();
            services = new DataGridView();
            partsToCount = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            servicesToCount = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)parts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)services).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partsToCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicesToCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // parts
            // 
            parts.BackgroundColor = Color.CornflowerBlue;
            parts.BorderStyle = BorderStyle.None;
            parts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            parts.DefaultCellStyle = dataGridViewCellStyle1;
            parts.Location = new Point(22, 12);
            parts.Name = "parts";
            parts.RowTemplate.Height = 25;
            parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            parts.Size = new Size(614, 315);
            parts.TabIndex = 0;
            // 
            // services
            // 
            services.BackgroundColor = Color.CornflowerBlue;
            services.BorderStyle = BorderStyle.None;
            services.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            services.Location = new Point(22, 380);
            services.Name = "services";
            services.RowTemplate.Height = 25;
            services.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            services.Size = new Size(614, 315);
            services.TabIndex = 0;
            // 
            // partsToCount
            // 
            partsToCount.BackgroundColor = Color.CornflowerBlue;
            partsToCount.BorderStyle = BorderStyle.None;
            partsToCount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsToCount.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            partsToCount.Location = new Point(753, 12);
            partsToCount.Name = "partsToCount";
            partsToCount.RowTemplate.Height = 25;
            partsToCount.Size = new Size(614, 315);
            partsToCount.TabIndex = 0;
            partsToCount.RowsAdded += partsToCount_RowsAdded;
            // 
            // Column1
            // 
            Column1.HeaderText = "Виробник";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Назва";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Ціна";
            Column3.Name = "Column3";
            // 
            // servicesToCount
            // 
            servicesToCount.BackgroundColor = Color.CornflowerBlue;
            servicesToCount.BorderStyle = BorderStyle.None;
            servicesToCount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesToCount.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5 });
            servicesToCount.DefaultCellStyle = dataGridViewCellStyle1;
            servicesToCount.Location = new Point(753, 380);
            servicesToCount.Name = "servicesToCount";
            servicesToCount.RowTemplate.Height = 25;
            servicesToCount.Size = new Size(614, 315);
            servicesToCount.TabIndex = 0;
            servicesToCount.CellContentClick += servicesToCount_CellContentClick;
            servicesToCount.RowsAdded += servicesToCount_RowsAdded;
            // 
            // Column4
            // 
            Column4.HeaderText = "Назва";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Ціна";
            Column5.Name = "Column5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(791, 727);
            label1.Name = "label1";
            label1.Size = new Size(126, 42);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(647, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(647, 481);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // preCountingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1388, 791);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(servicesToCount);
            Controls.Add(services);
            Controls.Add(partsToCount);
            Controls.Add(parts);
            Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "preCountingForm";
            Text = "Підрахунок";
            Load += preCountingForm_Load;
            ((System.ComponentModel.ISupportInitialize)parts).EndInit();
            ((System.ComponentModel.ISupportInitialize)services).EndInit();
            ((System.ComponentModel.ISupportInitialize)partsToCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicesToCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView parts;
        private DataGridView services;
        private DataGridView partsToCount;
        private DataGridView servicesToCount;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}