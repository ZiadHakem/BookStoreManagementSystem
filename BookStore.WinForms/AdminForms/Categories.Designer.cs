namespace BookStore.WinForms
{
    partial class Categories
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
            label1 = new Label();
            DGCategories = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            BTAddCategories = new Button();
            BTUpdateCategories = new Button();
            BTDelCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)DGCategories).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(332, 13);
            label1.Name = "label1";
            label1.Size = new Size(205, 50);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // DGCategories
            // 
            DGCategories.BackgroundColor = Color.FromArgb(69, 51, 39);
            DGCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGCategories.Location = new Point(6, 73);
            DGCategories.Name = "DGCategories";
            DGCategories.RowHeadersWidth = 51;
            DGCategories.Size = new Size(916, 290);
            DGCategories.TabIndex = 1;
            DGCategories.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 397);
            label2.Name = "label2";
            label2.Size = new Size(183, 31);
            label2.TabIndex = 2;
            label2.Text = "Category Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 3;
            // 
            // BTAddCategories
            // 
            BTAddCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTAddCategories.ForeColor = Color.FromArgb(69, 51, 39);
            BTAddCategories.Location = new Point(483, 392);
            BTAddCategories.Name = "BTAddCategories";
            BTAddCategories.Size = new Size(136, 43);
            BTAddCategories.TabIndex = 4;
            BTAddCategories.Text = "Add";
            BTAddCategories.UseVisualStyleBackColor = true;
            // 
            // BTUpdateCategories
            // 
            BTUpdateCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTUpdateCategories.ForeColor = Color.FromArgb(69, 51, 39);
            BTUpdateCategories.Location = new Point(635, 392);
            BTUpdateCategories.Name = "BTUpdateCategories";
            BTUpdateCategories.Size = new Size(136, 43);
            BTUpdateCategories.TabIndex = 5;
            BTUpdateCategories.Text = "Update";
            BTUpdateCategories.UseVisualStyleBackColor = true;
            // 
            // BTDelCategories
            // 
            BTDelCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTDelCategories.ForeColor = Color.FromArgb(69, 51, 39);
            BTDelCategories.Location = new Point(787, 392);
            BTDelCategories.Name = "BTDelCategories";
            BTDelCategories.Size = new Size(136, 43);
            BTDelCategories.TabIndex = 6;
            BTDelCategories.Text = "Delete";
            BTDelCategories.UseVisualStyleBackColor = true;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(BTDelCategories);
            Controls.Add(BTUpdateCategories);
            Controls.Add(BTAddCategories);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(DGCategories);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)DGCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGCategories;
        private Label label2;
        private TextBox textBox1;
        private Button BTAddCategories;
        private Button BTUpdateCategories;
        private Button BTDelCategories;
    }
}