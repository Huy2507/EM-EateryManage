using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EM_EateryManage
{
    public partial class frmBill : Form
    {

        public frmBill()
        {
            InitializeComponent();
            AddDataTocbTable();
            checkComboBoxCount();
        }
        private void checkComboBoxCount()
        {
            if (cbTable.Items.Count > 0)
            {
                btnThanhToan.Enabled = true;
                btnGiamGia.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
                btnGiamGia.Enabled = false;
            }
        }
        private void AddDataTocbTable()
        {
            cbTable.Items.Clear();
            string query = "SELECT * FROM QuanLyBan WHERE trang_thai = N'Đang Bận' ";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbTable.Items.Add(reader.GetString(1));
                    }
                }
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


                    string query = "select bill_id as N'ID', item_name as N'Tên món', quantity as N'Số lượng', unit_price as N'Giá', line_total as N'Tổng'\r\nfrom BILLINFO WHERE STATUS = N'Chưa' AND table_id = 1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dtgvBill.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void changeTableStatus(int IDTable)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    // Truy vấn để kiểm tra tài khoản
                    string query = "UPDATE dbo.QuanLyBan SET trang_thai=N'Trống' WHERE id = @table_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@table_id", IDTable);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private int findBillID()
        {
            int i = 0;
            string value = cbTable.SelectedItem.ToString();
            bool isVIP = value.Equals("Bàn Xịn");
            int tableID = 0;
            if (isVIP == true)
            {
                tableID = 7;
            }
            else
            {
                string[] arrListStr = value.Split(' ');
                tableID = int.Parse(arrListStr[1]);
            }
            try
            {
                string query = "Select bill_id from BILLINFO where status = N'Rồi' and table_id = @tableID";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@tableID", tableID);

                    if (txbSoDienThoaiCustomer.Text != "")
                    {
                        i = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Chọn Khách Hàng Muốn Tích Điểm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return i;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
            return i;
        }


        private int getCustomerID()
        {
            int i = 0;
            try
            {
                string query = "Select customer_id from customer where phone_number = @1";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@1", txbSoDienThoaiCustomer.Text);

                    if (txbSoDienThoaiCustomer.Text != "")
                    {
                        i = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Chọn Khách Hàng Muốn Tích Điểm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return i;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
            return i;
        }
        private void UpdateCustomer()
        {
            int customerID = getCustomerID();
            int billID = findBillID();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    string value = cbTable.SelectedItem.ToString();
                    // Truy vấn để kiểm tra tài khoản
                    string query = "UPDATE dbo.BILL SET status=N'Rồi', customer_id = @id WHERE bill_id = @BILLID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", customerID);
                    command.Parameters.AddWithValue("@BILLID", billID);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void TichDiem()
        {
            int i = 0;
            try
            {
                string query = "Select Diem_Tich_Luy from customer where phone_number = @1";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@1", txbSoDienThoaiCustomer.Text);

                    if (txbSoDienThoaiCustomer.Text != "")
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


                    string query = "UPDATE customer SET Diem_Tich_Luy = @1 WHERE phone_number = @0";
                    command.CommandText = query;
                    command.Parameters.Clear();

                    if (txbSoDienThoaiCustomer.Text != "")
                    {
                        DialogResult result = (MessageBox.Show("Bạn Có Chắc Chắn Muốn Tích Điểm Cho Khách Hàng Này?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (result == DialogResult.Yes)
                        {

                            command.Parameters.AddWithValue("@0", txbSoDienThoaiCustomer.Text);
                            command.Parameters.AddWithValue("@1", i + 10);


                            // Thực thi câu lệnh update
                            command.ExecuteNonQuery();

                            // Hiển thị thông báo sửa thành công
                            MessageBox.Show("Tích Điểm Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn đã chắc chắn kiểm tra kĩ đơn hàng và thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cbTable.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string value = cbTable.SelectedItem.ToString();
            bool isVIP = value.Equals("Bàn Xịn");
            int tableIDCheck = 0;
            if (isVIP == true)
            {
                tableIDCheck = 7;
            }
            else
            {
                string[] arrListStr = value.Split(' ');
                tableIDCheck = int.Parse(arrListStr[1]);
            }
            if (check == System.Windows.Forms.DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    try
                    {
                        connection.Open();
                        string value1 = cbTable.SelectedItem.ToString();
                        bool isVIP1 = value1.Equals("Bàn Xịn");
                        int tableID = 0;
                        if (isVIP1 == true)
                        {
                            tableID = 7;
                        }
                        else
                        {
                            string[] arrListStr = value.Split(' ');
                            tableID = int.Parse(arrListStr[1]);
                        }
                        // Truy vấn để kiểm tra tài khoản
                        string query = "UPDATE dbo.BILLINFO SET status=N'Rồi' WHERE table_id = @table_id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@table_id", tableID);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        int rowCount = dtgvBill.Rows.Count;
                        for (int n = 0; n < rowCount; n++)
                        {
                            if (dtgvBill.Rows[0].IsNewRow == false)
                                dtgvBill.Rows.RemoveAt(0);
                        }
                    }
                }
                TichDiem();
                UpdateCustomer();
                changeTableStatus(tableIDCheck);
                txbTong.Text = "";
                checkComboBoxCount();
            }
            else
            {
                return;
            }
        }

        private void tinhTongTien()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                decimal total = 0;
                try
                {
                    connection.Open();
                    string value = cbTable.SelectedItem.ToString();
                    bool isVIP = value.Equals("Bàn Xịn");
                    int tableID = 0;
                    if (isVIP == true)
                    {
                        tableID = 7;
                    }
                    else
                    {
                        string[] arrListStr = value.Split(' ');
                        tableID = int.Parse(arrListStr[1]);
                    }
                    // Truy vấn để kiểm tra tài khoản
                    string query = "SELECT line_total FROM BILLINFO WHERE table_id = @table_id AND status = N'Chưa thanh toán'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@table_id", tableID);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        total += decimal.Parse(reader["line_total"].ToString());
                    }
                    decimal giamGia = (decimal.Parse(txbGiamGia.Text) / 100) * total;
                    decimal tongKet = (decimal)total - giamGia;
                    txbTong.Text = tongKet.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            AddDataToDGV();
        }

        private double findCustomer()
        {
            int i = 0;
            try
            {
                string query = "Select Diem_Tich_Luy from customer where phone_number = @1";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@1", txbSoDienThoaiCustomer.Text);

                    if (txbSoDienThoaiCustomer.Text != "")
                    {
                        try
                        {
                            i = int.Parse(cmd.ExecuteScalar().ToString());
                        }
                        catch (Exception ex)
                        {
                            i = 0;
                            MessageBox.Show("Số điện thoại vừa nhập chưa đăng ký điểm tích lũy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Chọn Khách Hàng Muốn Tích Điểm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    double truocgiamgia = (double)i / 100;
                    double giamGia = Math.Round(truocgiamgia);
                    if (giamGia > 0)
                    {
                        giamGia = giamGia * 10;
                        return giamGia;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
            return 0;
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {

            if (txbGiamGia.Text == "")
            {
                txbGiamGia.Text = "0";
            }
            if (cbTable.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn để giảm giá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int giamGia = int.Parse(txbGiamGia.Text);
            bool isDiscount = false;

            string value = cbTable.SelectedItem.ToString();
            bool isVIP = value.Equals("Bàn Xịn");
            int tableID = 0;
            if (isVIP == true)
            {
                tableID = 7;
            }
            else
            {
                string[] arrListStr = value.Split(' ');
                tableID = int.Parse(arrListStr[1]);
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    // Truy vấn để kiểm tra tài khoản
                    string query = "UPDATE BILLINFO SET discount = @discount WHERE table_id = @tableID AND status = N'Chưa thanh toán'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@discount", giamGia);
                    command.Parameters.AddWithValue("@tableID", tableID);
                    command.ExecuteNonQuery();
                    isDiscount = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    isDiscount = false;
                }
            }
            if (isDiscount == true)
            {
                tinhTongTien();
            }

        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {

            // "select item_name as N'Tên món', quantity as N'Số lượng', unit_price as N'Giá', line_total as N'Tổng'\r\nfrom BILLINFO WHERE STATUS = N'Chưa' AND table_id = @tableID"
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string value = cbTable.SelectedItem.ToString();
                    bool isVIP = value.Equals("Bàn Xịn");
                    int tableID = 0;
                    if (isVIP == true)
                    {
                        tableID = 7;
                    }
                    else
                    {
                        string[] arrListStr = value.Split(' ');
                        tableID = int.Parse(arrListStr[1]);
                    }

                    connection.Open();
                    SqlCommand command = new SqlCommand("select bill_id as N'ID',item_name as N'Tên món', quantity as N'Số lượng', unit_price as N'Giá', line_total as N'Tổng' from BILLINFO WHERE STATUS = N'Chưa thanh toán' AND table_id = @tableID", connection);
                    command.Parameters.AddWithValue("@tableID", tableID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgvBill.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double giamGia = findCustomer();
            txbGiamGia.Text = giamGia.ToString();
        }
    }
}
