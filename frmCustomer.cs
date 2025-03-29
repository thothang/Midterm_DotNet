using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MidTerm_DNet
{
    public partial class frmCustomer : Form
    {
        private readonly DatabaseConnection dbConnection;

        public frmCustomer()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            dgvCustomer.ReadOnly = true;
        }

        //Load data into dgv
        private void LoadCustomers()
        {
            int selectedRowIndex = dgvCustomer.CurrentCell?.RowIndex ?? -1;

            const string query = "SELECT * FROM Customer";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCustomer.DataSource = dt;

                        dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvCustomer.AutoResizeColumns();

                        if (selectedRowIndex >= 0 && selectedRowIndex < dgvCustomer.Rows.Count)
                        {
                            dgvCustomer.CurrentCell = dgvCustomer.Rows[selectedRowIndex].Cells[0];
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (IsPhoneNumberDuplicate(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsEmailDuplicate(txtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string query = "INSERT INTO Customer (FullName, PhoneNumber, Address, Email) VALUES (@Name, @Phone, @Address, @Email)";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        LoadCustomers();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;

            int customerId = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value);

            string query = "UPDATE Customer SET FullName = @Name, PhoneNumber = @Phone, Address = @Address, Email = @Email WHERE CustomerID = @CustomerID";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Check data validity
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit);
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //Clear all text box
        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Focus();
        }

        //Fill the selected data in dgv into the text box
        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCustomer.Rows[e.RowIndex];

                txtName.Text = selectedRow.Cells["FullName"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }

        //check phone for duplicates
        private bool IsPhoneNumberDuplicate(string phone, int? customerId = null)
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE PhoneNumber = @Phone";

            if (customerId.HasValue)
            {
                query += " AND CustomerID <> @CustomerID";
            }

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", phone);

                        if (customerId.HasValue)
                        {
                            command.Parameters.AddWithValue("@CustomerID", customerId.Value);
                        }

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra số điện thoại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //check email for duplicates
        private bool IsEmailDuplicate(string email, int? customerId = null)
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE Email = @Email";

            if (customerId.HasValue)
            {
                query += " AND CustomerID <> @CustomerID";
            }

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        if (customerId.HasValue)
                        {
                            command.Parameters.AddWithValue("@CustomerID", customerId.Value);
                        }

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        private void labID_Click(object sender, EventArgs e)
        {

        }

        //Search customer by name or phone 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCustomers(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomers(txtSearch.Text);
        }

        private void SearchCustomers(string keyword)
        {
            string query = "SELECT * FROM Customer WHERE FullName LIKE @Keyword OR PhoneNumber LIKE @Keyword OR Address LIKE @Keyword";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        using (var adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvCustomer.DataSource = dt;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
