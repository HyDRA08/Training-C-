using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QBKart.Business.Interfaces;
using QBKart.Core.ViewModels;

namespace AssignmentWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productBusinessService)
        {
            _productService = productBusinessService;
        }
        [HttpGet]
        public ActionResult<List<ProductsViewModel>> GetProduct(int pageNum, int pageSize)
        {
            return _productService.GetProduct(pageNum, pageSize);
        }
        [HttpPost]
        public ActionResult<List<ProductsViewModel>> Disable([FromBody] ProductsViewModel model)
        {
            return _productService.Disable(model);
            //throw new NotImplementedException();
        }
        [HttpPost]
        
        public ActionResult<List<ProductsViewModel>> Add([FromBody] ProductsViewModel model)
        {
            return _productService.Add(model);
            //throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult<List<ProductsViewModel>> Edit([FromBody] ProductsViewModel model)
        {
            return _productService.Edit(model);
            //throw new NotImplementedException();
        }
        [HttpDelete]
        public ActionResult<List<ProductsViewModel>> Delete([FromBody] ProductsViewModel model)
        {
            return _productService.Delete(model);
            //throw new NotImplementedException();
        }
        [HttpGet]
        public ActionResult<List<ProductsViewModel>> Search(string ProductName, int PageNum, int NumItem)
        {
            return _productService.Search(ProductName,PageNum,NumItem);
            //throw new NotImplementedException();
        }
    }
}