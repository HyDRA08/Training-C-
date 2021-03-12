using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QBKartMVCApp.Models;
using QBKartMVCApp.Models.DBModel;
using QBKartMVCApp.Models.ViewModel;

namespace QBKartMVCApp.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }
        public IActionResult Index()
        {
            List<ProductsViewModel> productList= new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                productList = context.Products.Select(x => new ProductsViewModel
                {
                    ProductId=x.ProductId,
                    ProductCode = x.ProductCode,
                    ProdcuctName = x.ProdcuctName,
                    ProductDesc=x.ProductDesc,
                    ProductPrice=x.ProductPrice

                }).ToList();
            }
            return View(productList);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddValue(Products model)
        {
            try
            {
                Trainee1334Context context = new Trainee1334Context();
                bool codeExists = context.Products.Any(x => x.ProductCode == model.ProductCode);
                if (!codeExists)
                {
                    Products pro = new Products();
                    if(string.IsNullOrEmpty(model.ProductCode) && string.IsNullOrEmpty(model.ProdcuctName) && model.ProductPrice!=null && string.IsNullOrEmpty(model.ProductDesc))
                    {
                        pro.ProductCode = model.ProductCode;
                        pro.ProdcuctName = model.ProdcuctName;
                        pro.ProductDesc = model.ProductDesc;
                        pro.ProductPrice = model.ProductPrice;
                        context.SaveChanges();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
        public IActionResult EditValue(Products model)
        {
            try
            {
                Trainee1334Context context = new Trainee1334Context();
                Products pro = context.Products.Where(p => p.ProductCode == model.ProductCode).FirstOrDefault();
                if (pro != null)
                {
                    if (!string.IsNullOrEmpty(model.ProdcuctName) && model.ProductPrice!=null && !string.IsNullOrEmpty(model.ProductDesc))
                    {
                        pro.ProdcuctName = model.ProdcuctName;
                        pro.ProductDesc = model.ProductDesc;
                        pro.ProductPrice = model.ProductPrice;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
