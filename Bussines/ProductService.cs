using PointOfSale.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Bussines
{
    class ProductService : SQLProvider, IProductService
    {
        public ServiceResponse<bool> AddProduct(Product product)
        {
            ServiceResponse<bool> serviceResponse = new ServiceResponse<bool>();
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            string query = "INSERT INTO [DBTest].[dbo].[Product] ([Name], [Description], [SKU], [Price]) VALUES (@Name, @Description, @SKU, @Price)";

            parameters.Add("Name", product.Name);
            parameters.Add("Description", product.Description);
            parameters.Add("SKU", product.SKU);
            parameters.Add("Price", product.Price.ToString());

            serviceResponse.Data = ExecuteQuery(query, parameters);
            return serviceResponse;
        }

        public ServiceResponse<bool> EditProduct(Product product)
        {
            ServiceResponse<bool> serviceResponse = new ServiceResponse<bool>();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string query = "  UPDATE [DBTest].[dbo].[Product] SET[Name] = @Name, [Description] = @Description, [SKU] = @SKU, [Price] = @Price  WHERE[Id] = @ID";

            parameters.Add("ID", product.Id.ToString());
            parameters.Add("Name", product.Name);
            parameters.Add("Description", product.Description);
            parameters.Add("SKU", product.SKU);
            parameters.Add("Price", product.Price.ToString());

            serviceResponse.Data = ExecuteQuery(query, parameters);
            return serviceResponse;
        }

        public ServiceResponse<Product> GetProductBySKU(string sku)
        {
            //string query = "SELECT * FROM [DBTest].[dbo].[Product] WHERE [SKU] = @SKU";
            //string query = "SELECT * FROM[DBTest].[dbo].[Product] WHERE [Name] LIKE  '%" + sku + "%' OR [SKU] LIKE '%" + sku + "%' OR [Description] LIKE '%" + sku+ "%'";
            string query = "SELECT * FROM[DBTest].[dbo].[Product] WHERE [Name] LIKE  '" + sku + "' OR [SKU] LIKE '" + sku + "' OR [Description] LIKE '" + sku + "'";


            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("SKU", sku);

            List<Product> productList = ExecuteConsult<Product>(query, parameters);

            ServiceResponse<Product> response = new ServiceResponse<Product>();

            if (productList.Count > 0)
            {
                response.Data = productList[0];

            }
            else
            {
                response.IsValid = false;
                response.Message = "No existe el  producto";
            }

            return response;
        }
        public ServiceResponse<List<Product>> SearchProducts(string search)
        {
            ServiceResponse<List<Product>> serviceResponse = new ServiceResponse<List<Product>>();
            string query = "SELECT * FROM[DBTest].[dbo].[Product] WHERE [Name] LIKE  '%' + @SearchInput + '%' OR [SKU] LIKE '%' + @SearchInput + '%' OR [Description] LIKE '%' + @SearchInput + '%'";
            //string query = "SELECT * FROM[DBTest].[dbo].[Product] WHERE [Name] LIKE  '%" +search+ "%' OR [SKU] LIKE '%" +search+ "%' OR [Description] LIKE '%" +search+ "%'";
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("SearchInput", search);
            serviceResponse.Data = ExecuteConsult<Product>(query, parameters);

            return serviceResponse;
        }
    }
}
