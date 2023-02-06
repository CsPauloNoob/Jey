using Jey.Domain;
using Jey.Domain.Models;
using Jey.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jey.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>
    {

        public UserRepository(JeyContext context) : base(context)
        {

        }


        public override User GetById(ulong id)
        {
            var user = _context.User.FindAsync(id).Result;

            return user;
        }

        public override List<User> GetAll()
        {
            return _context.User.ToListAsync().Result;
        }

        public override void Save(User user)
        {
            _context.User.Add(user);
        }
    }
}