using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM_EateryManage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<DataTable> lstDataTB = new List<DataTable>();
        DataTable dtOrder = new DataTable();
        //Mở lại form cũ
        private List<Form> displayedForms = new List<Form>();
        private frmOrder openedOrderForm;
        private frmADMIN openFormAdmin;
        //
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Bắt đầu Timer
            timerClock.Start();
        }
        public void AddControls(Form f)
        {
            panelOrder.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelOrder.Controls.Add(f);
            if (displayedForms.Contains(f))
            { 
                f.Activate();
                f.Show();
            }
            else
            {
                displayedForms.Add(f);
                f.Show();
                if (f is frmOrder)
                {
                    openedOrderForm = (frmOrder)f;
                }
                if (f is frmADMIN)
                {
                    openFormAdmin = (frmADMIN)f;
                }
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (btnOrder.Checked == false)
            {
                btnOrder.Checked = !btnOrder.Checked;
                btnTable.Checked = btnSetting.Checked = false;
            }
            if (openedOrderForm != null)
            {
                AddControls(openedOrderForm);
            }
            else
            {
                AddControls(new frmOrder());
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            if (btnTable.Checked == false)
            {
                btnTable.Checked = !btnTable.Checked;
                btnOrder.Checked = btnSetting.Checked = false;

            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (btnSetting.Checked == false)
            {
                btnSetting.Checked = !btnSetting.Checked;
                btnOrder.Checked = btnTable.Checked = false;

            }
            if (openFormAdmin != null)
            {
                AddControls(openFormAdmin);
            }
            else
            {
                AddControls(new frmADMIN());
            }
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
