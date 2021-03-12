using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Models;
using MVCAssignment.Models.DBModel;
using MVCAssignment.Models.ViewModel;

namespace MVCAssignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<ProductsViewModel> productList = new List<ProductsViewModel>();
            using (var context = new Trainee1334Context())
            {
                productList = context.Products.Select(x => new ProductsViewModel
                {
                    ProductId = x.ProductId,
                    ProductCode = x.ProductCode,
                    ProdcuctName = x.ProdcuctName,
                    ProductDesc = x.ProductDesc,
                    ProductPrice = x.ProductPrice

                }).ToList();
            }
            return View(productList);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("AddnEdit");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ProductsViewModel productList = new ProductsViewModel();
            using (var context = new Trainee1334Context())
            {
                var pro = context.Products.Find(id);
                if (pro == null)
                {
                    return RedirectToAction("Index");
                }
                productList.ProductId = pro.ProductId;
                productList.ProdcuctName = pro.ProdcuctName;
                productList.ProductDesc = pro.ProductDesc;
                productList.ProductCode = pro.ProductCode;
                productList.ProductPrice = pro.ProductPrice;
            }
            return View("AddnEdit", productList);
        }
        [HttpPost]
        public IActionResult AddnEdit(ProductsViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var context = new Trainee1334Context())
                {
                    //var query = context.Products.Where(x => x.ProductId==model.ProductId).Select(x=>x.ProductId);
                    Products pro = context.Products.Where(x => x.ProductId == model.ProductId).FirstOrDefault();

                    if (pro != null) //Edit
                    {
                        if (pro.ProductCode != model.ProductCode)
                        {
                            var codeExist = context.Products.Any(x => x.ProductCode == model.ProductCode);
                            if (codeExist)
                            {
                                ModelState.AddModelError("ProductCode", "Product Code not available | EDIT");
                                return View(model);
                            }
                        }
                        pro.ProductCode = model.ProductCode;
                        pro.ProdcuctName = model.ProdcuctName;
                        pro.ProductDesc = model.ProductDesc;
                        pro.ProductPrice = model.ProductPrice;
                        context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else //Add
                    {
                        var codeExist = context.Products.Any(x => x.ProductCode == model.ProductCode);
                        if (codeExist)
                        {
                            ModelState.AddModelError("ProductCode", "Product Code not available | ADD");
                            return View(model);
                        }
                        Products product = new Products();
                        product.ProductCode = model.ProductCode;
                        product.ProdcuctName = model.ProdcuctName;
                        product.ProductDesc = model.ProductDesc;
                        product.ProductPrice = model.ProductPrice;
                        context.Products.Add(product);
                        context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            using (var context = new Trainee1334Context())
            {
                Products pro = context.Products.Find(id);
                if (pro != null)
                {
                    context.Products.Remove(pro);
                    context.SaveChanges();
                }
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
