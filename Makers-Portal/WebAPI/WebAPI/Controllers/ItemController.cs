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
//    [Route("api/Item")]
//    public class ItemController : Controller
//    {
//        private readonly MakersPortalRepository makersPortalRepository;

//        public ItemController()
//        {
//            makersPortalRepository = new MakersPortalRepository();
//        }

//        [HttpPost]
//        public void Post([FromBody]Items item)
//        {
//            makersPortalRepository.AddItem(item);
//        }

//        [HttpGet("{Id}")]
//        public Items Get(int id)
//        {
//            return makersPortalRepository.GetItemById(id);
//        }

//        [HttpGet]
//        public IEnumerable<Items> Get()
//        {
//            return makersPortalRepository.GetAllItem();
//        }

//        [HttpPut("{id}")]
//        public void Post(int id,[FromBody]Items item)
//        {
//            makersPortalRepository.UpdateItem(item);
//        }
//        [HttpDelete]
//        public void Delete(int id)
//        {
//            makersPortalRepository.DeleteItem(id);
//        }
//    }
//}