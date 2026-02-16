using EmergencyDispatchService.Application.Common.Interface;
using EmergencyDispatchService.Contracts.Users;
using EmergencyDispatchService.Domain.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace EmergencyDispatchService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserAsync(CreateUserRequest request)
    {
        if (request == null)
        {
            return BadRequest();
        }
        var user = new User(
            firstName: request.FirstName,
            lastName: request.LastName,
            phoneNumber: request.PhoneNumber);

        await _userRepository.AddUserAsync(user);
        return Ok(user.Id);
    }
}
