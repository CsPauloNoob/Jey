using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Domain.Models
{

    public class SalesHistory
    {
        public DateTime Date_sale { get; set; }
        public EconomicItems.Coins Coins { get; set; }

        public ulong SellTo { get; set; }
        [ForeignKey("SellTo")]
        public User User { get; set; }

        public string ItemDescription { get; set; }
        public string ItemKeyOrLink { get; set; }
        [ForeignKey("ItemKeyOrLink")]
        public Item Item { get; set; }
        public int Price { get; set; }
    }
}