using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Domain.Models
{
    public class User :Commons
    {
        public ulong UserId { get; set; }

        public string UserName { get; set; }

        public DateTime RegisterDate { get; set; }

        public uint Jcoin { get; set; }

        public uint Scoin { get; set; }
    }
}