using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.models
{
    public class Transaction
    {
        ////OldVersion
        //public List<Product> Products { get; set; }
        //public DateTime TransactionDate { get; set; }
        //public decimal Total { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Total { get; set; }
    }
}
