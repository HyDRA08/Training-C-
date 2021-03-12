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
//    [Route("api/User")]
//    public class UserController : Controller
//    {
//        private readonly MakersPortalRepository makersPortalRepository;

//        public UserController()
//        {
//            makersPortalRepository = new MakersPortalRepository();
//        }

//        [HttpPost]
//        public void Post([FromBody]User user)
//        {
//            makersPortalRepository.AddUser(user);
//        }

//        [HttpGet("{Id}")]
//        public User Get(int id)
//        {
//            return makersPortalRepository.GetUserByID(id);
//        }

//        [HttpGet]
//        public IEnumerable<User> Get()
//        {
//            return makersPortalRepository.GetAllUser();
//        }
        
//        [HttpDelete]
//        public void Delete(int id)
//        {
//            makersPortalRepository.DeleteUser(id);
//        }
//    }
//}