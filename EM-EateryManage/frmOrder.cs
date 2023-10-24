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
using Guna.UI2.WinForms;

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
            cbTable.Items.Clear();  
            string query = "SELECT * FROM QuanLyBan WHERE trang_thai = N'Trống'";
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
        public void AddColumnToDGV()
        {
            dtOrder = new DataTable();
            dtOrder.Columns.Add("Food");
            dtOrder.Columns.Add("Amount");
            dtOrder.Columns.Add("Table");
            dtOrder.Columns.Add("Price");
            dtOrder.Columns.Add("Total Price");
            dgvOrder.DataSource = dtOrder;
            dgvOrder.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                if (dgvOrder.Rows[i].Cells[4].Value != null)
                {
                    decimal value = decimal.Parse(dgvOrder.Rows[i].Cells[4].Value.ToString());
                    if (decimal.TryParse(dgvOrder.Rows[i].Cells[4].Value.ToString(), out value))
                    {
                        string stringValue = dgvOrder.Rows[i].Cells[4].Value.ToString();
                        if (!stringValue.Contains("."))
                        {
                            sumvalue += value / 1000;
                        }
                        else
                        {
                            sumvalue += value;
                        }
                    }
                }
            }
            char firstCharacter;

            for (int i = 0; i < sumvalue.ToString().Length; i++)
            {
                firstCharacter = sumvalue.ToString()[i];
                if (firstCharacter == '0')
                {
                    sumvalue = sumvalue * 1000;
                    lblTongTien.Text= sumvalue.ToString("0")+"đ";
                }
                else
                {
                    lblTongTien.Text = sumvalue.ToString() + "đ";
                }
                break;
            }

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
                    dr["Table"] = cbTable.Text;
                    dr["Price"] = price;
                    string price1 = dr["Price"].ToString();
                    //price1 = price1.Replace(".", "");
                    dr["Total Price"] = Convert.ToDecimal(dr["Amount"]) * Convert.ToDecimal(price1);
                    dtOrder.Rows.Add(dr);
                    dgvOrder.DataSource = dtOrder;
                }
                else
                {
                    if (cbTable.SelectedIndex < 0)
                    {
                        MessageBox.Show("Chossen Table!!!");
                        cbTable.Focus();
                        return;
                    }
                    for (int i = 0; i < total; i++)
                    {
                        if (dgvOrder.Rows[i].Cells[0].Value.ToString() == foodName)
                        {
                            int _amount = Convert.ToInt32(dgvOrder.Rows[i].Cells[1].Value.ToString());
                            dgvOrder.Rows[i].Cells[1].Value = (_amount + 1).ToString();
                            
                            string price1 = dgvOrder.Rows[i].Cells[3].Value.ToString();
                            //price1 = price1.Replace(".", "");
                            string ttprice = "";
                            if (!(Convert.ToDecimal(dgvOrder.Rows[i].Cells[1].Value) * Convert.ToDecimal(price1)).ToString().Contains("."))
                            {
                                ttprice = (Convert.ToDecimal(dgvOrder.Rows[i].Cells[1].Value) * Convert.ToDecimal(price1)).ToString("0,0");
                                ttprice = ttprice.Replace(",", ".");
                                dgvOrder.Rows[i].Cells[4].Value = ttprice;
                            }
                            else
                            {
                                ttprice = (Convert.ToDecimal(dgvOrder.Rows[i].Cells[1].Value) * Convert.ToDecimal(price1)).ToString();
                                dgvOrder.Rows[i].Cells[4].Value = ttprice;
                            }
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

                    string value = cbTable.Text;
                    dr["Table"] = value;
                    dr["Price"] = price;
                    dr["Total Price"] = Convert.ToDecimal(dr["Amount"]) * Convert.ToDecimal(dr["Price"]);
                    dtOrder.Rows.Add(dr);
                    dgvOrder.DataSource = dtOrder;
                }
                Sumtotal();
            }
        }
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvOrder.Rows.Count)
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
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            AddDataTocbTable();
            AddColumnToDGV();
            string a = "Tất Cả";
            AddDataToFlowlayoutPanel(a,"");
            cbTrangThai.Text = "Chưa Thanh Toán";
        }
        public void AddDataToFlowlayoutPanel(string dm, string a)
        {
            flpnlMenu.Controls.Clear();
            string datadm = dm;
            string textFinded = a;
            string query = "";
            if (datadm == "Tất Cả" && (txtFindFood.Text == "" || txtFindFood.Text == "Nhập Món Muốn Tìm"))
            {
                query = "SELECT food_name, food_price, food_image, food_material FROM dbo.FOOD";
            }
            else
            {
                if (datadm != "Tất Cả" && (txtFindFood.Text == "" || txtFindFood.Text == "Nhập Món Muốn Tìm"))
                {
                    query = "SELECT food_name, food_price, food_image, food_material FROM dbo.FOOD where food_material = @danhmuc";
                }
                else
                {
                    query = "SELECT food_name, food_price, food_image, food_material FROM dbo.FOOD where food_name like N'%' + @textfind + '%'";
                }
            }

            List<food> value = new List<food>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@danhmuc", datadm);
                        command.Parameters.AddWithValue("@textfind", a);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string material = reader.GetString(3);

                            if (datadm == material || datadm == "Tất Cả")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = dgvOrder.RowCount;
            if (total > 1)
            {
                cbTable.Text = "Table " + dgvOrder.Rows[0].Cells[2].Value.ToString();
                MessageBox.Show("Hãy Hoàn Tất Gọi Món Cho Bàn " + dgvOrder.Rows[0].Cells[2].Value.ToString() + " !!!", "Hoàn Tất");

                return;
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentTime = DateTime.Now;
                int billid;
                string gt = "";
                try
                {
                    string query = "Select id from quanlyban where ten_ban = @1";
                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@1", cbTable.Text);
                        gt = cmd.ExecuteScalar().ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!");
                }
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    string query = "INSERT INTO BILL (create_time, total_amount) VALUES (@createtime, @totalamount) SELECT SCOPE_IDENTITY()";
                    command.CommandText = query;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@createtime", currentTime);
                    command.Parameters.AddWithValue("@totalamount", decimal.Parse(lblTongTien.Text.Replace("đ","")));
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
                            string query = "INSERT INTO BILLINFO (bill_id, item_name, quantity, unit_price, line_total, table_id, status) VALUES (@billid, @name, @amount, @price, @total, @table, @status)";
                            command.CommandText = query;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@billid", billid);
                            command.Parameters.AddWithValue("@name", row.Cells[0].Value.ToString());
                            command.Parameters.AddWithValue("@amount", row.Cells[1].Value);
                            command.Parameters.AddWithValue("@price", decimal.Parse(row.Cells[3].Value.ToString()));
                            command.Parameters.AddWithValue("@total", row.Cells[4].Value);
                            command.Parameters.AddWithValue("@table", gt);
                            command.Parameters.AddWithValue("@status", cbTrangThai.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Thêm hàng thành công!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error!");
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
            lblTongTien.Text = "...";
        }
        private void MyButtonDanhMuc_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;
            clickedButton.Checked = true;
            foreach (Guna2Button button in pnDanhMuc.Controls.OfType<Guna2Button>())
            {
                // Kiểm tra xem button hiện tại có là button được click không
                if (button != clickedButton)
                {
                    button.Checked = false;
                }
                if(button.Checked == true)
                {
                    string dm = clickedButton.Text;
                    AddDataToFlowlayoutPanel(dm, "");
                }
            }
        }
        private bool isFirstClick = true;
        private void txtFindFood_Click(object sender, EventArgs e)
        {
            if (isFirstClick)
            {
                txtFindFood.Text = "";
                isFirstClick = false;
            }
        }
        private void txtFindFood_TextChanged(object sender, EventArgs e)
        {
            foreach (Guna2Button button in pnDanhMuc.Controls.OfType<Guna2Button>())
            {
                if (button.Checked == true)
                {
                    string dm = button.Text;
                    string textFind = txtFindFood.Text;
                    AddDataToFlowlayoutPanel(dm, textFind);
                }
            }
            if(txtFindFood.Text == "" || txtFindFood.Text == "Nhập Món Muốn Tìm" )
            {
                btnX.Visible= false;
            }
            else
            {
                btnX.Visible= true;
            }
        }

        private void txtFindFood_Leave(object sender, EventArgs e)
        {
            if (txtFindFood.Text == "")
            {
                txtFindFood.Text = "Nhập Món Muốn Tìm";
                isFirstClick = true;
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            txtFindFood.Clear();
        }

        private void cbTable_Click(object sender, EventArgs e)
        {
            AddDataTocbTable();
        }
    }
}
