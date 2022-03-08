using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Infrastructure.Data.Models
{
    public class User
    {
        public User()
        {
            this.Maisonettes = new List<Maisonette>();
        }
        [Key]
        public int Id { get; set; }
        
        [Required ,MaxLength(2048)]
        public string Email { get; set; }
        [Required,MaxLength(36)]
        public string Username { get; set; }
        [Required,MaxLength(64)]
        public string Password { get; set; }
        public string Avatar{ get; set; }
        //todo collection
        public IEnumerable<Maisonette> Maisonettes { get; set; }
    }
}
