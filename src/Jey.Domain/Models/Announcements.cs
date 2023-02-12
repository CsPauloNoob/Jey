using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Jey.Domain.EconomicItems;

namespace Jey.Domain.Models
{
    public class Announcements
    {
        [Key]
        public int AnnouncementId { get; set; }

        public string AnnouncementName { get; set; }

        public int AnnouncementsQuantity { get; set; }

        public int AnnouncementValue { get; set; }
        
        public Coins PaymentType { get; set; }



        public ulong UserIdAnnouncement { get; }
        [ForeignKey("UserIdAnnouncement")]
        public User User { get; set; }
    }
}