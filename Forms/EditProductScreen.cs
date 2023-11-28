using PointOfSale.Bussines;
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

namespace PointOfSale.Forms
{
    public partial class EditProductScreen : Form
    {
        private IProductService productService= new Bussines.ProductService();
        private Product _product;
        public EditProductScreen(Product product)
        {
            InitializeComponent();

            _product = product;
            FillProductInformation();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product product = new Product();


            product.Id = int.Parse(txtEditId.Text);
            product.Name = txtEditName.Text;
            product.Description = txtEditDescription.Text;
            product.SKU = txtEditSku.Text;
            product.Price = decimal.Parse(txtEditPrice.Text);

            var response = productService.EditProduct(product);
            if (response.Data)
            {
                MessageBox.Show("Actualizado");
                txtEditId.Text = "";
                txtEditName.Text = "";
                txtEditDescription.Text = "";
                txtEditSku.Text = "";
                txtEditPrice.Text = "";

                Close();

                //SearchProduct();
            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        void FillProductInformation()
        {
            txtEditId.Text = _product.Id.ToString();
            txtEditName.Text = _product.Name;
            txtEditDescription.Text = _product.Description;
            txtEditPrice.Text = _product.Price.ToString();
            txtEditSku.Text = _product.SKU;
        }
    }
}
