namespace BookStore.WinForms
{
    partial class Home
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
            pictureBox1 = new PictureBox();
            btnAddBook = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image6;
            pictureBox1.Location = new Point(483, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btnAddBook.ForeColor = Color.FromArgb(69, 51, 39);
            btnAddBook.Location = new Point(36, 179);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(162, 58);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Orders";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.FromArgb(69, 51, 39);
            button2.Location = new Point(278, 179);
            button2.Name = "button2";
            button2.Size = new Size(162, 58);
            button2.TabIndex = 2;
            button2.Text = "Customers";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.FromArgb(69, 51, 39);
            button3.Location = new Point(278, 293);
            button3.Name = "button3";
            button3.Size = new Size(162, 58);
            button3.TabIndex = 3;
            button3.Text = "Categories";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.FromArgb(69, 51, 39);
            button4.Location = new Point(36, 293);
            button4.Name = "button4";
            button4.Size = new Size(162, 58);
            button4.TabIndex = 4;
            button4.Text = "Books";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(5, 31);
            label1.Name = "label1";
            label1.Size = new Size(477, 54);
            label1.TabIndex = 5;
            label1.Text = "Books Store Mangement";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAddBook);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAddBook;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}