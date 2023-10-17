using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM_EateryManage
{
    public partial class frmADMIN : Form
    {
        public frmADMIN()
        {

            InitializeComponent();
        }
        public void AddDataToDGV()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "select food_id as N'Mã Món', food_name as N'Tên Món', food_price as N'Giá', food_image as N'Hình Ảnh', food_material as N'Nguyên Liệu Chính', food_detail as N'Mô Tả'\r\nfrom FOOD";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvDSMonAn.DataSource = dataTable;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }
        public void AddDataToDGV_BanAn()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "SELECT id as N'Mã Bàn(Auto)', ten_ban as N'Tên Bàn', so_ghe as N'Số Ghế' FROM QuanLyBan";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvBanAn.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        public void AddDataToDGV_TaiKhoan()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "select id as N'Mã Tài Khoản', display_name as N'Tên Hiển Thị', username as N'Tên Tài Khoản', password as N'Mật Khẩu', Chuc_Vu as N'Loại Tài Khoản'\r\nfrom account";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvACC.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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

                    string gia = txtAdd_Gia.Text.ToString().Replace(",", ".");
                    string query = "INSERT INTO FOOD ( food_name, food_price, food_image,food_material, food_detail) VALUES (@name, @price, @Image, @material, @detail)";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    if (txtAdd_TenMon.Text != "" && txtAdd_Gia.Text != "")
                    {
                        command.Parameters.AddWithValue("@name", txtAdd_TenMon.Text);
                        command.Parameters.AddWithValue("@price", gia);
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Nhập Đầy Đủ Tên và Giá!", "Thông Báo");
                    }
                    command.Parameters.AddWithValue("@Image", txtAdd_LinkIMG.Text);
                    command.Parameters.AddWithValue("@material", txtAdd_Loai.Text);
                    command.Parameters.AddWithValue("@detail", txtAdd_MoTa.Text);

                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Thêm hàng thành công!");
                    AddDataToDGV();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Giá trị giá tiền không hợp lệ!");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void frmADMIN_Load(object sender, EventArgs e)
        {
            AddDataToDGV();
            AddDataToDGV_BanAn();
            AddDataToDGV_TaiKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void txtAdd_Gia_TextChanged(object sender, EventArgs e)
        {
            int cursorPos = txtAdd_Gia.SelectionStart;

            if (!string.IsNullOrWhiteSpace(txtAdd_Gia.Text))
            {
                if (double.TryParse(txtAdd_Gia.Text, out double value))
                {
                    txtAdd_Gia.Text = value.ToString("#,###");
                    
                }
                
            }

            txtAdd_Gia.SelectionStart = cursorPos+1;
        }

        private void txtAdd_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void tpThucAn_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimMon_Click(object sender, EventArgs e)
        {

        }

        private void txtAdd_TenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_LinkIMG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_Loai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_MoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void tpBanAn_Click(object sender, EventArgs e)
        {

        }

        private void tpDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDisplayBill_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpkNgayDi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpkNgayDen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_DM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDM_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {

        }

        private void btnXemDM_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    
                    string query = "INSERT INTO QuanLyBan (ten_Ban, so_ghe) VALUES (@name, @SLGhe)";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    if ( txtTenBan.Text != "" && cbbSLGhe.Text != "")
                    {
                        command.Parameters.AddWithValue("@name", txtTenBan.Text);
                        command.Parameters.AddWithValue("@SLGhe", cbbSLGhe.Text);
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Nhập Đầy Đủ!", "Thông Báo");
                    }
                    

                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm bàn thành công!");
                    AddDataToDGV_BanAn();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Giá trị giá tiền không hợp lệ!");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "INSERT INTO Account (display_name, username, password, Chuc_Vu) VALUES (@1, @2, @3, @4)";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    // Kiểm tra xem tên tài khoản được thêm vào đã tồn tại trong csdl hay chưa
                    bool usernameExists = false;
                    int total = dgvACC.Rows.Count-1;
                    for (int i =0; i<total; i++)
                    {
                        if (txtTenDN_TK.Text == dgvACC.Rows[i].Cells[2].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }

                    if (usernameExists)
                    {
                        MessageBox.Show("Tài Khoản Đã Tồn Tại!", "Thông Báo!");
                        return;
                    }
                    else
                    {
                        // Nếu tên tài khoản không tồn tại, thì thêm tài khoản mới
                        command.Parameters.AddWithValue("@1", txtTenHT_TK.Text);
                        command.Parameters.AddWithValue("@2", txtTenDN_TK.Text);
                        command.Parameters.AddWithValue("@3", txtMK_TK.Text);

                        if (cbLoaiTK_TK.Text == "admin" || cbLoaiTK_TK.Text == "staff")
                        {
                            command.Parameters.AddWithValue("@4", cbLoaiTK_TK.Text);
                        }
                        else
                        {
                            MessageBox.Show("Loại Tài Khoản Không Hợp Lệ!\nVui Lòng Chọn Loại admin Hoặc staff!", "Thông Báo");
                            return;
                        }

                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm Tài Khoản Thành Công!");
                        AddDataToDGV_TaiKhoan();
                    }

                    
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Giá trị giá tiền không hợp lệ!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
