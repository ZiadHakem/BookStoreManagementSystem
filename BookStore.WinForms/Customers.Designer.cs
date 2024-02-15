namespace BookStore.WinForms
{
    partial class Customers
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
            pictureBox1 = new PictureBox();
            BtUpdateCustomer = new Button();
            BtDelCustomer = new Button();
            BtAddCustomer = new Button();
            BtViewCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(88, 58);
            label1.Name = "label1";
            label1.Size = new Size(186, 50);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image8;
            pictureBox1.Location = new Point(395, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(539, 454);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtUpdateCustomer
            // 
            BtUpdateCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtUpdateCustomer.Location = new Point(36, 195);
            BtUpdateCustomer.Name = "BtUpdateCustomer";
            BtUpdateCustomer.Size = new Size(127, 39);
            BtUpdateCustomer.TabIndex = 2;
            BtUpdateCustomer.Text = "Udate";
            BtUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // BtDelCustomer
            // 
            BtDelCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtDelCustomer.Location = new Point(207, 195);
            BtDelCustomer.Name = "BtDelCustomer";
            BtDelCustomer.Size = new Size(127, 39);
            BtDelCustomer.TabIndex = 3;
            BtDelCustomer.Text = "Delete";
            BtDelCustomer.UseVisualStyleBackColor = true;
            BtDelCustomer.Click += button2_Click;
            // 
            // BtAddCustomer
            // 
            BtAddCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtAddCustomer.Location = new Point(36, 278);
            BtAddCustomer.Name = "BtAddCustomer";
            BtAddCustomer.Size = new Size(127, 39);
            BtAddCustomer.TabIndex = 4;
            BtAddCustomer.Text = "Add";
            BtAddCustomer.UseVisualStyleBackColor = true;
            BtAddCustomer.Click += button3_Click;
            // 
            // BtViewCustomer
            // 
            BtViewCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtViewCustomer.Location = new Point(207, 278);
            BtViewCustomer.Name = "BtViewCustomer";
            BtViewCustomer.Size = new Size(127, 39);
            BtViewCustomer.TabIndex = 5;
            BtViewCustomer.Text = "View";
            BtViewCustomer.UseVisualStyleBackColor = true;
            BtViewCustomer.Click += button4_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(BtViewCustomer);
            Controls.Add(BtAddCustomer);
            Controls.Add(BtDelCustomer);
            Controls.Add(BtUpdateCustomer);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button BtUpdateCustomer;
        private Button BtDelCustomer;
        private Button BtAddCustomer;
        private Button BtViewCustomer;
    }
}