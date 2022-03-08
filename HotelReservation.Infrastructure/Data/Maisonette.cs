using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Infrastructure.Data.Models
{
    public class Maisonette
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(20)]
        public string MaisonetteName { get; set; }
        [Required]
        public string Image { get; set; }
        public int Capacity { get; set; }
        public int NumberOfRooms { get; set; }
        public bool IsAvailable { get; set; }
        public IEnumerable<User> Users { get; set; }

    }
}
