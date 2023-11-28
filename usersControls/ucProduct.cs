using PointOfSale.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.usersControls
{
    public partial class ucProduct : UserControl
    {
        public Product product;
        public ucProduct(Product product)
        {
            InitializeComponent();

            this.product = product;

            lblProductId.Text = product.Id.ToString();
            lblPrductName.Text = product.Name;
            lblProductDescription.Text = product.Description;
            lblProductSku.Text = product.SKU;
            lblProductPrice.Text = product.Price.ToString();

        }

        //public ucProduct(Product product, Action <Product> fnEdit) : this (product)
        //{
        //    this.fnEdit = fnEdit;
        //    btnEdit.Visible = true;
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //fnEdit(product);
        }
    }
}
