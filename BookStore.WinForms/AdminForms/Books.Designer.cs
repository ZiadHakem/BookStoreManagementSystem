namespace BookStore.WinForms.AdminForms
{
    partial class Books
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
            BTDelBook = new Button();
            BTUpdateBook = new Button();
            BTAddBook = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BTDelBook
            // 
            BTDelBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTDelBook.ForeColor = Color.FromArgb(69, 51, 39);
            BTDelBook.Location = new Point(452, 390);
            BTDelBook.Name = "BTDelBook";
            BTDelBook.Size = new Size(136, 43);
            BTDelBook.TabIndex = 11;
            BTDelBook.Text = "Delete";
            BTDelBook.UseVisualStyleBackColor = true;
            // 
            // BTUpdateBook
            // 
            BTUpdateBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTUpdateBook.ForeColor = Color.FromArgb(69, 51, 39);
            BTUpdateBook.Location = new Point(616, 388);
            BTUpdateBook.Name = "BTUpdateBook";
            BTUpdateBook.Size = new Size(136, 43);
            BTUpdateBook.TabIndex = 10;
            BTUpdateBook.Text = "Update";
            BTUpdateBook.UseVisualStyleBackColor = true;
            // 
            // BTAddBook
            // 
            BTAddBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTAddBook.ForeColor = Color.FromArgb(69, 51, 39);
            BTAddBook.Location = new Point(786, 388);
            BTAddBook.Name = "BTAddBook";
            BTAddBook.Size = new Size(136, 43);
            BTAddBook.TabIndex = 9;
            BTAddBook.Text = "Add";
            BTAddBook.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 399);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(33, 395);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 7;
            label2.Text = "Book ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(69, 51, 39);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 302);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(369, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 54);
            label1.TabIndex = 13;
            label1.Text = "Books";
            label1.Click += label1_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(BTDelBook);
            Controls.Add(BTUpdateBook);
            Controls.Add(BTAddBook);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTDelBook;
        private Button BTUpdateBook;
        private Button BTAddBook;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}