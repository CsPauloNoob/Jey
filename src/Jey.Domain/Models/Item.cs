using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Jey.Domain.EconomicItems;

namespace Jey.Domain.Models
{
    public class Item
    {
        [Required]
        public string ItemKeyOrLink { get; set; }

        [MaxLength(64)]
        public string ItemDescription { get; set; }

        public int Jcoin { get; set; }

        public int Scoin { get; set; }
    }
}