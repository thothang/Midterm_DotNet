using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MidTerm_DNet
{
    public partial class frmTour : Form
    {
        private readonly DatabaseConnection dbConnection;

        public frmTour()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTour_Load(object sender, EventArgs e)
        {
            cmbTourType.Items.Clear();
            cmbTourType.Items.Add("High class");
            cmbTourType.Items.Add("Standard");
            cmbTourType.Items.Add("Economy");
            cmbTourType.SelectedIndex = 2;
            cmbTourType.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTransportation.Items.Clear();
            cmbTransportation.Items.Add("Car");
            cmbTransportation.Items.Add("Airplane");
            cmbTransportation.SelectedIndex = 0;
            cmbTransportation.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbSearchTourType.Items.Add("High class");
            cmbSearchTourType.Items.Add("Standard");
            cmbSearchTourType.Items.Add("Economy");
            cmbSearchTourType.SelectedIndex = -1;

            cmbSearchBudget.Items.Add("Under $200");
            cmbSearchBudget.Items.Add("From $200 to $400");
            cmbSearchBudget.Items.Add("From $400 to $800");
            cmbSearchBudget.Items.Add("Over $800");
            cmbSearchBudget.SelectedIndex = -1;

            cmbSearchTransportation.Items.Add("Car");
            cmbSearchTransportation.Items.Add("Airplane");
            cmbSearchTransportation.SelectedIndex = -1;

            chkActive.Checked = true;

            LoadTour();
            dgvTour.ReadOnly = true;
        }

        //Load data tour into dgv
        private void LoadTour()
        {
            int selectedRowIndex = dgvTour.CurrentCell?.RowIndex ?? -1;

            const string query = "SELECT * FROM Tour";
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
                        dgvTour.DataSource = dt;

                        dgvTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvTour.AutoResizeColumns();

                        if (selectedRowIndex >= 0 && selectedRowIndex < dgvTour.Rows.Count)
                        {
                            dgvTour.CurrentCell = dgvTour.Rows[selectedRowIndex].Cells[0];
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

        //Fill the selected data in dgv into the text box
        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTour.Rows[e.RowIndex];

                txtTourName.Text = selectedRow.Cells["TourName"].Value.ToString();
                cmbTourType.Text = selectedRow.Cells["TourType"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                cmbTransportation.Text = selectedRow.Cells["TransportationMethod"].Value.ToString();
                rtbDescription.Text = selectedRow.Cells["Description"].Value.ToString();

                object statusValue = selectedRow.Cells["Status"].Value;
                bool isChecked = statusValue != DBNull.Value && Convert.ToBoolean(statusValue);
                chkActive.Checked = isChecked;
                chkActive.Text = isChecked ? "Active" : "Not Active";
            }
        }

        private void txtTourName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            const string query = "INSERT INTO Tour (TourName, TourType, Price, TransportationMethod, Description, Status) " +
                                 "VALUES (@Name, @Type, @Price, @Transport, @Description, @Status)";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtTourName.Text);
                        command.Parameters.AddWithValue("@Type", cmbTourType.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@Transport", cmbTransportation.Text);
                        command.Parameters.AddWithValue("@Description", rtbDescription.Text);
                        command.Parameters.AddWithValue("@Status", chkActive.Checked ? 1 : 0);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm tour du lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        LoadTour();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tour: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (dgvTour.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tour để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTourId = Convert.ToInt32(dgvTour.SelectedRows[0].Cells["TourID"].Value);
            const string query = "UPDATE Tour SET TourName = @Name, TourType = @Type, Price = @Price, " +
                                 "TransportationMethod = @Transport, Description = @Description, Status = @Status " +
                                 "WHERE TourID = @TourID";

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtTourName.Text);
                        command.Parameters.AddWithValue("@Type", cmbTourType.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@Transport", cmbTransportation.Text);
                        command.Parameters.AddWithValue("@Description", rtbDescription.Text);
                        command.Parameters.AddWithValue("@Status", chkActive.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@TourID", selectedTourId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        LoadTour();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tour: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTour.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tour để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTourId = Convert.ToInt32(dgvTour.SelectedRows[0].Cells["TourID"].Value);
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                const string query = "DELETE FROM Tour WHERE TourID = @TourID";

                try
                {
                    if (dbConnection.TryGetConnection(out SqlConnection connection))
                    {
                        using (connection)
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TourID", selectedTourId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes();
                            LoadTour();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tour: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Search data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTour();
        }

        private void SearchTour()
        {

            if (cmbSearchTourType.SelectedIndex == -1 &&
                cmbSearchTransportation.SelectedIndex == -1 &&
                cmbSearchBudget.SelectedIndex == -1)
            {
                LoadTour();
                return;
            }

            string query = "SELECT * FROM Tour WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (cmbSearchTourType.SelectedIndex != -1)
            {
                query += " AND TourType = @TourType";
                parameters.Add(new SqlParameter("@TourType", cmbSearchTourType.Text));
            }

            if (cmbSearchTransportation.SelectedIndex != -1)
            {
                query += " AND TransportationMethod = @Transport";
                parameters.Add(new SqlParameter("@Transport", cmbSearchTransportation.Text));
            }

            if (cmbSearchBudget.SelectedIndex != -1)
            {
                switch (cmbSearchBudget.SelectedIndex)
                {
                    case 0:
                        query += " AND Price < 200";
                        break;
                    case 1:
                        query += " AND Price BETWEEN 200 AND 400";
                        break;
                    case 2:
                        query += " AND Price BETWEEN 400 AND 800";
                        break;
                    case 3:
                        query += " AND Price > 800";
                        break;
                }
            }

            try
            {
                if (dbConnection.TryGetConnection(out SqlConnection connection))
                {
                    using (connection)
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters.ToArray());

                        using (var adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvTour.DataSource = dt;
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
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbSearchTourType.SelectedIndex = -1;
            cmbSearchTransportation.SelectedIndex = -1;
            cmbSearchBudget.SelectedIndex = -1;
            LoadTour();
        }

        private void cmbSearchTourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTour();
        }

        private void cmbSearchBudget_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTour();
        }

        private void cmbSearchTransportation_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTour();
        }

        //Check data validity
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTourName.Text))
            {
                MessageBox.Show("Tên tour không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Giá tour không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả tour!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        //Clear all text box
        private void ClearTextBoxes()
        {
            txtTourName.Clear();
            txtPrice.Clear();
            rtbDescription.Clear();

            cmbTourType.SelectedIndex = 2;
            cmbTransportation.SelectedIndex = 0;

            chkActive.Checked = true;
        }

        //change operating status
        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                chkActive.Text = "Active";
            }
            else
            {
                chkActive.Text = "Not Active";
            }
        }

        
    }
}
