namespace GUI_mini_insta
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
            txtEmail = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            txtOtp = new TextBox();
            label3 = new Label();
            btnVerifyOtp = new Button();
            lblMessage = new Label();
            lblTitle = new Label();
            back = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 74);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(98, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 28);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 139);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(23, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(23, 276);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(245, 23);
            txtOtp.TabIndex = 5;
            txtOtp.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 258);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 6;
            label3.Text = "Please Enter Your OTP";
            label3.Visible = false;
            // 
            // btnVerifyOtp
            // 
            btnVerifyOtp.Location = new Point(98, 314);
            btnVerifyOtp.Name = "btnVerifyOtp";
            btnVerifyOtp.Size = new Size(90, 28);
            btnVerifyOtp.TabIndex = 7;
            btnVerifyOtp.Text = "Verify";
            btnVerifyOtp.UseVisualStyleBackColor = true;
            btnVerifyOtp.Visible = false;
            btnVerifyOtp.Click += btnVerifyOtp_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(125, 345);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(36, 15);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Email";
            lblMessage.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(20, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 30);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Sign In";
            // 
            // back
            // 
            back.Location = new Point(240, 19);
            back.Name = "back";
            back.Size = new Size(44, 23);
            back.TabIndex = 10;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(back);
            Controls.Add(lblTitle);
            Controls.Add(lblMessage);
            Controls.Add(btnVerifyOtp);
            Controls.Add(label3);
            Controls.Add(txtOtp);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtOtp;
        private Label label3;
        private Button btnVerifyOtp;
        private Label lblMessage;
        private Label lblTitle;
        private Button back;
    }
}