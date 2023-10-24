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
using System.Xml.Serialization;
using EM_EateryManage;
using System.Text.RegularExpressions;

namespace EM_EateryManage
{
    public partial class frmADMIN : Form
    {
        public frmADMIN()
        {

            InitializeComponent();
        }
        private void frmADMIN_Load(object sender, EventArgs e)
        {
            AddDataToDGV();
            AddDataToDGV_BanAn();
            AddDataToDGV_TaiKhoan();
            AddDataToDGVNV();
        }
        #region Các Hàm Đổ Dữ Liệu Từ CSDL Vào_DGV

        public void AddDataToDGVNV()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "select * from employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvNV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

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


                    string query = "select food_id as N'Mã Món(AUTO)', food_name as N'Tên Món', food_price as N'Giá', food_image as N'Hình Ảnh', food_material as N'Nguyên Liệu Chính', food_detail as N'Mô Tả'\r\nfrom FOOD";
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


                    string query = "SELECT id as N'Mã Bàn(AUTO)', ten_ban as N'Tên Bàn', so_ghe as N'Số Ghế', detail as N'Mô Tả' FROM QuanLyBan";
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

                    
                    string query = "select id as N'Mã Tài Khoản(AUTO)', display_name as N'Tên Hiển Thị', username as N'Tên Tài Khoản', password as N'Mật Khẩu', Chuc_Vu as N'Loại Tài Khoản'\r\nfrom account";
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
        #endregion

        #region Các Hàm Thêm

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "INSERT INTO EMPLOYEE ([Họ Tên], Email, [Vị Trí],SĐT, [Địa Chỉ],[Ngày Vào Làm]) VALUES (@name, @email, @Vitri, @sdt,@Diachi, @Ngayvaolam)";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    bool usernameExists = false;
                    int total = dgvNV.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtIDNV.Text == dgvNV.Rows[i].Cells[0].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }
                    if (usernameExists == false)
                    {

                        if (txtTenNV.Text != "" && txtEmail.Text != "" && cbbViTRi.Text != "")
                        {
                            command.Parameters.AddWithValue("@name", txtTenNV.Text);
                            command.Parameters.AddWithValue("@email", txtEmail.Text);
                        }
                        else
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Tên, Email Và Vị Trí!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        command.Parameters.AddWithValue("@Vitri", cbbViTRi.Text);
                        command.Parameters.AddWithValue("@sdt", txtSDTNV.Text);
                        command.Parameters.AddWithValue("@Diachi", txtDCNV.Text);
                        command.Parameters.AddWithValue("@ngayvaolam", DateTime.Parse(dtpkNgayVaoLam.Text.Replace("/","-")));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm nhân viên thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddDataToDGVNV();
                        txtIDNV.Visible = false;
                        txtIDNV.Text = "";
                        txtTenNV.Text = "";
                        txtEmail.Text = "";
                        cbbViTRi.Text = "";
                        txtSDTNV.Text = "";
                        txtDCNV.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Đã Tồn Tại Mã Nhân Viên Này, Vui Lòng Chọn \"Sửa\"!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenNV.Focus();
                        return;
                    }
                    connection.Close();

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

