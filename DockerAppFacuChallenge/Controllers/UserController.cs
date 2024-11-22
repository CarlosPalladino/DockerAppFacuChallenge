using Applications.Interfaces.BankInterface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DockerAppFacuChallenge.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Endpoints to manage Widgets Sankey")]

    public class UserController : ControllerBase
    {
        private readonly IUserInteface _service;
        [HttpGet]
        public async Task GetallUser()
        {
            //var sd = await _service.GetUsers();
            return ;

        }



    }
}
