using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUser _user;
        public ValuesController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public IActionResult Get(int age)
        {
            //IUser user2 = new User();
            //_user = new User();
            _user.Create();
            return Ok();
        }
    }

    public interface IUser
    {
        void Create();
    }

    public class User : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Create()
        {
            Console.WriteLine("User class 1");
        }
    }

    public class User2 : IUser
    {
        public void Create()
        {
            Console.WriteLine("User class 2");
        }
    }
}
