namespace BookStore.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(129, 133);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(255, 27);
            textBoxPassword.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(129, 70);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(255, 27);
            textBoxUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(206, 216);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 450);
            Controls.Add(btnLogin);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxPassword);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private Button btnLogin;
    }
}
