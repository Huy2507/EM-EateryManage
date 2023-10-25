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
using Guna.UI2.WinForms;

namespace EM_EateryManage
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn để kiểm tra tài khoản
                    string query = "SELECT Chuc_Vu FROM dbo.ACCOUNT WHERE username = @Username AND password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);

                    string result = (string)command.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result;
                        if(role == "staff")
                        {
                            frmMain FormMain = new frmMain();
                            Guna2Button btnsetting = FormMain.Controls.Find("btnSetting", true).FirstOrDefault() as Guna2Button;
                            btnsetting.Enabled = false;
                            FormMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            frmMain FormMain = new frmMain();
                            FormMain.Show();
                            this.Hide();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu sai. Hãy thử lại !!!");
                        txtUsername.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Muốn Thoát Khỏi Chương Trình?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
