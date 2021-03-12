using QBKart.Core.ViewModels;
using QBKart.Data.DBModels;
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
                    newentry.Price =Convert.ToInt32(product.ProductPrice);
                    newentry.ProductCode = product.ProductCode;
                    newentry.ProductDes = product.ProductDesc;
                    newentry.ProductName = product.ProdcuctName;
                    newentry.Flag = Convert.ToChar(product.ActiveFlag);
                    ProductList.Add(newentry);
                }
            }
            return ProductList;
        }
        public List<ProductsViewModel> Disable(ProductsViewModel model)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                Products product = new Products();
                var row = context.Products.Where(x => x.ProductCode == model.ProductCode).FirstOrDefault();
                if (row != null)
                {
                    row.ActiveFlag = "0";
                    context.Products.Update(row);
                    context.SaveChanges();
                    ProductList.Add(model);
                }
            }
            return (ProductList);
        }
        public List<ProductsViewModel> Add(ProductsViewModel model)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                bool codeExists = context.Products.Any(x => x.ProductCode == model.ProductCode);
                if (!codeExists) 
                {
                    Products product = new Products();
                    product.ProdcuctName = model.ProductName;
                    product.ProductCode = model.ProductCode;
                    product.ProductDesc = model.ProductDes;
                    product.ProductPrice = Convert.ToInt32(model.Price);
                    product.ActiveFlag = Convert.ToString(model.Flag);
                    context.Products.Add(product);
                    context.SaveChanges();
                    ProductList.Add(model);
                }
            }
            return (ProductList);
        }
        public List<ProductsViewModel> Edit(ProductsViewModel model)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                Products product = new Products();
                var row = context.Products.Where(x => x.ProductCode == model.ProductCode).FirstOrDefault();
                if(row!=null)
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
            return (ProductList);
        }
        public List<ProductsViewModel> Delete(ProductsViewModel model)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                Products product = new Products();
                var temp_var = model.ProductCode;
                bool i = context.Products.Any(x => x.ProductCode == temp_var);
                var entity = context.Products.FirstOrDefault(x => x.ProductCode == temp_var);
                if (entity==null)
                {
                    
                }
                else
                {
                    context.Products.Remove(entity);
                    context.SaveChanges();
                }
            }
            return (ProductList);
        }
        public List<ProductsViewModel> Search(string searchString, int PageNum, int NumItem)
        {
            List<ProductsViewModel> ProductList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                ProductList = context.Products.Where(x => x.ProdcuctName.Contains("e"))
                    .Select(x => new ProductsViewModel() {
                        ProductName=x.ProdcuctName,
                        ProductCode=x.ProductCode,
                        ProductDes=x.ProductDesc,
                        Price= Convert.ToInt32(x.ProductPrice),
                        Flag=Convert.ToChar(x.ActiveFlag)
                    })
                    .ToList();
            }
            return (ProductList);
        }
    }
}


