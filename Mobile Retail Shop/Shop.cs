﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public partial class Shop : UserControl
    {
        private string shopID;
        public Shop()
        {
            InitializeComponent();
        }

        public Shop(string shopID) : this() 
        {
            this.shopID = shopID;
        }

        private void new_product_btn_Click(object sender, EventArgs e)
        {
            if(ShopOwner.Instance.panelContainer.Controls.ContainsKey("Product"))
            {
                ShopOwner.Instance.panelContainer.Controls.Clear();
                Product addNewProduct = new Product(newProduct: true);
                addNewProduct.Dock = DockStyle.Fill;
                ShopOwner.Instance.panelContainer.Controls.Add(addNewProduct);

            }
        }
    }
}
