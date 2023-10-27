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

                    string query = "INSERT INTO Customer ([Họ Tên], Email, phone_number, Ngay_Sinh, Gioi_Tinh, Diem_Tich_Luy) VALUES (@name, @email, @sdt,@ns, @GT,@DTL)";
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
                            if (txtSDTKH.Text[0] == '0')
                            {
                                command.Parameters.AddWithValue("@sdt", txtSDTKH.Text);
                            }
                            else
                            {
                                MessageBox.Show("SĐT phải bắt đầu từ 0 và tối đa 10 số!", "Lỗi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Tên và SĐT Khách Hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        if (txtEmailKH.Text != "")
                        {
                            string email = txtEmailKH.Text;
                            int atIndex = email.IndexOf("@");
                            int dotIndex = email.IndexOf(".");
                            bool isValid = atIndex < dotIndex;
                            if (email != "" && email.Contains("@") && email.Contains(".") && isValid)
                            {
                                command.Parameters.AddWithValue("@email", email);
                            }
                            else
                            {
                                MessageBox.Show("Email Không Hợp Lệ!", "Thông Báo!");
                            }
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@email", txtEmailKH.Text);
                        }

                        command.Parameters.AddWithValue("@ns", dtpkNgaySinhKH.Value.ToString());
                        command.Parameters.AddWithValue("@gt", cbbGTinhKH.Text);
                        int i = 10;
                        command.Parameters.AddWithValue("@DTL", i);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm thông tin thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddDataToDGV_Customer();
                        txtIDKH.Text = "";
                        txtTenKH.Text = "";
                        txtSDTKH.Text = "";
                        txtEmailKH.Text = "";
                        cbbGTinhKH.Text = "";
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                
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


                    string query = "UPDATE customer SET [Họ Tên] = @1, Email = @2, phone_number = @3, Ngay_Sinh = @4, Gioi_Tinh = @5 WHERE customer_id = @0";
                    command.CommandText = query;
                    command.Parameters.Clear();



                    if (txtIDKH.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Thông Tin Khách Hàng Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {

                            command.Parameters.AddWithValue("@0", txtIDKH.Text);
                            command.Parameters.AddWithValue("@1", txtTenKH.Text);
                            if (txtEmailKH.Text !="")
                            {
                                string email = txtEmailKH.Text;
                                int atIndex = email.IndexOf("@");
                                int dotIndex = email.IndexOf(".");
                                bool isValid = atIndex < dotIndex;
                                if (email.Contains("@") && email.Contains(".") && isValid)
                                {
                                    command.Parameters.AddWithValue("@2", email);
                                }
                                else
                                {
                                    MessageBox.Show("Email Không Hợp Lệ!", "Thông Báo!");
                                }
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@2", txtEmailKH.Text);
                            }

                            if (txtSDTKH.Text[0] == '0')
                            {
                                command.Parameters.AddWithValue("@3", txtSDTKH.Text);
                            }
                            else
                            {
                                MessageBox.Show("SĐT phải bắt đầu từ 0 và tối đa 10 số!", "Lỗi");
                            }
                            command.Parameters.AddWithValue("@4", dtpkNgaySinhKH.Value.ToString());
                            command.Parameters.AddWithValue("@5", cbbGTinhKH.Text);


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
                            cbbGTinhKH.Text = "";
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
                    
                }
            }
        }

        private void btnTichDiem_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                string query = "Select Diem_Tich_Luy from customer where customer_id = @1";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@1", txtIDKH.Text);
                    
                    if(txtIDKH.Text != "")
                    {
                        i = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Chọn Khách Hàng Muốn Tích Điểm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }


            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    

                    string query = "UPDATE customer SET Diem_Tich_Luy = @1 WHERE customer_id = @0";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    if(txtIDKH.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Tích Điểm Cho Khách Hàng Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {

                            command.Parameters.AddWithValue("@0", txtIDKH.Text);
                            command.Parameters.AddWithValue("@1", i + 10);


                            // Thực thi câu lệnh update
                            command.ExecuteNonQuery();

                            // Hiển thị thông báo sửa thành công
                            MessageBox.Show("Tích Điểm Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }

        private void txtEmailKH_Leave(object sender, EventArgs e)
        {
            if (!txtEmailKH.Text.Contains("@") || !txtEmailKH.Text.Contains("."))
            {
                lblTbEmail.Visible = true;
            }
            else
            {
                lblTbEmail.Visible = false;
            }
        }
    }
}
