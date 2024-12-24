namespace GUI_mini_insta
{
    partial class Register
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegister = new Button();
            lblMessage = new Label();
            label6 = new Label();
            btnGoToLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(75, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(99, 23);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(75, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(123, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(75, 217);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(99, 23);
            txtAddress.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(75, 261);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(128, 23);
            txtPhone.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 264);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Phone";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 304);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(162, 23);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(12, 336);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(38, 15);
            lblMessage.TabIndex = 11;
            lblMessage.Text = "label6";
            lblMessage.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 29);
            label6.Name = "label6";
            label6.Size = new Size(176, 15);
            label6.TabIndex = 12;
            label6.Text = "Welcome To our Mini_Instapay";
            // 
            // btnGoToLogin
            // 
            btnGoToLogin.BackColor = Color.GhostWhite;
            btnGoToLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnGoToLogin.Location = new Point(12, 363);
            btnGoToLogin.Name = "btnGoToLogin";
            btnGoToLogin.Size = new Size(104, 23);
            btnGoToLogin.TabIndex = 13;
            btnGoToLogin.Text = "Login Page";
            btnGoToLogin.UseVisualStyleBackColor = false;
            btnGoToLogin.Click += btnGoToLogin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(btnGoToLogin);
            Controls.Add(label6);
            Controls.Add(lblMessage);
            Controls.Add(btnRegister);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegister;
        private Label lblMessage;
        private Label label6;
        private Button btnGoToLogin;
    }
}