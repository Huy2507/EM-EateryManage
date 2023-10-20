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
        private void xuatBill(int selectedTable)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.BILLINFO WHERE table_id = @table_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@table_id", selectedTable);

                    SqlDataReader reader = command.ExecuteReader();
                    string labelHienThi = "Tên món ăn"+ "    " + "Số lượng" + "   " + "Giá" + "        "+ "Tổng\n";
                    int totalPrice = 0;
                    while (reader.Read())
                    {
                        string itemName = reader["item_name"].ToString();
                        string quantity = reader["quantity"].ToString();
                        string price = reader["unit_price"].ToString();
                        string total = reader["line_total"].ToString();
                        string Bill = itemName + "          " + quantity + "            " + price + "                 " + total + "\n";
                        int tongMotmon = (int)decimal.Parse(price) * int.Parse(quantity);
                        totalPrice += tongMotmon;
                        labelHienThi = labelHienThi + Bill;
                    }
                    txbToTal.Text = totalPrice.ToString();
                    lbHoaDon.Text = labelHienThi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
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
                        string query = "DELETE FROM dbo.BILLINFO WHERE table_id = @table_id";
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
            else
            {
                return;
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = cbTable.SelectedIndex + 1;
            xuatBill(selected);
        }
    }
}
