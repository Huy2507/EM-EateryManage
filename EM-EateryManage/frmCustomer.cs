using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM_EateryManage
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
            AddDataToDGV_Customer();
        }
        public void AddDataToDGV_Customer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "SELECT * FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvKH.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "select * from customer where [Họ Tên] like N'%" + txtTimKH.Text + "%' or customer_id like N'%" + txtTimKH.Text + "%' or phone_number like N'%" + txtTimKH.Text + "%' or email like N'%" + txtTimKH.Text + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvKH.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvKH.Rows[e.RowIndex];
                lblIDKH.Visible = true;
                txtIDKH.Visible = true;
                txtIDKH.Text = selectedRow.Cells[0].Value.ToString();
                txtTenKH.Text = selectedRow.Cells[1].Value.ToString();
                txtEmailKH.Text = selectedRow.Cells[2].Value.ToString();
                txtSDTKH.Text = selectedRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "INSERT INTO Customer ([Họ Tên], Email, phone_number, Ngay_Sinh, Gioi_Tinh) VALUES (@name, @email, @sdt,@ns, @GT)";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    bool userID_Exists = false;
                    int total = dgvKH.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtIDKH.Text == dgvKH.Rows[i].Cells[0].Value.ToString())
                        {
                            userID_Exists = true;
                            break;
                        }
                    }

                    if (userID_Exists)
                    {
                        MessageBox.Show("Khách Hàng Này Đã Tồn Tại, Hãy Chọn Tích Điểm Hoặc Chọn \"Sửa\" Để Thay Đổi Thông Tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenKH.Focus();
                        return;
                    }
                    else
                    {
                        if (txtTenKH.Text != "" && txtSDTKH.Text != "")
                        {
                            command.Parameters.AddWithValue("@name", txtTenKH.Text);
                            command.Parameters.AddWithValue("@sdt", txtSDTKH.Text);
                        }
                        else
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Tên và phone_number Khách Hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        command.Parameters.AddWithValue("@email", txtEmailKH.Text);
                        command.Parameters.AddWithValue("@ns", dtpkNgaySinhKH.Value.ToString());
                        command.Parameters.AddWithValue("@gt", cbbGTinhKH.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm thông tin thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddDataToDGV_Customer();
                        txtIDKH.Text = "";
                        txtTenKH.Text = "";
                        txtSDTKH.Text = "";
                        txtEmailKH.Text = "";
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "UPDATE customer SET [Họ Tên] = @1, Email = @2, phone_number = @3 WHERE customer_id = @0";
                    command.CommandText = query;
                    command.Parameters.Clear();



                    if (txtIDKH.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Thông Tin Khách Hàng Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {

                            command.Parameters.AddWithValue("@0", txtIDKH.Text);
                            command.Parameters.AddWithValue("@1", txtTenKH.Text);
                            command.Parameters.AddWithValue("@2", txtEmailKH.Text);
                            command.Parameters.AddWithValue("@3", txtSDTKH.Text);
                            

                            // Thực thi câu lệnh update
                            command.ExecuteNonQuery();

                            // Hiển thị thông báo sửa thành công
                            MessageBox.Show("Sửa TTKH Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddDataToDGV_Customer();
                            lblIDKH.Visible = false;
                            txtIDKH.Visible = false;
                            txtIDKH.Text = "";
                            txtTenKH.Text = "";
                            txtEmailKH.Text = "";
                            txtSDTKH.Text = "";
                            connection.Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng muốn chỉnh sửa thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "delete from customer WHERE customer_id = @6";
                    command.CommandText = query;
                    command.Parameters.Clear();


                    if (txtIDKH.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Khách Hàng Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@6", txtIDKH.Text);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Thực thi câu lệnh update
                    command.ExecuteNonQuery();

                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa Khách Hàng Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddDataToDGV_Customer();
                    lblIDKH.Visible = false;
                    txtIDKH.Visible = false;
                    txtIDKH.Text = "";
                    txtTenKH.Text = "";
                    txtEmailKH.Text = "";
                    txtSDTKH.Text = "";
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }
    }
}
