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
        }
        private void AddDataTocbTable()
        {
            for (int i = 1; i < 11; i++)
            {
                cbTable.Items.Add("Table " + i.ToString());
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


                    string query = "select item_name as N'Tên món', quantity as N'Số lượng', unit_price as N'Giá', line_total as N'Tổng'\r\nfrom BILLINFO WHERE STATUS = N'Chưa'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn đã chắc chắn kiểm tra kĩ đơn hàng và thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(check == System.Windows.Forms.DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    try
                    {
                        connection.Open();
                        int IDTable = cbTable.SelectedIndex + 1;
                        // Truy vấn để kiểm tra tài khoản
                        string query = "UPDATE dbo.BILLINFO SET status=N'Rồi' WHERE table_id = @table_id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@table_id", IDTable);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        int rowCount = dataGridView1.Rows.Count;
                        for (int n = 0; n < rowCount; n++)
                        {
                            if (dataGridView1.Rows[0].IsNewRow == false)
                                dataGridView1.Rows.RemoveAt(0);
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }


        private void frmBill_Load(object sender, EventArgs e)
        {
            AddDataToDGV();
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                decimal total = 0;
                try
                {
                    connection.Open();
                    int IDTable = cbTable.SelectedIndex + 1;
                    // Truy vấn để kiểm tra tài khoản
                    string query = "SELECT line_total FROM BILLINFO WHERE table_id = @table_id AND status = N'Chưa'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@table_id", 1);
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        total += decimal.Parse(reader["line_total"].ToString());
                    }
                    decimal giamGia = (decimal.Parse(cbGiamGia.Text)/100) * total;
                    decimal tongKet = (decimal)total - giamGia;
                    txbTong.Text = tongKet.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
