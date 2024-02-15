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
            BtViewOrders = new Button();
            BtUpdateOrder = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(50, 31);
            label2.Name = "label2";
            label2.Size = new Size(148, 54);
            label2.TabIndex = 1;
            label2.Text = "Orders";
            // 
            // BtViewOrders
            // 
            BtViewOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtViewOrders.ForeColor = Color.FromArgb(69, 51, 39);
            BtViewOrders.Location = new Point(48, 176);
            BtViewOrders.Name = "BtViewOrders";
            BtViewOrders.Size = new Size(156, 58);
            BtViewOrders.TabIndex = 2;
            BtViewOrders.Text = "View Orders";
            BtViewOrders.UseVisualStyleBackColor = true;
            BtViewOrders.Click += button1_Click;
            // 
            // BtUpdateOrder
            // 
            BtUpdateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtUpdateOrder.ForeColor = Color.FromArgb(69, 51, 39);
            BtUpdateOrder.Location = new Point(48, 290);
            BtUpdateOrder.Name = "BtUpdateOrder";
            BtUpdateOrder.Size = new Size(156, 58);
            BtUpdateOrder.TabIndex = 3;
            BtUpdateOrder.Text = "Update Order";
            BtUpdateOrder.UseVisualStyleBackColor = true;
            BtUpdateOrder.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imag4;
            pictureBox1.Location = new Point(254, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(679, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(pictureBox1);
            Controls.Add(BtUpdateOrder);
            Controls.Add(BtViewOrders);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button BtViewOrders;
        private Button BtUpdateOrder;
        private PictureBox pictureBox1;
    }
}