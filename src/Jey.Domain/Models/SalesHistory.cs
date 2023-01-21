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



        [ForeignKey("userId")]
        public ulong SellTo { get; set; }
        public User User { get; set; }


        public string ItemDescription { get; set; }
        public string ItemKeyOrLink { get; set; }
        public int Price { get; set; }
        public Item Item { get; set; }
    }
}