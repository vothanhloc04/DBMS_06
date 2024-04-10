using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class Product : UserControl
    {
        private string _name;
        private string _price;
        private Image _image;
        public string namePro
        {
            get { return _name; }
            set { _name = value; lblNameProduct.Text = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }

        public Image imagePro
        {
            get { return _image; }
            set { _image = value; pbProduct.BackgroundImage = value; }
        }

        public Product()
        {
            InitializeComponent();
        }
    }
}
