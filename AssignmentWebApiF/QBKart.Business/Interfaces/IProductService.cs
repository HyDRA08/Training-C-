using QBKart.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBKart.Business.Interfaces
{
    public interface IProductService
    {
        List<ProductsViewModel> GetProduct(int pageNum, int pageSize);
        List<ProductsViewModel> Disable(ProductsViewModel model);
        List<ProductsViewModel> Add(ProductsViewModel model);
        List<ProductsViewModel> Edit(ProductsViewModel model);
        List<ProductsViewModel> Delete(ProductsViewModel model);
        List<ProductsViewModel> Search(string ProductName, int PageNum, int NumItem);
    }
}
