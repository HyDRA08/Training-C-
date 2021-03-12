using QBKart.Business.Interfaces;
using QBKart.Core.ViewModels;
using QBKart.Data.Interfaces;
using QBKart.Data.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBKart.Business.Implementations
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ProductsViewModel> GetProduct(int pageNum, int pageSize)
        {
            return _productRepository.GetProduct(pageNum, pageSize);
        }
        public List<ProductsViewModel> Disable(ProductsViewModel model)
        {
            return _productRepository.Disable(model);
        }
        public List<ProductsViewModel> Add(ProductsViewModel model)
        {
            return _productRepository.Add(model);
        }
        public List<ProductsViewModel> Edit(ProductsViewModel model)
        {
            return _productRepository.Edit(model);
        }
        public List<ProductsViewModel> Delete(ProductsViewModel model)
        {
            return _productRepository.Delete(model);
        }
        public List<ProductsViewModel> Search(string ProductName, int PageNum, int NumItem)
        {
            return _productRepository.Search(ProductName,PageNum,NumItem);
        }
    }
}
