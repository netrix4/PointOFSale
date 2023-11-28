using PointOfSale.Bussines;
using PointOfSale.Forms;
using PointOfSale.models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.usersControls
{
    public partial class ucProductsScreen : UserControl
    {
        private IProductService productService;

        public ucProductsScreen(IProductService productService)
        {
            InitializeComponent();
            this.productService = productService;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            Random randObj = new Random();

            newProduct.Name = txtProductName.Text;
            newProduct.Description = txtProductDescription.Text;

            newProduct.SKU = "PRD-" + randObj.Next(0,1000).ToString();
            newProduct.Price = decimal.Parse(txtProductPrice.Text);

            var response = productService.AddProduct(newProduct);

            if (response.IsValid)
            {

                txtProductName.Text = "";
                txtProductDescription.Text = "";
                txtProductPrice.Text = "";

                MessageBox.Show("Producto Guardado", newProduct.Name);

            }
            else
            {
                MessageBox.Show("Error Al Guardar producto");
            }
            
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }
        private void SearchProduct()
        {
            pnlProductList.Controls.Clear();
            string searchInput = txtSearchProduct.Text;
            var response = productService.SearchProducts(searchInput);
            int index = 0;

            foreach (var product in response.Data)
            {
                ucProduct prd = new ucProduct(product);
                prd.Click += ProductListClick;
                pnlProductList.Controls.Add(prd);
                prd.Location = new Point(0, prd.Height * index);

                index++;
            }
        }
        private void ProductListClick(object sender, EventArgs e)
        {
            ucProduct UserControlProduct = sender as ucProduct;

            EditProductScreen editProductScreen = new EditProductScreen(UserControlProduct.product);
            editProductScreen.ShowDialog();
            SearchProduct();

        }

        //private void btnEditAdd_Click(object sender, EventArgs e)
        //{
        //    Product product = new Product();

        //    product.Id = int.Parse(txtEditId.Text);
        //    product.Name = txtEditName.Text;
        //    product.Description = txtEditDescription.Text;
        //    product.SKU = txtEditSku.Text;
        //    product.Price = decimal.Parse(txtEditPrice.Text);

        //    bool response = dataProvider.UpdateProduct(product);
        //    if (response)
        //    {
        //        MessageBox.Show("Actualizado");
        //        txtEditId.Text = "";
        //        txtEditName.Text = "";
        //        txtEditDescription.Text = "";
        //        txtEditSku.Text = "";
        //        txtEditPrice.Text = "";


        //        tabControlProducts.SelectedTab = tabSearch;
        //        SearchProduct();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Algo salio mal");
        //    }
        //}

        //private void tabControlProducts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tabControlProducts.SelectedTab == tabEdit && txtEditId.Text == "")
        //    {
        //        MessageBox.Show("Haz una consulta primero");
        //        tabControlProducts.SelectedTab = tabSearch;
        //    }
        //}
    }
}