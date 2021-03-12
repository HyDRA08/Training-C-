using QBKart.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBKart.Data.Interfaces
{
    public interface IProductRepository
    {
        List<ProductsViewModel> GetProduct(int pageNum, int pageSize);
        List<int> Disable(List<int> ProductIds);
        List<int> Delete(List<int> productIds);
        ProductsViewModel Add(ProductsViewModel model);
        ProductsViewModel Edit(ProductsViewModel model);
        List<ProductsViewModel> Search(string searchString, int pageNum, int pageSize);
    }
}
