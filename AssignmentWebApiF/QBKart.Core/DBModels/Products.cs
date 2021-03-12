using System;
using System.Collections.Generic;

namespace QBKart.Data.DBModels
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProdcuctName { get; set; }
        public string ProductDesc { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ActiveFlag { get; set; }
    }
}
