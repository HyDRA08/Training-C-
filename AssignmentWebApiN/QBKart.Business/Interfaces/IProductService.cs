using QBKart.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBKart.Business.Interfaces
{
    public interface IProductService
    {
        List<ProductsViewModel> GetProduct(int pageNum, int pageSize);
        List<int> Disable(List<int> ProductIds);
        ProductsViewModel Add(ProductsViewModel model);
        ProductsViewModel Edit(ProductsViewModel model);
        List<int> Delete(List<int> productIds);
        List<ProductsViewModel> Search(string searchString, int pageNum, int pageSize);
    }
}