                    bool usernameExists = false;
                    int total = dgvDSMonAn.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtAdd_TenMon.Text == dgvDSMonAn.Rows[i].Cells[1].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }

                    if (usernameExists)
                    {
                        MessageBox.Show("Món Ăn Đã Tồn Tại, Vui Lòng Đặt Tên Khác Hoặc Chọn \"Sửa\"!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdd_TenMon.Focus();
                        return;
                    }
                    else
                    {
                        if (txtAdd_TenMon.Text != "" && txtAdd_Gia.Text != "")
                        {
                            command.Parameters.AddWithValue("@name", txtAdd_TenMon.Text);
                            command.Parameters.AddWithValue("@price", gia);
                        }
                        else
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Tên và Giá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        command.Parameters.AddWithValue("@Image", txtAdd_LinkIMG.Text);
                        command.Parameters.AddWithValue("@material", cbbCategory.Text);
                        command.Parameters.AddWithValue("@detail", txtAdd_MoTa.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm hàng thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddDataToDGV();
                        txtID_mon.Text = "";
                        txtAdd_TenMon.Text = "";
                        txtAdd_Gia.Text = "";
                        txtAdd_LinkIMG.Text = "";
                        txtAdd_MoTa.Text = "";
                        cbbCategory.Text = "";
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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


                    string query = "INSERT INTO QuanLyBan (ten_Ban, so_ghe,detail, trang_thai) VALUES (@name, @SLGhe,@mota, @tt)";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    bool usernameExists = false;
                    int total = dgvBanAn.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtTenBan.Text == dgvBanAn.Rows[i].Cells[1].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }

                    if (usernameExists)
                    {
                        MessageBox.Show("Bàn Đã Tồn Tại, Vui Lòng Đặt Tên Khác Hoặc Chọn \"Sửa\"!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenBan.Focus();
                        return;
                    }
                    else
                    {
                        if (txtTenBan.Text != "" && cbbSLGhe.Text != "")
                        {
                            command.Parameters.AddWithValue("@name", txtTenBan.Text);
                            command.Parameters.AddWithValue("@SLGhe", cbbSLGhe.Text);
                            command.Parameters.AddWithValue("@mota", txtMota.Text);
                            command.Parameters.AddWithValue("@tt", txttt.Text);
                        }
                        else
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm bàn thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddDataToDGV_BanAn();
                        txtIDBan.Text = "";
                        txtTenBan.Text = "";
                        cbbSLGhe.Text = "2";
                        txtMota.Text = "";
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "INSERT INTO Account (display_name, username, password, Chuc_Vu) VALUES (@1, @2, @3, @4)";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    // Kiểm tra xem tên tài khoản được thêm vào đã tồn tại trong csdl hay chưa
                    bool usernameExists = false;
                    int total = dgvACC.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtTenDN_TK.Text == dgvACC.Rows[i].Cells[2].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }

                    if (usernameExists)
                    {
                        MessageBox.Show("Tài Khoản Đã Tồn Tại, Vui Lòng Đặt Tên Tài Khoản Khác Hoặc Chọn \"Sửa\"!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenDN_TK.Focus();
                        return;
                    }
                    else
                    {
                        if ((txtTenDN_TK.Text == "" || txtTenHT_TK.Text == "" || txtMK_TK.Text == ""))
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTenDN_TK.Focus();
                        }
                        else
                        {
                            // Nếu tên tài khoản không tồn tại và không thiếu bất kì thông tin bắt buộc nào thì thêm tài khoản mới
                            command.Parameters.AddWithValue("@1", txtTenHT_TK.Text);
                            command.Parameters.AddWithValue("@2", txtTenDN_TK.Text);
                            command.Parameters.AddWithValue("@3", txtMK_TK.Text);

                            if (cbLoaiTK_TK.Text == "admin" || cbLoaiTK_TK.Text == "staff")
                            {
                                command.Parameters.AddWithValue("@4", cbLoaiTK_TK.Text);
                            }
                            else
                            {
                                MessageBox.Show("Loại Tài Khoản Không Hợp Lệ!\nVui Lòng Chọn Loại \"admin\" Hoặc \"staff\"!", "Thông Báo");
                                return;
                            }

                            command.ExecuteNonQuery();

                            MessageBox.Show("Thêm Tài Khoản Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddDataToDGV_TaiKhoan();
                            txtID_TK.Text = "";
                            txtTenDN_TK.Text = "";
                            txtTenHT_TK.Text = "";
                            txtMK_TK.Text = "";
                            cbLoaiTK_TK.Text = "staff";
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error Occured: "+ex.Message);
            }
        }
        #endregion

        #region Các Hàm Sửa

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    
                    string query = "UPDATE employee SET [Họ Tên] = @1, Email = @2, [Vị Trí] = @3, SĐT = @4 , [Địa Chỉ] = @5, [Ngày Vào Làm] = @6 WHERE [Mã Nhân Viên(AUTO)] = @0";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    

                    if (txtIDNV.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Thông Tin Nhân Viên Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {

                            command.Parameters.AddWithValue("@0", txtIDNV.Text);
                            command.Parameters.AddWithValue("@1", txtTenNV.Text);
                            command.Parameters.AddWithValue("@2", txtEmail.Text);
                            command.Parameters.AddWithValue("@3", cbbViTRi.Text);
                            command.Parameters.AddWithValue("@4", txtSDTNV.Text);
                            command.Parameters.AddWithValue("@5", txtDCNV.Text);
                            command.Parameters.AddWithValue("@6", dtpkNgayVaoLam.Value.ToString());

                            // Thực thi câu lệnh update
                            command.ExecuteNonQuery();

                            // Hiển thị thông báo sửa thành công
                            MessageBox.Show("Sửa TTNV Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddDataToDGVNV();
                            lblIDNV.Visible = false;
                            txtIDNV.Visible = false;
                            txtIDNV.Text = "";
                            txtTenNV.Text = "";
                            txtEmail.Text = "";
                            cbbViTRi.Text = "";
                            txtSDTNV.Text = "";
                            txtDCNV.Text = "";
                            connection.Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên muốn chỉnh sửa thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }
        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string gia = txtAdd_Gia.Text.ToString().Replace(",", ".");
                    string query = "UPDATE food SET food_name = @1, food_price = @2, food_image = @3, food_material = @4 , food_detail = @5 WHERE food_id = @6";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    bool usernameExists = false;
                    int total = dgvDSMonAn.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtAdd_TenMon.Text == dgvDSMonAn.Rows[i].Cells[1].Value.ToString() && txtID_mon.Text != dgvDSMonAn.Rows[i].Cells[0].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }
                    
                    if(txtID_mon.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Món Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            if (usernameExists)
                            {
                                MessageBox.Show("Món Đã Tồn Tại, Vui Lòng Đặt Tên Món Khác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@1", txtAdd_TenMon.Text);
                                command.Parameters.AddWithValue("@2", gia);
                                command.Parameters.AddWithValue("@3", txtAdd_LinkIMG.Text);
                                command.Parameters.AddWithValue("@4", cbbCategory.Text);
                                command.Parameters.AddWithValue("@5", txtAdd_MoTa.Text);
                                command.Parameters.AddWithValue("@6", txtID_mon.Text);
                                // Thực thi câu lệnh update
                                command.ExecuteNonQuery();

                                // Hiển thị thông báo sửa thành công
                                MessageBox.Show("Sửa Món Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AddDataToDGV();
                                label8.Visible = false;
                                txtID_mon.Visible = false;
                                txtID_mon.Text = "";
                                txtAdd_TenMon.Text = "";
                                txtAdd_Gia.Text = "";
                                txtAdd_LinkIMG.Text = "";
                                txtAdd_MoTa.Text = "";
                                cbbCategory.Text = "";
                                connection.Close();
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn món muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "UPDATE Account SET display_name = @1, username = @2, password = @3, Chuc_Vu = @4 WHERE id = @5";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    // Lấy giá trị của các ô trong DataGridView


                    // Thêm các giá trị vào SqlCommand parameters
                    bool usernameExists = false;
                    int total = dgvACC.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtTenDN_TK.Text == dgvACC.Rows[i].Cells[2].Value.ToString() && txtID_TK.Text != dgvACC.Rows[i].Cells[0].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }
                    if (txtID_TK.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Tài Khoản Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            if (usernameExists)
                            {
                                MessageBox.Show("Tài Khoản Đã Tồn Tại, Vui Lòng Sửa Lại Tên Đăng Nhập Khác!", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@2", txtTenDN_TK.Text);
                                command.Parameters.AddWithValue("@1", txtTenHT_TK.Text);
                                command.Parameters.AddWithValue("@3", txtMK_TK.Text);
                                command.Parameters.AddWithValue("@4", cbLoaiTK_TK.Text);
                                command.Parameters.AddWithValue("@5", txtID_TK.Text);

                                // Thực thi câu lệnh update
                                command.ExecuteNonQuery();

                                // Hiển thị thông báo sửa thành công
                                MessageBox.Show("Sửa Tài Khoản Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AddDataToDGV_TaiKhoan();
                                label1.Visible = false;
                                txtID_TK.Visible = false;
                                txtID_TK.Text = "";
                                txtTenDN_TK.Text = "";
                                txtTenHT_TK.Text = "";
                                txtMK_TK.Text = "";
                                cbLoaiTK_TK.Text = "staff";
                                
                                connection.Close();
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn tài khoản muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }



        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "UPDATE QuanLyBan SET ten_ban = @2, so_ghe = @3, detail =@4 WHERE id = @1";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    bool usernameExists = false;
                    int total = dgvBanAn.Rows.Count - 1;
                    for (int i = 0; i < total; i++)
                    {
                        if (txtTenBan.Text == dgvBanAn.Rows[i].Cells[1].Value.ToString() && txtIDBan.Text != dgvBanAn.Rows[i].Cells[0].Value.ToString())
                        {
                            usernameExists = true;
                            break;
                        }
                    }

                    if (txtIDBan.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Bàn Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            if (usernameExists)
                            {
                                MessageBox.Show("Bàn Đã Tồn Tại, Vui Lòng Đặt Tên Bàn Khác!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtTenBan.Focus();
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@2", txtTenBan.Text);
                                command.Parameters.AddWithValue("@3", cbbSLGhe.Text);
                                command.Parameters.AddWithValue("@4", txtMota.Text);
                                command.Parameters.AddWithValue("@1", txtIDBan.Text);
                                // Thực thi câu lệnh update
                                command.ExecuteNonQuery();

                                // Hiển thị thông báo sửa thành công
                                MessageBox.Show("Sửa Bàn Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AddDataToDGV_BanAn();
                                lblIDBan.Visible = false;
                                txtIDBan.Visible = false;
                                txtIDBan.Text = "";
                                txtTenBan.Text = "";
                                cbbSLGhe.Text = "2";
                                txtMota.Text = "";
                                connection.Close();
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bàn muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }
        #endregion

        #region Các Hàm Xóa

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "delete from employee WHERE [Mã Nhân Viên(AUTO)] = @6";
                    command.CommandText = query;
                    command.Parameters.Clear();


                    if (txtIDNV.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Nhân Viên Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@6", txtIDNV.Text);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Thực thi câu lệnh update
                    command.ExecuteNonQuery();

                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa Nhân Viên Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddDataToDGVNV();
                    lblIDNV.Visible = false;
                    txtIDNV.Visible = false;
                    txtIDNV.Text = "";
                    txtTenNV.Text = "";
                    txtEmail.Text = "";
                    cbbViTRi.Text = "";
                    txtSDTNV.Text = "";
                    txtDCNV.Text = "";
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "delete from food WHERE food_id = @6";
                    command.CommandText = query;
                    command.Parameters.Clear();


                    if (txtID_mon.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Món Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@6", txtID_mon.Text);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn món muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Thực thi câu lệnh update
                    command.ExecuteNonQuery();

                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa Món Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddDataToDGV();
                    label8.Visible = false;
                    txtID_mon.Visible = false;
                    txtID_mon.Text = "";
                    txtAdd_TenMon.Text = "";
                    txtAdd_Gia.Text = "";
                    txtAdd_LinkIMG.Text = "";
                    txtAdd_MoTa.Text = "";
                    cbbCategory.Text = "";
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }



        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "delete from account WHERE id = @6";
                    command.CommandText = query;
                    command.Parameters.Clear();


                    if (txtID_TK.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Tài Khoản Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@6", txtID_TK.Text);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn tài khoản muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Thực thi câu lệnh update
                    command.ExecuteNonQuery();

                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa Tài Khoản Thành Công!", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    AddDataToDGV_TaiKhoan();
                    label1.Visible = false;
                    txtID_TK.Visible = false;
                    txtID_TK.Text = "";
                    txtTenDN_TK.Text = "";
                    txtTenHT_TK.Text = "";
                    txtMK_TK.Text = "";
                    cbLoaiTK_TK.Text = "staff";
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    string query = "delete from quanlyban WHERE id = @6";
                    command.CommandText = query;
                    command.Parameters.Clear();


                    if (txtIDBan.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Bàn Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@6", txtIDBan.Text);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bàn muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Thực thi câu lệnh update
                    command.ExecuteNonQuery();

                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa Bàn Thành Công!", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    AddDataToDGV_BanAn();
                    lblIDBan.Visible = false;
                    txtIDBan.Visible = false;
                    txtIDBan.Text = "";
                    txtTenBan.Text = "";
                    cbbSLGhe.Text = "2";
                    txtMota.Text = "";
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured:" + ex.Message);
                }
            }
        }
        #endregion

        #region Các Hàm Phụ

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvNV.Rows[e.RowIndex];
                lblIDNV.Visible = true;
                txtIDNV.Visible = true;
                txtIDNV.Text  = selectedRow.Cells[0].Value.ToString();
                txtTenNV.Text = selectedRow.Cells[1].Value.ToString();
                txtEmail.Text = selectedRow.Cells[2].Value.ToString();
                txtSDTNV.Text = selectedRow.Cells[4].Value.ToString();
                txtDCNV.Text = selectedRow.Cells[5].Value.ToString();
                dtpkNgayVaoLam.Text = selectedRow.Cells[6].Value.ToString();
                cbbViTRi.Text = selectedRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message);
            }
        }

        private void dgvACC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvACC.Rows[e.RowIndex];
                label1.Visible = true;
                txtID_TK.Visible = true;
                txtID_TK.Text = selectedRow.Cells[0].Value.ToString();
                txtTenHT_TK.Text = selectedRow.Cells[1].Value.ToString();
                txtTenDN_TK.Text = selectedRow.Cells[2].Value.ToString();
                txtMK_TK.Text = selectedRow.Cells[3].Value.ToString();
                cbLoaiTK_TK.Text = selectedRow.Cells[4].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message);
            }

        }

        private void dgvDSMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvDSMonAn.Rows[e.RowIndex];
                label8.Visible = true;
                txtID_mon.Visible = true;
                txtID_mon.Text = selectedRow.Cells[0].Value.ToString();
                txtAdd_TenMon.Text = selectedRow.Cells[1].Value.ToString();
                txtAdd_Gia.Text = selectedRow.Cells[2].Value.ToString();
                txtAdd_LinkIMG.Text = selectedRow.Cells[3].Value.ToString();
                cbbCategory.Text = selectedRow.Cells[4].Value.ToString();
                txtAdd_MoTa.Text = selectedRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message);
            }

        }
        private void dgvBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvBanAn.Rows[e.RowIndex];
                lblIDBan.Visible = true;
                txtIDBan.Visible = true;
                txtIDBan.Text = selectedRow.Cells[0].Value.ToString();
                txtTenBan.Text = selectedRow.Cells[1].Value.ToString();
                cbbSLGhe.Text = selectedRow.Cells[2].Value.ToString();
                txtMota.Text = selectedRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message);
            }
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

            txtAdd_Gia.SelectionStart = cursorPos + 1;
        }

        private void txtAdd_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Các Hàm Tìm Kiếm

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "select * from employee where [Họ Tên] like N'%" + txtTimNV.Text + "%' or [Mã Nhân Viên(AUTO)] like N'%" + txtTimNV.Text + "%' or SĐT like N'%" + txtTimNV.Text + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvNV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;


                    string query = "select food_id as N'Mã Món(AUTO)', food_name as N'Tên Món', food_price as N'Giá', food_image as N'Hình Ảnh', food_material as N'Nguyên Liệu Chính', food_detail as N'Mô Tả' from food where food_name like N'%" + txtTim.Text + "%'";
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
        #endregion

        
    }
}
