using Microsoft.AspNetCore.Mvc;
using PracticeAPI_API.Models;

namespace PracticeAPI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public List<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa
                {
                    Id = 1, Name = "Pool View"
                },
                new Villa
                {
                    Id = 1, Name = "Beachside View"
                }
            };
        }
    }
}
