using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Domain.Models
{
    public class Guild
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public ulong OwnerID { get; set; }
    }
}
