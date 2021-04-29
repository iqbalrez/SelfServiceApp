using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelfService;

namespace SelfService
{
    public partial class Form1 : Form
    {
        Shop myShop = new Shop();
        BindingSource shirtBindingSource = new BindingSource();
        BindingSource pantsBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_PilihShirt_Click(object sender, EventArgs e)
        {
            Apparel selected = (Apparel)lst_Shirt.SelectedItem;
            myShop.CartList.Add(selected);
        }
        private void btn_PilihPants_Click(object sender, EventArgs e)
        {
            Apparel selected = (Apparel)lst_Pants.SelectedItem;
            myShop.CartList.Add(selected);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            shirtBindingSource.DataSource = myShop.ShirtList;
            lst_Shirt.DataSource = shirtBindingSource;
            lst_Shirt.DisplayMember = ToString();

            pantsBindingSource.DataSource = myShop.PantsList;
            lst_Pants.DataSource = pantsBindingSource;
            lst_Pants.DisplayMember = ToString();

            cartBindingSource.DataSource = myShop.CartList;
            lst_Cart.DataSource = cartBindingSource;
        }

        

        
    }
}
