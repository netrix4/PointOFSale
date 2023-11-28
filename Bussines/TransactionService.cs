using PointOfSale.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Bussines;


namespace PointOfSale.Bussines
{
    class TransactionService : SQLProvider, ITransactionService
    {
        //public ServiceResponse<bool> AddTransaction(Transaction transaction)
        //{
        //    ServiceResponse<bool> serviceResponse = new ServiceResponse<bool>();
        //    serviceResponse.Data = true;

        //    string transactionQuery = "INSERT INTO [DBTest].[dbo].[Transactions] ([TransactionDate], [Total]) VALUES (GETDATE(), 0) SELECT SCOPE_IDENTITY()";
                        
        //    var transactionId = ExecuteQueryId(transactionQuery, new Dictionary<string, string>());

        //    // If transaction id value is higher than 0, then a new Id was created (the transacion Id).
        //    if (transactionId > 0)
        //    {
        //        foreach(var product in transaction.Products)
        //        {
        //            // TBD same case than last query
        //            string transactionDetailsQuery = "INSERT INTO [DBTest].[dbo].[TransactionDetails] ([TransactionId], [ProductId], [CreationDate]) VALUES (@TransactionId, @ProductId, GETDATE())";
                    
        //            Dictionary<string, string> transacionDetailsParameters = new Dictionary<string, string>();

        //            transacionDetailsParameters.Add("TransactionId", transactionId.ToString());
        //            transacionDetailsParameters.Add("ProductId", product.Id.ToString());                    
                    
        //            bool detailResponse = ExecuteQuery(transactionDetailsQuery, transacionDetailsParameters);
        //            if (!detailResponse)
        //            {
        //                serviceResponse.Data = false;
        //                serviceResponse.Message = "Algo salio mal con la insercion del detalle de la compra.";
        //            }
        //        }
        //    }
        //    else
        //    {
        //        serviceResponse.Data = false;
        //        serviceResponse.Message = "Algo salio mal con la insercion de la compra.";
        //    }

        //    return serviceResponse;
        //}

        public ServiceResponse<bool> AddTransaction(Transaction transaction)
        {
            ServiceResponse<bool> serviceResponse = new ServiceResponse<bool>();
            serviceResponse.Data = true;

            string transactionQuery = "INSERT INTO [DBTest].[dbo].[Transactions] ([TransactionDate], [Total]) VALUES (GETDATE(), "+transaction.Total+") SELECT SCOPE_IDENTITY()";

            var transactionId = ExecuteQueryId(transactionQuery, new Dictionary<string, string>());

            

            return serviceResponse;
        }


        public ServiceResponse<List<Transaction>> ListTransactions()
        {
            //throw new NotImplementedException("Please do something with me u.u");
            ServiceResponse<List<Transaction>> serviceResponse = new ServiceResponse<List<Transaction>>();
            string query = "SELECT * FROM[DBTest].[dbo].[Transactions]";
            //string query = "SELECT * FROM[DBTest].[dbo].[Product] WHERE [Name] LIKE  '%" +search+ "%' OR [SKU] LIKE '%" +search+ "%' OR [Description] LIKE '%" +search+ "%'";
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            //parameters.Add("SearchInput", '');
            serviceResponse.Data = ExecuteConsult<Transaction>(query, parameters);

            return serviceResponse;
        }
    }
}
