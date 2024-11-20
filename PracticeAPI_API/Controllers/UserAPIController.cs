using Microsoft.AspNetCore.Mvc;
using PracticeAPI_API.Models.Dto;

namespace PracticeAPI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserDto>> GetUsers()
        {
            var villaList =  new List<UserDto>
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
            return Ok(villaList);
        }

        [HttpGet("id", Name = "GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UserDto> GetUser(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villa =  new UserDto { Id = 1, FirstName = "Kasra", LastName = "Nadri" };

            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UserDto> CreateUser([FromBody] UserDto userDto)
        {
            ModelState.AddModelError("", ""); //--- Custom Validation

            if (userDto == null)
            {
                return BadRequest(userDto);    
            }

            if (userDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return CreatedAtRoute("GetUser", new {id = userDto.Id}, userDto);
        }

        [HttpDelete("id")]
        public IActionResult DeleteUser(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var users = new List<UserDto>();
            var user = new UserDto();
            if (users == null)
            {
                return NotFound();
            }
            users.Remove(user);
            return NoContent();

        }
    }

   
}
