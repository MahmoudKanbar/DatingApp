using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;
        public UsersController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<AppUser> GetUsers()
        {
            return context.Users.ToList();
        }

        [HttpGet("{id}")]
        public AppUser GetUser(int id)
        {
            return context.Users.Find(id);
        }
    }
}