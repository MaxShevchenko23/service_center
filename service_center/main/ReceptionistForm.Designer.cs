namespace service_center.main
{
    partial class ReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistForm));
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            timeBox = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(431, 496);
            button1.Name = "button1";
            button1.Size = new Size(1032, 196);
            button1.TabIndex = 0;
            button1.Text = "Прийняти замовлення";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(431, 118);
            button2.Name = "button2";
            button2.Size = new Size(1020, 201);
            button2.TabIndex = 1;
            button2.Text = "Видати замовлення";
            button2.UseVisualStyleBackColor = false;
            button2.Click += handOutOrder;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(886, 342);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // timeBox
            // 
            timeBox.AutoSize = true;
            timeBox.Font = new Font("ROG Fonts v1.6", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            timeBox.ForeColor = Color.FromArgb(128, 255, 128);
            timeBox.Location = new Point(-2, -4);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(100, 32);
            timeBox.TabIndex = 3;
            timeBox.Text = "label1";
            // 
            // ReceptionistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1842, 875);
            Controls.Add(timeBox);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ReceptionistForm";
            Text = "ReceptionistForm";
            WindowState = FormWindowState.Maximized;
            Load += ReceptionistForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label timeBox;
    }
}