using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



        public ulong UserId { get; }
        public User User { get; set; }
    }
}