using FlexibleProject.Api.Abstractions;
using FlexibleProject.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlexibleProject.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{

    private readonly IUsersService _usersService;
    
    public UsersController(ILogger<UsersController> logger, IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> Get(int numberOfUsers)
    {
        var users = await _usersService.GetUsers(numberOfUsers);

        if (users is null)
        {
            return NotFound();
        }

        return Ok(users);
    }
}
