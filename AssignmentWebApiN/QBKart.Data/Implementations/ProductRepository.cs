using AssignmentWebApi.DBModels;
using QBKart.Core.ViewModels;
using QBKart.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QBKart.Data.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public List<ProductsViewModel> GetProduct(int pageNum, int pageSize)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                var products = context.Products;
                foreach (var product in products)
                {
                    ProductsViewModel newentry = new ProductsViewModel();
                    newentry.ProductId = product.ProductId;
                    newentry.Price = Convert.ToInt32(product.ProductPrice);
                    newentry.ProductCode = product.ProductCode;
                    newentry.ProductDes = product.ProductDesc;
                    newentry.ProductName = product.ProdcuctName;
                    newentry.Flag = Convert.ToChar(product.ActiveFlag);
                    ProductList.Add(newentry);
                }
            }
            return ProductList;
        }
        public List<int> Disable(List<int> ProductIds)
        {
            using (var context = new Trainee1334Context())
            {
                var products = context.Products.Where(p => ProductIds.Contains(p.ProductId));
                foreach (var product in products)
                {
                    product.ActiveFlag = "0";
                }
                context.SaveChanges();
            }
            return ProductIds;
        }
        public ProductsViewModel Add(ProductsViewModel model)
        {
            var prd = new Products();
            using (var context = new Trainee1334Context())
            {
                prd.ProdcuctName = model.ProductName;
                prd.ProductCode = model.ProductCode;
                prd.ProductDesc = model.ProductDes;
                prd.ProductPrice = Convert.ToInt32(model.Price);
                context.Add(prd);
                context.SaveChanges();
            }
            model.ProductId = prd.ProductId;
            return model;
        }
        public ProductsViewModel Edit(ProductsViewModel model)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                Products product = new Products();
                var row = context.Products.Where(x => x.ProductCode == model.ProductCode).FirstOrDefault();
                if (row != null)
                {
                    row.ProdcuctName = model.ProductName;
                    row.ProductCode = model.ProductCode;
                    row.ProductDesc = model.ProductDes;
                    row.ProductPrice = Convert.ToInt32(model.Price);
                    context.Products.Update(row);
                    context.SaveChanges();
                    ProductList.Add(model);
                }
            }
            return model;
        }
        public List<int> Delete(List<int> ProductIds)
        {
            using (var context = new Trainee1334Context())
            {
                var products = context.Products.Where(p => ProductIds.Contains(p.ProductId));
                foreach (var product in products)
                {
                    context.Products.Remove(product);
                }
                context.SaveChanges();
            }
            return ProductIds;
        }
        public List<ProductsViewModel> Search(string searchString, int pageNum, int pageSize)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                ProductList = context.Products.Where(x => x.ProdcuctName.Contains(searchString))
                    .Select(x => new ProductsViewModel()
                    {
                        ProductName = x.ProdcuctName,
                        ProductCode = x.ProductCode,
                        ProductDes = x.ProductDesc,
                        Price = Convert.ToInt32(x.ProductPrice),
                        Flag = Convert.ToChar(x.ActiveFlag)
                    })
                    .ToList();
            }
            return (ProductList);
        }
    }
}
