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

namespace EM_EateryManage
{
    public partial class frmOrder : Form
    {
        private Food form1;
        public frmOrder()
        {
            InitializeComponent();

        }
        public event EventHandler FormClicked;
        List<DataTable> lstDataTB = new List<DataTable>();
        DataTable dtOrder = new DataTable();
        public void AddDataTocbTable()
        {
            for (int i = 1; i < 11; i++)
            {
                cbTable.Items.Add("Table " + i.ToString());
            }
        }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            // Kiểm tra xem vị trí chuột có nằm trong Panel không
            if (panel.ClientRectangle.Contains(e.Location))
            {
                
            }
        }
        public void btnFood(object sender, EventArgs e)
        {
            FormClicked?.Invoke(this, EventArgs.Empty);
            Food food = (Food)sender;
            
            Label label = food.Controls.Find("lblNameFood", true).FirstOrDefault() as Label;
            if (label != null)
            {
                string labelText = label.Text;
                string foodName = labelText;
                DataRow dr;
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
                    dr["Table"] = cbTable.Text;
                    dtOrder.Rows.Add(dr);
                    dgvOrder.DataSource = dtOrder;
                }

            }

        }
        public void AddColumnToDGV()
        {
            dtOrder = new DataTable();
            dtOrder.Columns.Add("Food");
            dtOrder.Columns.Add("Amount");
            dtOrder.Columns.Add("Table");
            dgvOrder.DataSource = dtOrder;

        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            AddDataTocbTable();
            AddColumnToDGV();
            
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

        private void button1_Click(object sender, EventArgs e)
        {
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
                            // Lấy dữ liệu từ cột thích hợp trong truy vấn và tạo đối tượng Person
                            string name = reader.GetString(0);
                            decimal price = reader.GetDecimal(1);
                            string image = reader.GetString(2);

                            food f = new food(name, price, image);

                            value.Add(f);
                            Food childForm = new Food(value);

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
    }
}
