namespace BookStore.WinForms.AdminForms
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
            BTAddCustomer = new Button();
            BTViewAndDeleteCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(95, 53);
            label1.Name = "label1";
            label1.Size = new Size(202, 50);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image3;
            pictureBox1.Location = new Point(427, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BTAddCustomer
            // 
            BTAddCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTAddCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            BTAddCustomer.Location = new Point(57, 159);
            BTAddCustomer.Name = "BTAddCustomer";
            BTAddCustomer.Size = new Size(296, 38);
            BTAddCustomer.TabIndex = 2;
            BTAddCustomer.Text = "Add Customer";
            BTAddCustomer.UseVisualStyleBackColor = true;
            BTAddCustomer.Click += button1_Click;
            // 
            // BTViewAndDeleteCustomer
            // 
            BTViewAndDeleteCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTViewAndDeleteCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            BTViewAndDeleteCustomer.Location = new Point(57, 243);
            BTViewAndDeleteCustomer.Name = "BTViewAndDeleteCustomer";
            BTViewAndDeleteCustomer.Size = new Size(296, 38);
            BTViewAndDeleteCustomer.TabIndex = 3;
            BTViewAndDeleteCustomer.Text = "View and Delete Customer";
            BTViewAndDeleteCustomer.UseVisualStyleBackColor = true;
            BTViewAndDeleteCustomer.Click += BTViewAndDeleteCustomer_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(BTViewAndDeleteCustomer);
            Controls.Add(BTAddCustomer);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button BTAddCustomer;
        private Button BTViewAndDeleteCustomer;
    }
}