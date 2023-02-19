using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Domain.Models
{
    public class User 
    {
        public ulong Id { get; set; } 

        public string UserName { get; set; }

        public string RegisterDate { get; set; }

        public uint Jcoin { get; set; }

        public uint Scoin { get; set; }




        public User(ulong id, string userName)
        {
            Id = id;
            UserName = userName;
            RegisterDate = DateTime.Now.ToShortDateString();
            Jcoin = 0;
            Scoin = 1500;
        }
    }
}