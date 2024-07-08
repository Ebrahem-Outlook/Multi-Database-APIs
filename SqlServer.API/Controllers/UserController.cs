using Microsoft.AspNetCore.Mvc;
using SqlServer.API.Database;
using SqlServer.API.Models;
using SqlServer.API.Services;

namespace SqlServer.API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public sealed class UserController(IUserService userService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {
        await userService.Create(user);

        return Ok();
    }



}
