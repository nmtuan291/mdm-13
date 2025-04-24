using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDM_13.Services;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MDM_13.Forms
{
    public partial class SignUpForm : Form

    {
        private LoginForm? _previousForm;
        private bool _returnBack = false;

        public SignUpForm()
        {
            InitializeComponent();

        }

        public SignUpForm(LoginForm previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            this.FormClosed += SignUpForm_FormClosed;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (_previousForm != null)
            {
                _returnBack = true;
                _previousForm.Show();
                this.Close();
            }
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_returnBack)
                Application.Exit();
        }

        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            var user = SQLService.FindUser(userTextbox.Text, emailTextbox.Text, phoneNumberTextbox.Text);

            var collection = MongoDBService.GetCollection("users");
/*
            BsonDocument user = await collection.Find(Builders<BsonDocument>.Filter.Or(
                    Builders<BsonDocument>.Filter.Eq("userName", userTextbox.Text),
                    Builders<BsonDocument>.Filter.Eq("email", emailTextbox.Text),
                    Builders<BsonDocument>.Filter.Eq("phoneNumber", phoneNumberTextbox.Text)
                )).FirstOrDefaultAsync();*/

            if (user != null)
            {
                SignUpMessage.Text = "Tên đăng nhập, email hoặc số điện thoại đã tồn tại";
                SignUpMessage.Visible = true;
                return;
            }

            if (passwordTextbox.Text != confirmpwdTextbox.Text)
            {
                SignUpMessage.Text = "Xác nhận mật khẩu không chính xác";
                SignUpMessage.Visible = true;
                return;
            }

            string userId = Guid.NewGuid().ToString();
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(passwordTextbox.Text);

            SQLService.InsertUser(userId, userTextbox.Text, emailTextbox.Text, phoneNumberTextbox.Text, passwordHash);

            BsonDocument doc = new()
            {
                { "_id", userId},
                { "userName", userTextbox.Text },
                { "email", emailTextbox.Text },
                { "phoneNumber", phoneNumberTextbox.Text }
            };

            await collection.InsertOneAsync(doc);

            SignUpMessage.Visible = true;
            SignUpMessage.ForeColor = Color.Green;
            SignUpMessage.Text = "Đăng ký thành công";
        }
    }
}
