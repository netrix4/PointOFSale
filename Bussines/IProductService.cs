using PointOfSale.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Bussines
{
    public interface IProductService
    {
        ServiceResponse<bool> AddProduct(Product product);
        ServiceResponse<bool> EditProduct(Product product);
        ServiceResponse<Product> GetProductBySKU(string sku);
        ServiceResponse<List<Product>> SearchProducts(string search="");
    }
}
