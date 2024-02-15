namespace BookStore.WinForms
{
    partial class Login
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
            CBAdmin = new CheckBox();
            CBCustomer = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            TBUserName = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img2;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CBAdmin
            // 
            CBAdmin.AutoSize = true;
            CBAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            CBAdmin.ForeColor = SystemColors.Control;
            CBAdmin.Location = new Point(786, 305);
            CBAdmin.Name = "CBAdmin";
            CBAdmin.Size = new Size(96, 32);
            CBAdmin.TabIndex = 1;
            CBAdmin.Text = "Admin";
            CBAdmin.UseVisualStyleBackColor = true;
            // 
            // CBCustomer
            // 
            CBCustomer.AutoSize = true;
            CBCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            CBCustomer.ForeColor = SystemColors.Control;
            CBCustomer.Location = new Point(786, 350);
            CBCustomer.Name = "CBCustomer";
            CBCustomer.Size = new Size(124, 32);
            CBCustomer.TabIndex = 2;
            CBCustomer.Text = "Customer";
            CBCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(521, 184);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(521, 229);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(69, 51, 39);
            button1.Location = new Point(570, 324);
            button1.Name = "button1";
            button1.Size = new Size(129, 42);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TBUserName
            // 
            TBUserName.ForeColor = Color.FromArgb(69, 51, 39);
            TBUserName.Location = new Point(668, 188);
            TBUserName.Name = "TBUserName";
            TBUserName.Size = new Size(164, 27);
            TBUserName.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(69, 51, 39);
            textBox2.Location = new Point(668, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 27);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(624, 75);
            label3.Name = "label3";
            label3.Size = new Size(139, 60);
            label3.TabIndex = 8;
            label3.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(TBUserName);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CBCustomer);
            Controls.Add(CBAdmin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox CBAdmin;
        private CheckBox CBCustomer;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox TBUserName;
        private TextBox textBox2;
        private Label label3;
    }
}