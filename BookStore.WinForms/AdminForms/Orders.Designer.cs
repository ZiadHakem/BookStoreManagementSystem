namespace BookStore.WinForms
{
    partial class Orders
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
            label2 = new Label();
            BtUpdateOrder = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(379, 1);
            label2.Name = "label2";
            label2.Size = new Size(148, 54);
            label2.TabIndex = 1;
            label2.Text = "Orders";
            // 
            // BtUpdateOrder
            // 
            BtUpdateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtUpdateOrder.ForeColor = Color.FromArgb(69, 51, 39);
            BtUpdateOrder.Location = new Point(634, 388);
            BtUpdateOrder.Name = "BtUpdateOrder";
            BtUpdateOrder.Size = new Size(129, 35);
            BtUpdateOrder.TabIndex = 3;
            BtUpdateOrder.Text = "Update";
            BtUpdateOrder.UseVisualStyleBackColor = true;
            BtUpdateOrder.Click += BtUpdateOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(69, 51, 39);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(928, 309);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(178, 390);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 5;
            label1.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 391);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 28);
            comboBox1.TabIndex = 6;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(BtUpdateOrder);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button BtUpdateOrder;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
    }
}