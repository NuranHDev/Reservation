namespace Reservation
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(935, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(935, 313);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.ForeColor = Color.White;
            label1.Location = new Point(379, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 2;
            label1.Text = "Admin Panel";
            // 
            // button1
            // 
            button1.Location = new Point(0, 210);
            button1.Name = "button1";
            button1.Size = new Size(94, 35);
            button1.TabIndex = 3;
            button1.Text = "Axtar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 251);
            button2.Name = "button2";
            button2.Size = new Size(186, 35);
            button2.TabIndex = 4;
            button2.Text = "Hər birini göstər";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(685, 251);
            button3.Name = "button3";
            button3.Size = new Size(136, 35);
            button3.TabIndex = 5;
            button3.Text = "Redaktə et";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 34);
            textBox1.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(192, 251);
            button4.Name = "button4";
            button4.Size = new Size(94, 35);
            button4.TabIndex = 7;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tesdiq edildi", "Gozlenir", "Imtina" });
            comboBox1.Location = new Point(491, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 36);
            comboBox1.TabIndex = 8;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 598);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private ComboBox comboBox1;
    }
}