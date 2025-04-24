namespace MDM_13
{
    partial class LoginForm
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
            button1 = new Button();
            userTextbox = new TextBox();
            passwordTextbox = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            loginLabel = new Label();
            wrongPwdMess = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 127, 80);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 127, 80);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(577, 464);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 0;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userTextbox
            // 
            userTextbox.BorderStyle = BorderStyle.FixedSingle;
            userTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextbox.Location = new Point(491, 295);
            userTextbox.Name = "userTextbox";
            userTextbox.PlaceholderText = "Tên đăng nhập/Email/Số điện thoại";
            userTextbox.Size = new Size(320, 27);
            userTextbox.TabIndex = 1;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextbox.Location = new Point(491, 338);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Mật khẩu";
            passwordTextbox.Size = new Size(320, 27);
            passwordTextbox.TabIndex = 2;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(732, 402);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng ký ngay";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(628, 402);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 4;
            label1.Text = "Chưa có tài khoản?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 171);
            panel1.TabIndex = 5;
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
            loginLabel.Location = new Point(575, 224);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(161, 32);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "ĐĂNG NHẬP";
            // 
            // wrongPwdMess
            // 
            wrongPwdMess.AutoSize = true;
            wrongPwdMess.ForeColor = Color.Red;
            wrongPwdMess.Location = new Point(491, 377);
            wrongPwdMess.Name = "wrongPwdMess";
            wrongPwdMess.Size = new Size(201, 15);
            wrongPwdMess.TabIndex = 7;
            wrongPwdMess.Text = "Thông tin đăng nhập chưa chính xác";
            wrongPwdMess.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 729);
            Controls.Add(wrongPwdMess);
            Controls.Add(loginLabel);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(passwordTextbox);
            Controls.Add(userTextbox);
            Controls.Add(button1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox userTextbox;
        private TextBox passwordTextbox;
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label loginLabel;
        private Label wrongPwdMess;
    }
}
