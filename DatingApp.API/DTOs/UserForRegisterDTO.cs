using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDTO
    {
        //makes sense to validate the username here instead of our Model/User.cs class because the user's not responsible for creating everything in that code, it's happening inside our code
            // we do this by passing data annotations above the property we want to validate against

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Your password must be between 8 to 12 characters")]
        public string Password { get; set; }
    }
}