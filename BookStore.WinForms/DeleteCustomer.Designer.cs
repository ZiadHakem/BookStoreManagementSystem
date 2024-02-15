namespace BookStore.WinForms
{
    partial class DeleteCustomer
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
            label2 = new Label();
            TBDelCustomer = new TextBox();
            BtDelCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 39);
            label1.Name = "label1";
            label1.Size = new Size(286, 46);
            label1.TabIndex = 0;
            label1.Text = "Delete Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image1;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(472, 194);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 2;
            label2.Text = "Enter Customer ID";
            // 
            // TBDelCustomer
            // 
            TBDelCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            TBDelCustomer.Location = new Point(674, 198);
            TBDelCustomer.Name = "TBDelCustomer";
            TBDelCustomer.Size = new Size(222, 27);
            TBDelCustomer.TabIndex = 3;
            // 
            // BtDelCustomer
            // 
            BtDelCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtDelCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            BtDelCustomer.Location = new Point(631, 303);
            BtDelCustomer.Name = "BtDelCustomer";
            BtDelCustomer.Size = new Size(119, 37);
            BtDelCustomer.TabIndex = 4;
            BtDelCustomer.Text = "Delete";
            BtDelCustomer.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(BtDelCustomer);
            Controls.Add(TBDelCustomer);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Customer";
            Load += DeleteCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox TBDelCustomer;
        private Button BtDelCustomer;
    }
}