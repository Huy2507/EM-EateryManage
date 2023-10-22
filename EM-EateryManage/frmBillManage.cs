﻿using System;
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
                    SqlCommand command = new SqlCommand("SELECT * FROM BILL WHERE create_time <= @createTime", connection);
                    command.Parameters.AddWithValue("@createTime", createTime);

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
    }
}
