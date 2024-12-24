namespace GUI_mini_insta
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            lblTitle = new Label();
            btnAddAccount = new Button();
            btnRemoveAccount = new Button();
            btnUpdateAccount = new Button();
            btnSendWithPhoneNumber = new Button();
            btnSendWithAccountNumber = new Button();
            btnViewProfile = new Button();
            btnMyTransactions = new Button();
            btnLogout = new Button();
            lblFooter = new Label();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.LightSteelBlue;
            panelSidebar.Controls.Add(lblTitle);
            panelSidebar.Controls.Add(btnAddAccount);
            panelSidebar.Controls.Add(btnRemoveAccount);
            panelSidebar.Controls.Add(btnUpdateAccount);
            panelSidebar.Controls.Add(btnSendWithPhoneNumber);
            panelSidebar.Controls.Add(btnSendWithAccountNumber);
            panelSidebar.Controls.Add(btnViewProfile);
            panelSidebar.Controls.Add(btnMyTransactions);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(204, 483);
            panelSidebar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(171, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcom Back :)";
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(20, 60);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(160, 30);
            btnAddAccount.TabIndex = 1;
            btnAddAccount.Text = "Add Account";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += BtnAddAccount_Click;
            // 
            // btnRemoveAccount
            // 
            btnRemoveAccount.Location = new Point(20, 100);
            btnRemoveAccount.Name = "btnRemoveAccount";
            btnRemoveAccount.Size = new Size(160, 30);
            btnRemoveAccount.TabIndex = 2;
            btnRemoveAccount.Text = "Remove Account";
            btnRemoveAccount.UseVisualStyleBackColor = true;
            btnRemoveAccount.Click += BtnRemoveAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Location = new Point(20, 140);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(160, 30);
            btnUpdateAccount.TabIndex = 3;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += BtnUpdateAccount_Click;
            // 
            // btnSendWithPhoneNumber
            // 
            btnSendWithPhoneNumber.Location = new Point(20, 180);
            btnSendWithPhoneNumber.Name = "btnSendWithPhoneNumber";
            btnSendWithPhoneNumber.Size = new Size(160, 30);
            btnSendWithPhoneNumber.TabIndex = 4;
            btnSendWithPhoneNumber.Text = "Send with Phone";
            btnSendWithPhoneNumber.UseVisualStyleBackColor = true;
            btnSendWithPhoneNumber.Click += BtnSendWithPhoneNumber_Click;
            // 
            // btnSendWithAccountNumber
            // 
            btnSendWithAccountNumber.Location = new Point(20, 220);
            btnSendWithAccountNumber.Name = "btnSendWithAccountNumber";
            btnSendWithAccountNumber.Size = new Size(160, 30);
            btnSendWithAccountNumber.TabIndex = 5;
            btnSendWithAccountNumber.Text = "Send with Account";
            btnSendWithAccountNumber.UseVisualStyleBackColor = true;
            btnSendWithAccountNumber.Click += BtnSendWithAccountNumber_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Location = new Point(20, 260);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(160, 30);
            btnViewProfile.TabIndex = 6;
            btnViewProfile.Text = "View My Profile";
            btnViewProfile.UseVisualStyleBackColor = true;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnMyTransactions
            // 
            btnMyTransactions.Location = new Point(20, 300);
            btnMyTransactions.Name = "btnMyTransactions";
            btnMyTransactions.Size = new Size(160, 30);
            btnMyTransactions.TabIndex = 7;
            btnMyTransactions.Text = "My Transactions";
            btnMyTransactions.UseVisualStyleBackColor = true;
            btnMyTransactions.Click += BtnMyTransactions_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(55, 369);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 30);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            btnLogout.MouseEnter += BtnLogout_MouseEnter;
            btnLogout.MouseLeave += BtnLogout_MouseLeave;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Arial", 8F, FontStyle.Italic, GraphicsUnit.Point);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(220, 400);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(160, 14);
            lblFooter.TabIndex = 1;
            lblFooter.Text = "© 2024 Dashboard GUI Design";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(224, 224, 224);
            panelContent.Location = new Point(201, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(830, 483);
            panelContent.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 483);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(lblFooter);
            Name = "Dashboard";
            Text = "Dashboard";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Label lblTitle;
        private Button btnAddAccount;
        private Button btnRemoveAccount;
        private Button btnUpdateAccount;
        private Button btnSendWithPhoneNumber;
        private Button btnSendWithAccountNumber;
        private Button btnViewProfile;
        private Button btnMyTransactions;
        private Button btnLogout;
        private Label lblFooter;
        private Panel panelContent;
    }
}
