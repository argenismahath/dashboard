using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/User/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IrepositorioUser IrepositorioUser { get; }

        public UserController(IrepositorioUser irepositorioUser)
        {
            IrepositorioUser = irepositorioUser;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public user InserUser(user user)
        {
            IrepositorioUser.Crear(user);

            return user;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
