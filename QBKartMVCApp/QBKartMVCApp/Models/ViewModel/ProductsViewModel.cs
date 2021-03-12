using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QBKartMVCApp.Models.ViewModel
{
    public partial class ProductsViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Code")]
        [Required(ErrorMessage = "Product Code Required!!!")]
        public string ProductCode { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name Required!!!")]
        public string ProdcuctName { get; set; }

        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "Product Description Required!!!")]
        public string ProductDesc { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Product Price Required!!!")]
        public decimal? ProductPrice { get; set; }
    }
}
