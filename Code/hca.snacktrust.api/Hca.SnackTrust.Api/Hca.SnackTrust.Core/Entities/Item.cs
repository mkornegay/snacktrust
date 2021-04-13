using System;
using System.Collections.Generic;
using System.Text;

namespace Hca.SnackTrust.Core.Entities
{
    public class Item : BaseEntity
    {
        public string ItemDescription { get; set; }
        public double Price { get; set; }
        public int QuantityOnHand { get; set; }
    }
}
