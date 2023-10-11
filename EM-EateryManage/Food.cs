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
        private frmOrder form1;
        public class food
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Image { get; set; }

            public food(string name, decimal price, string image)
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

        private void Food_Click(object sender, EventArgs e)
        {
            
        }
    }
}
