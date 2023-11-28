using PointOfSale.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Bussines
{
    public interface ITransactionService
    {
        ServiceResponse<bool> AddTransaction(Transaction transaction);
        ServiceResponse<List<Transaction>> ListTransactions();
    }
}
