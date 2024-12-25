namespace GUI_mini_insta
{
    partial class Admin
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            suspend = new Button();
            view = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            transaction = new Button();
            listBox1 = new ListBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 14);
            label1.Name = "label1";
            label1.Size = new Size(347, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Admin Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Select User";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // suspend
            // 
            suspend.Location = new Point(12, 140);
            suspend.Name = "suspend";
            suspend.Size = new Size(75, 23);
            suspend.TabIndex = 3;
            suspend.Text = "Suspend";
            suspend.UseVisualStyleBackColor = true;
            suspend.Click += suspend_Click;
            // 
            // view
            // 
            view.Location = new Point(12, 169);
            view.Name = "view";
            view.Size = new Size(89, 23);
            view.TabIndex = 4;
            view.Text = "View Profile";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 5;
            label3.Text = "Generate Report";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Transaction Summary", "Account Usage Analysis" });
            comboBox2.Location = new Point(110, 252);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(12, 281);
            button3.Name = "button3";
            button3.Size = new Size(219, 23);
            button3.TabIndex = 7;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // transaction
            // 
            transaction.BackColor = Color.SeaGreen;
            transaction.ForeColor = SystemColors.ButtonHighlight;
            transaction.Location = new Point(40, 349);
            transaction.Name = "transaction";
            transaction.Size = new Size(163, 30);
            transaction.TabIndex = 8;
            transaction.Text = "View All Transactions";
            transaction.UseVisualStyleBackColor = false;
            transaction.Click += transaction_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(387, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 274);
            listBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(380, 80);
            label4.Name = "label4";
            label4.Size = new Size(135, 30);
            label4.TabIndex = 10;
            label4.Text = "Notifications";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(transaction);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(view);
            Controls.Add(suspend);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button suspend;
        private Button view;
        private Label label3;
        private ComboBox comboBox2;
        private Button button3;
        private Button transaction;
        private ListBox listBox1;
        private Label label4;
    }
}