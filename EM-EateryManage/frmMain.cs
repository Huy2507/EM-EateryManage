﻿using System;
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
        private List<Form> displayedForms = new List<Form>();
        
        private void frmMain_Load(object sender, EventArgs e)
        {

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
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (btnOrder.Checked == false)
            {
                btnOrder.Checked = !btnOrder.Checked;
                btnTable.Checked = btnSetting.Checked = false;
            }
            AddControls(new frmOrder());
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
        }
    }
}