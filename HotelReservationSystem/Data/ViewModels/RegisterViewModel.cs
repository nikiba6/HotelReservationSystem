using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Data.ViewModels
{
    public class RegisterViewModel

    {
        [Required,StringLength(20, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters.")]
        public string FirstName { get; set; }
        [Required, StringLength(20, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters.")]

        public string LastName { get; set; }
        [Required,StringLength(20, MinimumLength = 5, ErrorMessage = "{0} must be between {2} and {1} characters.")]
        public string Username { get; set; }
        [Required,EmailAddress, StringLength(60, MinimumLength = 10, ErrorMessage = "Email must be valid. Must be between {2} and {1} characters.")]
        public string Email { get; set; }
        [Required,StringLength(20, MinimumLength = 5, ErrorMessage = "{0} must be between {2} and {1} chars.")]
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "Password and ConfirmPassword must be equal.")]
        public string ConfirmPassword { get; set; }
    }
}
