using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Bussines;

namespace PointOfSale.usersControls
{
    public partial class ucReceiptScreen : UserControl
    {
        ITransactionService transactionService;
        public ucReceiptScreen(ITransactionService transactionService)
        {
            InitializeComponent();
            this.transactionService = transactionService;
        }

        private void tbnRefresh_Click(object sender, EventArgs e)
        {
            SearchTransactions();
        }
        private void SearchTransactions()
        {
            pnlTransactionList.Controls.Clear();

            var response = transactionService.ListTransactions();
            int index = 0;

            foreach (var transaction in response.Data)
            {
                ucTransaction prd = new ucTransaction(transaction);
                //prd.Click += ProductListClick;
                pnlTransactionList.Controls.Add(prd);
                prd.Location = new Point(0, prd.Height * index);

                index++;
            }
        }
    }
}
