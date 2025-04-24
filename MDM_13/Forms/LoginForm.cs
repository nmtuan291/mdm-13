using MDM_13.Core;
using MDM_13.Forms;
using MDM_13.Models;
using MDM_13.Services;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MDM_13
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            try
            {
                CassandraService.Initialize();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối Cassandra:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1); // hoặc cho phép tiếp tục chạy nếu Cassandra không bắt buộc
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new(this);
            signUpForm.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            User user = SQLService.FindUser(userTextbox.Text, userTextbox.Text, userTextbox.Text);

            if (user == null || !BCrypt.Net.BCrypt.Verify(passwordTextbox.Text, user.PasswordHash))
            {
                wrongPwdMess.Text = "Thông tin đăng nhập không chính xác";
                wrongPwdMess.Visible = true;
                return;
            }

            wrongPwdMess.Visible = false;
            UserSession.userId = user.UserId;
            CassandraService.InsertAccountLog(user.UserId);

            MainForm form = new();
            this.Hide();
            form.Show();
        }
    }
}
