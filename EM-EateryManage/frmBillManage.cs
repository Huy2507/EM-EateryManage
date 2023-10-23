using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EM_EateryManage
{
    public partial class frmBillManage : Form
    {
        public frmBillManage()
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
                    DateTime createTime = dttpFromDate.Value;
                    DateTime timeCreate = new DateTime(createTime.Year, createTime.Month, createTime.Day, 0, 0, 0);
                    SqlCommand command = new SqlCommand("SELECT * FROM BILL WHERE create_time BETWEEN @timeCreate AND @createTime", connection);
                    command.Parameters.AddWithValue("@createTime", createTime);
                    command.Parameters.AddWithValue("@timeCreate", timeCreate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgvManageBill.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            AddDataToDGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    int ID = int.Parse(txbSearchId.Text);
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM BILL WHERE bill_id = @billId", connection);
                    command.Parameters.AddWithValue("@billId", ID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgvManageBill.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void frmBillManage_Load(object sender, EventArgs e)
        {

        }

        private void dtgvManageBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dtgvManageBill.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmBillDetail fDetails = new frmBillDetail(ID);
            fDetails.Show();
            
        }
    }
}
