using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EM_EateryManage
{
    public partial class frmTableInfo : Form
    {
        public string TableID { get; set; }
        public string tt { get; set; }
        public frmTableInfo(string tableID)
        {
            InitializeComponent();
            TableID = tableID;
        }

        private void btnExitTbInfo_Click(object sender, EventArgs e)
        {
            RecallLoadTB?.Invoke(this, EventArgs.Empty);
            this.Close();

        }
        public event EventHandler RecallLoadTB;
        public void btnConfirmTbInfo_Click(object sender, EventArgs e)
        {
            if (cbTT.Text != tt)
            {
                try
                {
                    string query = "UPDATE QuanLyBan SET trang_thai = @tt WHERE id = @id";
                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@tt", cbTT.Text);
                        cmd.Parameters.AddWithValue("@id", TableID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thay Đổi Trạng Thái Thành Công !!!", "Thông Báo !");
                    RecallLoadTB?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!");
                }
            }

            this.Close();
        }
        public void LoadTableInfo()
        {
            cbDT.Items.Clear();
            dtpDatTruoc.Value =DateTime.Now;
            try
            {
                string query = "SELECT t.id, t.ten_ban, t.so_ghe, t.trang_thai, t.detail, dt.id, dt.time_dt, dt.cus_id FROM QuanLyBan t LEFT JOIN dat_truoc dt ON t.id = dt.id_table where t.id = @id";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", TableID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtIDBan.Text = reader.GetInt32(0).ToString();
                        txtTenBan.Text = reader.GetString(1);
                        txtSoGhe.Text = reader.GetInt32(2).ToString();
                        cbTT.Text = reader.GetString(3);
                        if (!reader.IsDBNull(6))
                        {
                            DateTime dateTime = reader.GetDateTime(6);
                            string timedt = dateTime.ToString("dd/MM/yyyy HH:mm");
                            cbDT.Items.Add(timedt);
                        }
                        else
                        {
                            string timeTable = "";
                            cbDT.Items.Add(timeTable);
                        }
                        txtDetail.Text = reader.GetString(4);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
        public void ClearDatTruoc()
        {
            txtIDDT.Text = "";
            cbGio.Text = "";
            cbPhut.Text = "";
            txtSdt.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDDT.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Đặt Trước Muốn Xóa !", "Thông Báo !!!");
                return;
            }
            try
            {
                int id = int.Parse(txtIDDT.Text);
                DialogResult result = MessageBox.Show("Bạn Có Chắc Muốn Xóa Đặt Bàn Trước Này ?", "Xác Nhận Xóa Đặt Trước", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM DAT_TRUOC WHERE ID = @id";
                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đặt Trước Đã Được Xóa Thành Công !", "Thông Báo !!!");
                            lblid.Visible = txtIDDT.Visible = false;
                            LoadTableInfo();
                            ClearDatTruoc();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
        #region Nút Cập Nhật 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDDT.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Đặt Trước Muốn Cập Nhật !", "Thông Báo !!!");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query1 = "SELECT customer_id FROM CUSTOMER WHERE phone_number = @sdt";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query1, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                    object result = cmd.ExecuteScalar();
                    int? customerID = result != null ? Convert.ToInt32(result) : (int?)null;
                    if (customerID != null)
                    {
                        string tdt = dtpDatTruoc.Text.ToString() + " " + cbGio.Text + ":" + cbPhut.Text;
                        string format = "dd/MM/yyyy HH:mm";
                        DateTime timedt;
                        timedt = DateTime.ParseExact(tdt, format, CultureInfo.InvariantCulture);
                        string query = "UPDATE DAT_TRUOC SET id_table = @id, time_dt = @dattruoc, cus_id = @cusid WHERE id = @iddt AND cus_id IN (SELECT customer_id FROM CUSTOMER)";
                        using (SqlConnection connection1 = new SqlConnection(ConnectionString.connectionString))
                        {
                            connection1.Open();
                            SqlCommand cmd1 = new SqlCommand(query, connection1);
                            cmd1.Parameters.Clear();
                            cmd1.Parameters.AddWithValue("@dattruoc", timedt);
                            cmd1.Parameters.AddWithValue("@id", txtIDBan.Text);
                            cmd1.Parameters.AddWithValue("@iddt", txtIDDT.Text);
                            cmd1.Parameters.AddWithValue("@cusid", customerID);
                            cmd1.ExecuteNonQuery();
                            connection1.Close();
                        }
                        lblid.Visible = txtIDDT.Visible = false;
                        ClearDatTruoc();
                    }
                    else
                    {
                        string query = "INSERT INTO CUSTOMER(phone_number) VALUES (@sdt)";
                        using (SqlConnection connection1 = new SqlConnection(ConnectionString.connectionString))
                        {
                            connection1.Open();
                            SqlCommand cmd1 = new SqlCommand(query, connection1);
                            cmd1.Parameters.Clear();
                            cmd1.Parameters.AddWithValue("@sdt", txtSdt.Text);
                            cmd1.ExecuteNonQuery();
                            connection1.Close();
                        }
                        string tdt = dtpDatTruoc.Text.ToString() + " " + cbGio.Text + ":" + cbPhut.Text;
                        string format = "dd/MM/yyyy HH:mm";
                        DateTime timedt;
                        timedt = DateTime.ParseExact(tdt, format, CultureInfo.InvariantCulture);
                        string query2 = "UPDATE DAT_TRUOC SET id_table = @id, time_dt = @dattruoc, cus_id = @cusid WHERE id = @iddt AND cus_id IN (SELECT customer_id FROM CUSTOMER)";
                        using (SqlConnection connection1 = new SqlConnection(ConnectionString.connectionString))
                        {
                            connection1.Open();
                            SqlCommand cmd1 = new SqlCommand(query2, connection1);
                            cmd1.Parameters.Clear();
                            cmd1.Parameters.AddWithValue("@dattruoc", timedt);
                            cmd1.Parameters.AddWithValue("@id", txtIDBan.Text);
                            cmd1.Parameters.AddWithValue("@iddt", txtIDDT.Text);
                            cmd1.Parameters.AddWithValue("@cusid", customerID);
                            cmd1.ExecuteNonQuery();
                            connection1.Close();
                        }
                        lblid.Visible = txtIDDT.Visible = false;
                        ClearDatTruoc();
                    }
                    connection.Close();
                }
                MessageBox.Show("Cập Nhật Đặt Giờ Thành Công !!!", "Thông Báo");
                LoadTableInfo();
                ClearDatTruoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
        #endregion
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query1 = "SELECT customer_id FROM CUSTOMER WHERE phone_number = @sdt";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query1, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                    object result = cmd.ExecuteScalar();
                    int? customerID = result != null ? Convert.ToInt32(result) : (int?)null;
                    if (customerID != null)
                    {
                        string tdt = dtpDatTruoc.Text.ToString() + " " + cbGio.Text + ":" + cbPhut.Text;
                        string format = "dd/MM/yyyy HH:mm";
                        DateTime timedt;
                        timedt = DateTime.ParseExact(tdt, format, CultureInfo.InvariantCulture);
                        string query = "INSERT INTO DAT_TRUOC(id_table, time_dt, cus_id) VALUES (@id, @dattruoc, @cusid)";
                        using (SqlConnection connection1 = new SqlConnection(ConnectionString.connectionString))
                        {
                            connection1.Open();
                            SqlCommand cmd1 = new SqlCommand(query, connection1);
                            cmd1.Parameters.Clear();
                            cmd1.Parameters.AddWithValue("@dattruoc", timedt);
                            cmd1.Parameters.AddWithValue("@id", txtIDBan.Text);
                            cmd1.Parameters.AddWithValue("@cusid", customerID);
                            cmd1.ExecuteNonQuery();
                            connection1.Close();
                        }
                        lblid.Visible = txtIDDT.Visible = false;
                    }
                    else
                    {
                        string query = "INSERT INTO CUSTOMER(phone_number) VALUES (@sdt)";
                        using (SqlConnection connection1 = new SqlConnection(ConnectionString.connectionString))
                        {
                            connection1.Open();
                            SqlCommand cmd1 = new SqlCommand(query, connection1);
                            cmd1.Parameters.Clear();
                            cmd1.Parameters.AddWithValue("@sdt", txtSdt.Text);
                            cmd1.ExecuteNonQuery();
                            connection1.Close();
                        }
                        using (SqlConnection connection2 = new SqlConnection(ConnectionString.connectionString))
                        {
                            string query2 = "SELECT customer_id FROM CUSTOMER WHERE phone_number = @sdt";
                            connection.Open();
                            SqlCommand cmd2 = new SqlCommand(query2, connection);
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                            int? customerID2 = (int)cmd.ExecuteScalar() as int?;
                            if (customerID2 != null)
                            {
                                string tdt = dtpDatTruoc.Text.ToString() + " " + cbGio.Text + ":" + cbPhut.Text;
                                string format = "dd/MM/yyyy HH:mm";
                                DateTime timedt;
                                timedt = DateTime.ParseExact(tdt, format, CultureInfo.InvariantCulture);
                                string query3 = "INSERT INTO DAT_TRUOC(id_table, time_dt, cus_id) VALUES (@id, @dattruoc, @cusid)";
                                using (SqlConnection connection1 = new SqlConnection(ConnectionString.connectionString))
                                {
                                    connection1.Open();
                                    SqlCommand cmd1 = new SqlCommand(query3, connection1);
                                    cmd1.Parameters.Clear();
                                    cmd1.Parameters.AddWithValue("@dattruoc", timedt);
                                    cmd1.Parameters.AddWithValue("@id", txtIDBan.Text);
                                    cmd1.Parameters.AddWithValue("@cusid", customerID2);
                                    cmd1.ExecuteNonQuery();
                                    connection1.Close();
                                }
                            }
                        }
                        lblid.Visible = txtIDDT.Visible = false;
                        connection.Close();
                        ClearDatTruoc();
                    }
                }
                MessageBox.Show("Cập Nhật Đặt Giờ Thành Công !!!", "Thông Báo");
                LoadTableInfo();
                ClearDatTruoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
        private void btnTruyen_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT DAT_TRUOC.*, CUSTOMER.phone_number FROM DAT_TRUOC LEFT JOIN CUSTOMER ON DAT_TRUOC.cus_id = CUSTOMER.customer_id WHERE CONVERT(datetime2, DAT_TRUOC.time_dt) = @timedt";
                string timedt = cbDT.Text.Replace("/", "-");
                string[] datetimeParts = timedt.Split(' ');
                string[] dateParts = datetimeParts[0].Split('-');
                string formattedDate = $"{dateParts[2]}-{dateParts[1]}-{dateParts[0]} {datetimeParts[1]}";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@timedt", formattedDate);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblid.Visible = txtIDDT.Visible = true;
                        txtIDDT.Text = reader.GetInt32(0).ToString();
                        DateTime datetime = reader.GetDateTime(2);
                        int day = datetime.Day;
                        int month = datetime.Month;
                        int year = datetime.Year;
                        dtpDatTruoc.Value = new DateTime(year, month, day);
                        cbGio.SelectedItem = datetime.Hour.ToString("D2"); 
                        cbPhut.SelectedItem = datetime.Minute.ToString("D2");
                        txtSdt.Text = reader.GetString(4).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
        private void frmTableInfo_Load(object sender, EventArgs e)
        {
            LoadTableInfo();
            tt = cbTT.Text.ToString();
        }

        private void cbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Hủy bỏ sự kiện và không cho phép ký tự được nhập vào ComboBox
            }
        }
        private void cbTime_Leave(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            int value;
            if (Int32.TryParse(comboBox.Text, out value))
            {
                comboBox.Text = value.ToString("D2"); // Định dạng số với số lượng chữ số đầy đủ (VD: 01, 02, 03, ...)
            }
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            if (txtSdt.Text.Length > 10)
            {
                txtSdt.Text = txtSdt.Text.Substring(0, 10); // Giới hạn độ dài của chuỗi nhập vào là 10 ký tự
                txtSdt.SelectionStart = 10; // Đưa con trỏ đến cuối chuỗi
            }
        }

        private void cbGio_TextChanged(object sender, EventArgs e)
        {
            string input = cbGio.Text;

            // Kiểm tra giá trị nhập vào có nằm trong danh sách các mục đã có sẵn hay không
            if(input.Length >=2)
            {
                if (!cbGio.Items.Contains(input))
                {
                    cbGio.Text = "";
                }
            }
        }
        private void cbPhut_TextChanged(object sender, EventArgs e)
        {
            string input = cbPhut.Text;

            // Kiểm tra giá trị nhập vào có nằm trong danh sách các mục đã có sẵn hay không
            if (input.Length >= 2)
            {
                if (!cbPhut.Items.Contains(input))
                {
                    cbPhut.Text = "";
                }
            }
        }
    }
}
