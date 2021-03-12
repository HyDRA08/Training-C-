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
        public List<int> Disable(List<int> ProductIds)
        {
            return _productRepository.Disable(ProductIds);
        }
        public List<int> Delete(List<int> ProductIds)
        {
            return _productRepository.Delete(ProductIds);
        }
        public ProductsViewModel Add(ProductsViewModel model)
        {
            return _productRepository.Add(model);
        }
        public ProductsViewModel Edit(ProductsViewModel model)
        {
            return _productRepository.Edit(model);
        }
        public List<ProductsViewModel> Search(string searchString, int pageNum, int pageSize)
        {
            return _productRepository.Search(searchString, pageNum, pageSize);
        }
    }
}
