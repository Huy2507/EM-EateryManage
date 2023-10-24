using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static EM_EateryManage.Food;
using static EM_EateryManage.Table;

namespace EM_EateryManage
{
    public partial class frmTable : Form
    {
        public frmTable()
        {
            InitializeComponent();
        }
        private void UpdateTableStatus(int id)
        {
            string updateQuery = "UPDATE QuanLyBan SET trang_thai = @tt WHERE id = @id";
            string selectQuery1 = "SELECT id_table, time_dt FROM DAT_TRUOC WHERE id_table = @idtable AND time_dt >= @time";
            DateTime thirtyMinutesAgo = DateTime.Now.AddMinutes(-30);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery1, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@idtable", id);
                        selectCommand.Parameters.AddWithValue("@time", thirtyMinutesAgo);

                        SqlDataReader reader = selectCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            using (SqlConnection connection2 = new SqlConnection(ConnectionString.connectionString))
                            {
                                connection2.Open();

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection2))
                                {
                                    updateCommand.Parameters.AddWithValue("@tt", "Sắp Đến Giờ Đặt Trước");
                                    updateCommand.Parameters.AddWithValue("@id", id);
                                    updateCommand.ExecuteNonQuery();
                                }
                                connection2.Close();
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
        public void LoadDSTable(string find)
        {
            string sf = find;
            pntable.Controls.Clear();
            string query = "SELECT id, ten_ban, trang_thai FROM QuanLyBan";
            if(sf!= "Nhập Bàn Muốn Tìm")
            {
                query = "SELECT id, ten_ban, trang_thai FROM QuanLyBan WHERE ten_ban like N'%' + @1 + '%' OR so_ghe like N'%' + @1 + '%' OR trang_thai like N'%' + @1 + '%' OR detail like N'%' + @1 + '%'";
            }
            List<table> value = new List<table>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@1", sf);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            UpdateTableStatus(id);
                            string name = reader.GetString(1);
                            string status = reader.GetString(2);


                            table f = new table(id, name, status);
                            value.Add(f);
                            Table childForm = new Table(value);
                            childForm.TableClicked += btnTable;
                            System.Windows.Forms.Label lbtt = childForm.Controls.Find("lblStatus", true).FirstOrDefault() as System.Windows.Forms.Label;
                            Guna2Panel pntt = childForm.Controls.Find("pnTT", true).FirstOrDefault() as Guna2Panel;
                            System.Windows.Forms.Label lbname = childForm.Controls.Find("label1", true).FirstOrDefault() as System.Windows.Forms.Label;

                            if (lbtt.Text == "Đang Bận")
                            {
                                lbtt.BackColor = pntt.BackColor = Color.FromArgb(255, 90, 0);
                            }
                            if (lbtt.Text == "Sắp Đến Giờ Đặt Trước")
                            {
                                lbtt.BackColor = pntt.BackColor = Color.FromArgb(255, 255, 0);
                            }
                            // Hiển thị Form mới
                            pntable.Controls.Add(childForm);
                            foreach (UserControl control in this.pntable.Controls)
                            {
                                control.Margin = new Padding(12); // Khoảng cách giãn bên ngoài của mỗi item
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
        public void btnTable(object sender, EventArgs e)
        {
            Table table = (Table)sender;
            System.Windows.Forms.Label lblId = table.Controls.Find("lblID", true).FirstOrDefault() as System.Windows.Forms.Label;
            string labelid = lblId.Text;
            frmTableInfo f_tableinfo = new frmTableInfo(labelid);
            f_tableinfo.RecallLoadTB += frmTable_Load;
            f_tableinfo.ShowDialog();


        }
        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadDSTable(txtFindTable.Text);

        }

        private void btnReloadTable_Click(object sender, EventArgs e)
        {
            LoadDSTable(txtFindTable.Text);
        }

        private void txtFindTable_TextChanged(object sender, EventArgs e)
        {
            string textFind = txtFindTable.Text;
            LoadDSTable(textFind);
            if (txtFindTable.Text == "" || txtFindTable.Text == "Nhập Bàn Muốn Tìm")
            {
                btnX.Visible = false;
            }
            else
            {
                btnX.Visible = true;
            }
        }
        private bool isFirstClick = true;
        private void txtFindTable_Click(object sender, EventArgs e)
        {
            if (isFirstClick)
            {
                txtFindTable.Text = "";
                isFirstClick = false;
            }
        }

        private void txtFindTable_Leave(object sender, EventArgs e)
        {
            if (txtFindTable.Text == "")
            {
                txtFindTable.Text = "Nhập Bàn Muốn Tìm";
                isFirstClick = true;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtFindTable.Clear();
        }
    }
}
