namespace BookStore.WinForms
{
    partial class DeleteAndViewCustomer
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
            label2 = new Label();
            TBDelCustomer = new TextBox();
            BtDelCustomer = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 16);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 293);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 2;
            label2.Text = "Enter Customer ID";
            // 
            // TBDelCustomer
            // 
            TBDelCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            TBDelCustomer.Location = new Point(305, 296);
            TBDelCustomer.Margin = new Padding(3, 2, 3, 2);
            TBDelCustomer.Name = "TBDelCustomer";
            TBDelCustomer.Size = new Size(195, 23);
            TBDelCustomer.TabIndex = 3;
            // 
            // BtDelCustomer
            // 
            BtDelCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtDelCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            BtDelCustomer.Location = new Point(560, 290);
            BtDelCustomer.Margin = new Padding(3, 2, 3, 2);
            BtDelCustomer.Name = "BtDelCustomer";
            BtDelCustomer.Size = new Size(121, 28);
            BtDelCustomer.TabIndex = 4;
            BtDelCustomer.Text = "Delete";
            BtDelCustomer.UseVisualStyleBackColor = true;
            BtDelCustomer.Click += BtDelCustomer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(69, 51, 39);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(4, 53);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 224);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DeleteAndViewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(817, 338);
            Controls.Add(dataGridView1);
            Controls.Add(BtDelCustomer);
            Controls.Add(TBDelCustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteAndViewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += DeleteAndViewCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TBDelCustomer;
        private Button BtDelCustomer;
        private DataGridView dataGridView1;
    }
}