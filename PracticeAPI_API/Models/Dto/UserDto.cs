using System.ComponentModel.DataAnnotations;

namespace PracticeAPI_API.Models.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
    }
}
