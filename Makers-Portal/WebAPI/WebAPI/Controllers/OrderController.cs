//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using WebAPI.Models;

//namespace WebAPI.Controllers
//{
//    [Produces("application/json")]
//    [Route("api/Order")]
//    public class OrderController : Controller
//    {
//        private readonly MakersPortalRepository makersPortalRepository;

//        public OrderController()
//        {
//            makersPortalRepository = new MakersPortalRepository();
//        }

//        [HttpPost]
//        public void Post([FromBody]Order order)
//        {
//            makersPortalRepository.CreateOrder(order);
//        }

//        //[HttpGet("{Id}")]
//        //public Items Get(int id)
//        //{
//        //    return makersPortalRepository.GetItemById(id);
//        //}

//        [HttpGet]
//        public IEnumerable<Order> Get()
//        {
//            return makersPortalRepository.GetAllOrder();
//        }

//        [HttpPut("{id}")]
//        public void Post(int id, [FromBody]Order order)
//        {
//            makersPortalRepository.UpdateOrder(order);
//        }
//        [HttpDelete]
//        public void Delete(int id)
//        {
//            makersPortalRepository.DeleteOrder(id);
//        }
//    }
//}