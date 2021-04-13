using System;
using System.Collections.Generic;
using System.Text;

namespace Hca.SnackTrust.Core.Entities
{
    public class Sale
    {
        public DateTime SaleDate { get; set; }

        public Item ItemSold { get; set; }

        public double CurrencyDeposited { get; set; }

        public double ChangeGiven { get; set; }

        public double TotalSale { get; set; }

    }
}
