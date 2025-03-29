using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace MidTerm_DNet
{
    public partial class frmLogin : Form
    {
        private readonly DatabaseConnection dbConnection;

        public frmLogin()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            ConfigureControls();
        }

        private void ConfigureControls()
        {
            txtPassWord.PasswordChar = '*';
            txtPassWord.UseSystemPasswordChar = true;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPassWord.Text; 

            // Input validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            const string query = "SELECT Role FROM UserAccount WHERE Username = @username AND PasswordHash = @password";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            HandleSuccessfulLogin(result.ToString().ToLower());
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                        }
        
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến database!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}");
            }
        }

        private void HandleSuccessfulLogin(string role)
        {
            MessageBox.Show($"Đăng nhập thành công! Vai trò : {role}");

            switch (role)
            {
                case "admin":
                    NavigateToDashboard();
                    break;
                case "staff":
                    NavigateToUserInterface();
                    break;
                default:
                    MessageBox.Show("Vai trò không hợp lệ!");
                    break;
            }
        }

        private void NavigateToDashboard()
        {
            using (var dashboard = new Dashboard())
            {
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
        }

        private void NavigateToUserInterface()
        {
         
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}