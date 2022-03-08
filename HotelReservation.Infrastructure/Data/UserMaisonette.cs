using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Infrastructure.Data.Models
{
    public class UserMaisonette
    {
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public int MaisonetteId { get; set; }
        [ForeignKey(nameof(MaisonetteId))]
        public Maisonette Maisonette { get; set; }
    }
}
