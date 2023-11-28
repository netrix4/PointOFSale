using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PointOfSale.Bussines;
using PointOfSale.models;

namespace PointOfSale.usersControls
{
    public partial class ucHomeScreen : UserControl
    {
        private IProductService productService;
        private ITransactionService transactionService;
        List<Product> productList;
        
        Action<int,Label> UpdateProductQuantity = (ProductQuantity, label) => label.Text = string.Format("Cantidad de prductos: {0}", ProductQuantity);
        
        public ucHomeScreen(IProductService productService, ITransactionService transactionService)
        {
            InitializeComponent();

            this.productService = productService;
            this.transactionService = transactionService;
            productList = new List<Product>();
        }

        private decimal GetTotal()
        {
            decimal total = 0;

            foreach (var product in productList)
            {
                total += product.Price;
            }

            return total;
        }

        private void txtMainInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string productSku = txtMainInput.Text;
                ServiceResponse<Product> response = productService.GetProductBySKU(productSku);
                //ServiceResponse<List<Product>> response = productService.SearchProducts(productSku);

                if (!response.IsValid)
                {
                    MessageBox.Show(string.Concat("Ha ocurrido un errro: "));
                    //MessageBox.Show(string.Concat("Ha ocurrido un errro: ", response.Message));
                    txtMainInput.Text = string.Empty;

                    return;
                }
                Product producto = response.Data;

                #region AddLabelProductToHistory

                //Label historylabel = new Label();
                //historylabel.Text = producto.ToString();
                //pnlHistoryList.Controls.Add(historylabel);
                //historylabel.Location = new Point(0, productList.Count * 20);

                #endregion

                ucProduct newProduct = new ucProduct(producto);
                pnlHistoryList.Controls.Add(newProduct);
                newProduct.Location = new Point(0, newProduct.Height * productList.Count);

                productList.Add(producto);

                txtMainInput.Text = "";
                UpdateProductQuantity(productList.Count, lblProductsQuantity);
                lblTotal.Text = string.Format("Total: {0}", GetTotal());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetProducts();
        }

        private void ucHomeScreen_Load(object sender, EventArgs e)
        {
            txtMainInput.Focus();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();

            transaction.Total = GetTotal();
            ServiceResponse<bool> serviceResponse = new ServiceResponse<bool>();
            serviceResponse = transactionService.AddTransaction(transaction);

            if (serviceResponse.IsValid)
            {
                MessageBox.Show("Transaccion registrada");
                ResetProducts();

            }
            else
            {
                MessageBox.Show(string.Concat( "Algo salio mal. ", serviceResponse.Message));

            }

        }
        private void ResetProducts()
        {
            pnlHistoryList.Controls.Clear();
            productList.Clear();
            UpdateProductQuantity(productList.Count, lblProductsQuantity);
            txtMainInput.Focus();
            lblTotal.Text = string.Format("Total: {0}", GetTotal());
        }

    }
}
