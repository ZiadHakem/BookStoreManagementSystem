namespace BookStore.WinForms
{
    partial class HomeAdmin
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
            btOrders = new Button();
            btCustomer = new Button();
            btCategories = new Button();
            btBooks = new Button();
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
            // btOrders
            // 
            btOrders.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btOrders.ForeColor = Color.FromArgb(69, 51, 39);
            btOrders.Location = new Point(36, 179);
            btOrders.Name = "btOrders";
            btOrders.Size = new Size(162, 58);
            btOrders.TabIndex = 1;
            btOrders.Text = "Orders";
            btOrders.UseVisualStyleBackColor = true;
            btOrders.Click += btOrders_Click;
            // 
            // btCustomer
            // 
            btCustomer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            btCustomer.Location = new Point(278, 179);
            btCustomer.Name = "btCustomer";
            btCustomer.Size = new Size(162, 58);
            btCustomer.TabIndex = 2;
            btCustomer.Text = "Customers";
            btCustomer.UseVisualStyleBackColor = true;
            btCustomer.Click += btCustomer_Click;
            // 
            // btCategories
            // 
            btCategories.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btCategories.ForeColor = Color.FromArgb(69, 51, 39);
            btCategories.Location = new Point(278, 293);
            btCategories.Name = "btCategories";
            btCategories.Size = new Size(162, 58);
            btCategories.TabIndex = 3;
            btCategories.Text = "Categories";
            btCategories.UseVisualStyleBackColor = true;
            btCategories.Click += btCategories_Click;
            // 
            // btBooks
            // 
            btBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btBooks.ForeColor = Color.FromArgb(69, 51, 39);
            btBooks.Location = new Point(36, 293);
            btBooks.Name = "btBooks";
            btBooks.Size = new Size(162, 58);
            btBooks.TabIndex = 4;
            btBooks.Text = "Books";
            btBooks.UseVisualStyleBackColor = true;
            btBooks.Click += btBooks_Click;
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
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 450);
            Controls.Add(label1);
            Controls.Add(btBooks);
            Controls.Add(btCategories);
            Controls.Add(btCustomer);
            Controls.Add(btOrders);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btOrders;
        private Button btCustomer;
        private Button btCategories;
        private Button btBooks;
        private Label label1;
    }
}