using MediatR;
using Microsoft.AspNetCore.Mvc;
using Orion.API.Controllers.SeedWork;
using Orion.Application.AccountAppLayer.UseCases.UserUseCases.GetUserById;
using System.Threading.Tasks;

namespace Orion.API.Controllers
{
    
    public class UsersController : OrionBaseController
    {
        [HttpGet("{id}")]  //users/id
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var request = new GetUserByIdRequest { Id = id };
            var user = await Mediator.Send(request);
            return Ok(user);
        }
    }
}
