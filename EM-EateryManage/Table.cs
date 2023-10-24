using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EM_EateryManage.Food;

namespace EM_EateryManage
{
    public partial class Table : UserControl
    {
        public class table
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Status { get; set; }

            public table(int id, string name, string status)
            {
                ID = id;
                Name = name;
                Status = status;
            }
        }

        public List<table> value;

        public Table(List<table> value)
        {
            InitializeComponent();
            this.value = value;
            foreach (table t in value)
            {
                lblID.Text = t.ID.ToString();
                lblNameTable.Text = t.Name;
                lblStatus.Text = t.Status;
            }

        }
        public event EventHandler TableClicked;
        private void AttachClickEvent(Control control)
        {
            control.Click += Table_Click;
            foreach (Control childControl in control.Controls)
            {
                AttachClickEvent(childControl);
            }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            this.Controls[0].Focus();
            TableClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            AttachClickEvent(this);
        }
    }
}
