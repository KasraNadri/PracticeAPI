using Microsoft.AspNetCore.Mvc;
using PracticeAPI_API.Models;
using PracticeAPI_API.Models.Dto;

namespace PracticeAPI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        [HttpGet]
        public List<UserDto> GetUsers()
        {
            return new List<UserDto>
            {
                new UserDto
                {
                    Id = 1, FirstName = "Kasra", LastName = "Nadri"
                },
                new UserDto
                {
                    Id = 2, FirstName = "Mohammad", LastName = "Ahmadi"
                }
            };
        }
    }
}
