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
        public List<int> Disable(List<int> ProductIds)
        {
            return _productService.Disable(ProductIds);
        }
        [HttpPost]
        public ActionResult<ProductsViewModel> Add([FromBody] ProductsViewModel model)
        {
            return _productService.Add(model);
        }
        [HttpPost]
        public ActionResult<ProductsViewModel> Edit([FromBody] ProductsViewModel model)
        {
            return _productService.Edit(model);
        }
        [HttpPost]
        public List<int> Delete(List<int> ProductIds)
        {
            return _productService.Delete(ProductIds);
        }
        [HttpGet]
        public ActionResult<List<ProductsViewModel>> Search(string searchString, int PageNo, int PageSize)
        {
            return _productService.Search(searchString, PageNo, PageSize);
        }
    }
}