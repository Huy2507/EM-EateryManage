using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM_EateryManage
{
    public partial class Food : UserControl
    {
        public class food
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }

            public food(string name, string price, string image)
            {
                Name = name;
                Price = price;
                Image = image;
            }
        }

        public List<food> value;

        public Food(List<food> value)
        {
            InitializeComponent();
            this.value = value;
            foreach (food f in value)
            {
                lblNameFood.Text = f.Name;
                lblPrice.Text = f.Price.ToString();
                picFood.ImageLocation = f.Image;
                
                // Gán các giá trị khác cho các control khác
            }

        }
        public event EventHandler FoodClicked;
        private void AttachClickEvent(Control control)
        {
            control.Click += Food_Click;
            foreach (Control childControl in control.Controls)
            {
                AttachClickEvent(childControl);
            }
        }
        private void Food_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện FoodClicked
            FoodClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Food_Load(object sender, EventArgs e)
        {
            AttachClickEvent(this);
        }
    }
}
