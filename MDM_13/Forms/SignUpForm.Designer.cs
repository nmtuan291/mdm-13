namespace MDM_13.Forms
{
    partial class SignUpForm
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
        /// 



        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            loginLabel = new Label();
            userTextbox = new TextBox();
            emailTextbox = new TextBox();
            phoneNumberTextbox = new TextBox();
            backButton = new Button();
            passwordTextbox = new TextBox();
            confirmpwdTextbox = new TextBox();
            SignUpButton = new Button();
            SignUpMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-8, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 164);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(514, 58);
            label2.Name = "label2";
            label2.Size = new Size(296, 47);
            label2.TabIndex = 0;
            label2.Text = "MDM GROUP 13";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.FromArgb(255, 127, 80);
            loginLabel.Location = new Point(582, 182);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(123, 32);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "ĐĂNG KÝ";
            // 
            // userTextbox
            // 
            userTextbox.BorderStyle = BorderStyle.FixedSingle;
            userTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextbox.Location = new Point(482, 259);
            userTextbox.Name = "userTextbox";
            userTextbox.PlaceholderText = "Tên đăng nhập";
            userTextbox.Size = new Size(320, 27);
            userTextbox.TabIndex = 8;
            // 
            // emailTextbox
            // 
            emailTextbox.BorderStyle = BorderStyle.FixedSingle;
            emailTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextbox.Location = new Point(482, 308);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.PlaceholderText = "Email";
            emailTextbox.Size = new Size(320, 27);
            emailTextbox.TabIndex = 9;
            // 
            // phoneNumberTextbox
            // 
            phoneNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberTextbox.Location = new Point(482, 355);
            phoneNumberTextbox.Name = "phoneNumberTextbox";
            phoneNumberTextbox.PlaceholderText = "Số điện thoại";
            phoneNumberTextbox.Size = new Size(320, 27);
            phoneNumberTextbox.TabIndex = 10;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(255, 127, 80);
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderColor = Color.FromArgb(255, 127, 80);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(-8, 169);
            backButton.Name = "backButton";
            backButton.Size = new Size(111, 29);
            backButton.TabIndex = 11;
            backButton.Text = "Quay lại";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextbox.Location = new Point(482, 402);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Mật khẩu";
            passwordTextbox.Size = new Size(320, 27);
            passwordTextbox.TabIndex = 12;
            // 
            // confirmpwdTextbox
            // 
            confirmpwdTextbox.BorderStyle = BorderStyle.FixedSingle;
            confirmpwdTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpwdTextbox.Location = new Point(482, 449);
            confirmpwdTextbox.Name = "confirmpwdTextbox";
            confirmpwdTextbox.PlaceholderText = "Nhập lại mật khẩu";
            confirmpwdTextbox.Size = new Size(320, 27);
            confirmpwdTextbox.TabIndex = 13;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.FromArgb(255, 127, 80);
            SignUpButton.Cursor = Cursors.Hand;
            SignUpButton.FlatAppearance.BorderColor = Color.FromArgb(255, 127, 80);
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(568, 529);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(146, 29);
            SignUpButton.TabIndex = 14;
            SignUpButton.Text = "Đăng ký";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignUpMessage
            // 
            SignUpMessage.AutoSize = true;
            SignUpMessage.ForeColor = Color.Red;
            SignUpMessage.Location = new Point(482, 491);
            SignUpMessage.Name = "SignUpMessage";
            SignUpMessage.Size = new Size(38, 15);
            SignUpMessage.TabIndex = 15;
            SignUpMessage.Text = "label1";
            SignUpMessage.Visible = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 729);
            Controls.Add(SignUpMessage);
            Controls.Add(SignUpButton);
            Controls.Add(confirmpwdTextbox);
            Controls.Add(passwordTextbox);
            Controls.Add(backButton);
            Controls.Add(phoneNumberTextbox);
            Controls.Add(emailTextbox);
            Controls.Add(userTextbox);
            Controls.Add(loginLabel);
            Controls.Add(panel1);
            Name = "SignUpForm";
            Text = "SignUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label loginLabel;
        private TextBox userTextbox;
        private TextBox emailTextbox;
        private TextBox phoneNumberTextbox;
        private Button backButton;
        private TextBox passwordTextbox;
        private TextBox confirmpwdTextbox;
        private Button SignUpButton;
        private Label SignUpMessage;
    }
}