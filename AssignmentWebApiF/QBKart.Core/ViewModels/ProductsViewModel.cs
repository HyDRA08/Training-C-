using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QBKart.Core.ViewModels
{
    public class ProductsViewModel
    {
        public string ProductCode{get;set;}
        public string ProductName{get;set;}
        public string ProductDes { get; set; }
        public int Price{get;set;}
        public char Flag { get; set; }
    }
}
