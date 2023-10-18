using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static EM_EateryManage.Food;
using System.Text.RegularExpressions;

namespace EM_EateryManage
{
    public partial class frmOrder : Form
    {
        public frmADMIN frmAdmin { get; set; }
        public frmOrder()
        {
            InitializeComponent();
            this.frmAdmin = frmAdmin;

        }
        List<DataTable> lstDataTB = new List<DataTable>();
        DataTable dtOrder = new DataTable();
        public void AddDataTocbTable()
        {
            cbTable.Text = "Hãy Chọn Bàn !!!";
            for (int i = 1; i < 11; i++)
            {
                cbTable.Items.Add("Table " + i.ToString());
            }
        }
        public void AddColumnToDGV()
        {
            dtOrder = new DataTable();
            dtOrder.Columns.Add("Food");
            dtOrder.Columns.Add("Amount");
            dtOrder.Columns.Add("Table");
            dtOrder.Columns.Add("Price");
            dtOrder.Columns.Add("Total Price");
            dgvOrder.DataSource = dtOrder;

        }
        public string DeleteDot(string price)
        {
            int dotCount = price.Count(c => c == '.'); // Đếm số lần xuất hiện dấu chấm trong chuỗi
            if (dotCount >= 2)
            {
                int firstDotIndex = price.IndexOf('.');
                price = price.Remove(firstDotIndex, 1); // Xóa dấu chấm đầu tiên
                int dotCount1 = price.Count(c => c == '.'); // Đếm số lần xuất hiện dấu chấm trong chuỗi
                if (dotCount1 >= 2)
                {
                    price = DeleteDot(price); // Truyền lại chuỗi mới sau khi xóa dấu chấm đầu tiên
                }
            }
            return price; // Trả về chuỗi sau khi xóa hai dấu chấm đầu tiên
        }
        public void Sumtotal()
        {
            decimal sumvalue = 0;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                sumvalue += Convert.ToDecimal(dgvOrder.Rows[i].Cells[4].Value);
            }
            lblTongTien.Text = sumvalue.ToString();
        }
        public void btnFood(object sender, EventArgs e)
        {
            Food food = (Food)sender;
            
            Label labelName = food.Controls.Find("lblNameFood", true).FirstOrDefault() as Label;
            if (labelName != null)
            {
                string labelText = labelName.Text;
                string foodName = labelText;
                DataRow dr;
                Label labelPrice = food.Controls.Find("lblPrice", true).FirstOrDefault() as Label;
                string price = labelPrice.Text;
                price = DeleteDot(price);
                int total = 0;
                total = dgvOrder.RowCount - 1;
                if (dgvOrder.Rows[0].Cells[0].Value == null)
                {
                    dr = dtOrder.NewRow();
                    dr["Food"] = foodName;
                    dr["Amount"] = 1;

                    if (cbTable.SelectedIndex < 0)
                    {
                        MessageBox.Show("Chossen Table!!!");
                        cbTable.Focus();
                        return;
                    }
                    dr["Table"] = Regex.Match(cbTable.Text, @"\d+").Value;
                    dr["Price"] = price;
                    dr["Total Price"] = Convert.ToDecimal(dr["Amount"]) * Convert.ToDecimal(dr["Price"]);
                    dtOrder.Rows.Add(dr);
                    dgvOrder.DataSource = dtOrder;
                }
                else
                {
                    for (int i = 0; i < total; i++)
                    {
                        if (dgvOrder.Rows[i].Cells[0].Value.ToString() == foodName)
                        {
                            int _amount = Convert.ToInt32(dgvOrder.Rows[i].Cells[1].Value.ToString());
                            dgvOrder.Rows[i].Cells[1].Value = (_amount + 1).ToString();
                            dgvOrder.Rows[i].Cells[4].Value = Convert.ToDecimal(dgvOrder.Rows[i].Cells[1].Value) * Convert.ToDecimal(dgvOrder.Rows[i].Cells[3].Value);
                            Sumtotal();
                            return;
                        }
                        

                    }
                    dr = dtOrder.NewRow();
                    dr["Food"] = foodName;
                    dr["Amount"] = 1;
                    if (cbTable.Text == null)
                    {
                        MessageBox.Show("Chossen Table!!!");
                        cbTable.Focus();
                        return;
                    }

                    string value = Regex.Match(cbTable.Text, @"\d+").Value;
                    dr["Table"] = value;
                    dr["Price"] = price;
                    dr["Total Price"] = Convert.ToDecimal(dr["Amount"]) * Convert.ToDecimal(dr["Price"]);
                    dtOrder.Rows.Add(dr);
                    dgvOrder.DataSource = dtOrder;
                }
                Sumtotal();
               
            }
            
        }
        private void AttachClickEventToControls(Food f)
        {
            // Lặp qua tất cả các control trong panel
            foreach (Control control in f.Controls)
            {
                // Gắn sự kiện click cho từng control
                control.Click += btnFood;
            }
        }
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvOrder.Rows[e.RowIndex];
            if (selectedRow.Cells[1].Value.ToString() != "1")
            {
                int _amount = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                selectedRow.Cells[1].Value = (_amount - 1).ToString();
                selectedRow.Cells[4].Value = Convert.ToDecimal(selectedRow.Cells[1].Value) * Convert.ToDecimal(selectedRow.Cells[3].Value);
                return;
            }
            dgvOrder.Rows.Remove(selectedRow);
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            AddDataTocbTable();
            AddColumnToDGV();
            AddDataToFlowlayoutPanel();
        }
       

        public void AddDataToFlowlayoutPanel()
        {
            flpnlMenu.Controls.Clear();
            string query = "SELECT food_name, food_price, food_image FROM dbo.FOOD";

            List<food> value = new List<food>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string price = reader.GetString(1);
                            string image = reader.GetString(2);

                            food f = new food(name, price, image);
                            value.Add(f);
                            Food childForm = new Food(value);
                            childForm.FoodClicked += btnFood;
                            // Hiển thị Form mới
                            flpnlMenu.Controls.Add(childForm);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = dgvOrder.RowCount;
            if (total > 1)
            {
                cbTable.Text = "Table " + dgvOrder.Rows[0].Cells[2].Value.ToString();
                MessageBox.Show("Hãy Hoàn Tất Gọi Món Cho 1 " + dgvOrder.Rows[0].Cells[2].Value.ToString() +" !!!");
                
                return;
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentTime = DateTime.Now;
                int billid;

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    string query = "INSERT INTO BILL (create_time, total_amount) VALUES (@createtime, @totalamount) SELECT SCOPE_IDENTITY()";
                    command.CommandText = query;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@createtime", currentTime);
                    command.Parameters.AddWithValue("@totalamount", lblTongTien.Text);
                    billid = Convert.ToInt32(command.ExecuteScalar());
                }

                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string query = "INSERT INTO BILLINFO (bill_id, item_name, quantity, unit_price, line_total, table_id) VALUES (@billid, @name, @amount, @price, @total, @table)";
                            command.CommandText = query;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@billid", billid);
                            command.Parameters.AddWithValue("@name", row.Cells[0].Value.ToString());
                            command.Parameters.AddWithValue("@amount", row.Cells[1].Value);
                            command.Parameters.AddWithValue("@price", decimal.Parse(row.Cells[3].Value.ToString()));
                            command.Parameters.AddWithValue("@total", row.Cells[4].Value);
                            command.Parameters.AddWithValue("@table", row.Cells[2].Value);

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Thêm hàng thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            int rowCount = dgvOrder.Rows.Count;
            for (int n = 0; n < rowCount; n++)
            {
                if (dgvOrder.Rows[0].IsNewRow == false)
                    dgvOrder.Rows.RemoveAt(0);
            }
        }
    } 
}
